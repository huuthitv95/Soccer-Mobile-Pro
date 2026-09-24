#if UNITY_EDITOR
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Soccer.Recovery.Tests
{
    public sealed class OfflineUIPlayModeTests
    {
        private OfflineUIController ui;
        private OfflinePointerInput input;
        private Camera camera;
        private const string ScenePath = "Assets/Recovery/Scenes/OfflineUI.unity";

        private IEnumerator Load()
        {
            yield return EditorSceneManager.LoadSceneAsyncInPlayMode(ScenePath, new LoadSceneParameters(LoadSceneMode.Single));
            yield return null;
            ui = UnityEngine.Object.FindObjectOfType<OfflineUIController>();
            Assert.NotNull(ui);
            camera = UnityEngine.Object.FindObjectOfType<Camera>();
            var module = EventSystem.current.GetComponent<StandaloneInputModule>();
            Assert.NotNull(module);
            input = module.gameObject.AddComponent<OfflinePointerInput>();
            module.inputOverride = input;
            yield return null;
        }

        private Vector2 Position(RectTransform rect, float horizontal = 0.5f)
        {
            var local = new Vector3(Mathf.Lerp(rect.rect.xMin, rect.rect.xMax, horizontal), rect.rect.center.y, 0);
            return RectTransformUtility.WorldToScreenPoint(camera, rect.TransformPoint(local));
        }

        private IEnumerator Click(RectTransform rect, float horizontal = 0.5f)
        {
            input.Position = Position(rect, horizontal);
            input.Held = input.Down = true;
            yield return null;
            input.Down = input.Held = false; input.Up = true;
            yield return null;
            input.Up = false;
            yield return null;
        }

        [UnityTest]
        public IEnumerator PointerClickChangesPanelsExactlyOnce()
        {
            yield return Load();
            Assert.NotNull(ui.ViewTeamButton.onClick);
            var events = 0; ui.ViewTeamButton.onClick.AddListener(() => events++);
            Assert.IsFalse(ui.TeamVisible);
            yield return Click((RectTransform)ui.ViewTeamButton.transform);
            Assert.AreEqual(1, events);
            Assert.AreEqual(1, ui.TeamOpenCount);
            Assert.IsTrue(ui.TeamVisible);
            yield return Click((RectTransform)ui.BackButton.transform);
            Assert.IsFalse(ui.TeamVisible);
            LogAssert.NoUnexpectedReceived();
        }

        [UnityTest]
        public IEnumerator SliderRespondsToPointerAndNotifiesOnce()
        {
            yield return Load();
            var events = 0; ui.PreviewSlider.onValueChanged.AddListener(_ => events++);
            yield return Click((RectTransform)ui.PreviewSlider.transform, 0.8f);
            Assert.That(ui.PreviewSlider.value, Is.InRange(0.7f, 0.95f));
            Assert.AreEqual(1, events);
            LogAssert.NoUnexpectedReceived();
        }

        [UnityTest]
        public IEnumerator ReloadAndReenableDoNotDuplicateListeners()
        {
            for (var i = 0; i < 3; i++)
            {
                yield return Load();
                ui.enabled = false; ui.enabled = true;
                yield return Click((RectTransform)ui.ViewTeamButton.transform);
                Assert.AreEqual(1, ui.TeamOpenCount, "Reload " + i);
                Assert.AreEqual(1, UnityEngine.Object.FindObjectsOfType<EventSystem>().Length);
                Assert.AreEqual(1, UnityEngine.Object.FindObjectsOfType<OfflineUIController>().Length);
            }
            LogAssert.NoUnexpectedReceived();
        }

        [UnityTest]
        public IEnumerator RenderAndRaycastAtBothAspectRatios()
        {
            yield return Load();
            var folder = Environment.GetEnvironmentVariable("SOCCER_OFFLINE_REPORTS");
            if (string.IsNullOrEmpty(folder)) folder = Path.Combine(Application.temporaryCachePath, "SoccerOfflineUI");
            Directory.CreateDirectory(folder);
            foreach (int width in new[] {1920, 2560})
            {
                var rt = new RenderTexture(width, 1080, 24);
                var previous = camera.targetTexture;
                camera.targetTexture = rt;
                yield return null;
                Canvas.ForceUpdateCanvases();
                var fill = ui.PreviewSlider.fillRect;
                Assert.That(fill.rect.width, Is.EqualTo(((RectTransform)fill.parent).rect.width * ui.PreviewSlider.normalizedValue).Within(1), "Slider fill must remain within its track");
                foreach (var text in UnityEngine.Object.FindObjectsOfType<Text>())
                {
                    Assert.NotNull(text.font, text.name);
                    Assert.LessOrEqual(text.preferredHeight, text.rectTransform.rect.height + 1, "Text clipped: " + text.name);
                }
                var pointer = new PointerEventData(EventSystem.current) { position = Position((RectTransform)ui.ViewTeamButton.transform) };
                var hits = new List<RaycastResult>(); EventSystem.current.RaycastAll(pointer, hits);
                Assert.IsTrue(hits.Exists(h => h.gameObject == ui.ViewTeamButton.gameObject), "Button raycast at " + width);
                Save(camera, rt, Path.Combine(folder, "welcome-" + width + "x1080.png"));
                ui.ViewTeamButton.onClick.Invoke();
                yield return null;
                Save(camera, rt, Path.Combine(folder, "team-" + width + "x1080.png"));
                ui.BackButton.onClick.Invoke();
                camera.targetTexture = previous;
                rt.Release(); UnityEngine.Object.Destroy(rt);
            }
            LogAssert.NoUnexpectedReceived();
        }

        private static void Save(Camera camera, RenderTexture target, string path)
        {
            camera.Render();
            var previous = RenderTexture.active;
            RenderTexture.active = target;
            var image = new Texture2D(target.width, target.height, TextureFormat.RGB24, false);
            image.ReadPixels(new Rect(0, 0, target.width, target.height), 0, 0);
            image.Apply();
            File.WriteAllBytes(path, image.EncodeToPNG());
            RenderTexture.active = previous;
            UnityEngine.Object.Destroy(image);
        }
    }
}
#endif
