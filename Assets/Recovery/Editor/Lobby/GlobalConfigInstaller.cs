#if UNITY_EDITOR
using System;
using Soccer.Recovery.Lobby;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
namespace Soccer.Recovery.Editor
{
    public static class GlobalConfigInstaller
    {
        public static void InstallBatch()
        {
            try
            {
                const string scriptPath="Assets/Scripts/Assembly-CSharp/Win_GlobalConfig.cs";
                var script=AssetDatabase.LoadAssetAtPath<MonoScript>(scriptPath);
                if(script==null || script.GetClass()==null || script.GetClass().FullName!="Win_GlobalConfig" || script.GetClass().Assembly.GetName().Name!="Assembly-CSharp")
                    throw new Exception("Replacement assembly/type mismatch");
                if(AssetDatabase.AssetPathToGUID(scriptPath)!="6b28ac2d25f6486b3da95bd206b9d665") throw new Exception("Replacement GUID mismatch");
                var prefab=AssetDatabase.LoadAssetAtPath<GameObject>("Assets/gamedata/ui/windows/Win_GlobalConfig.prefab");
                if(prefab==null || GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(prefab)!=0) throw new Exception("Prefab still has missing script");
                var scene=EditorSceneManager.OpenScene("Assets/Recovery/Scenes/LobbyOffline.unity",OpenSceneMode.Single);
                var found=0;
                foreach(var root in scene.GetRootGameObjects()) foreach(var marker in root.GetComponentsInChildren<LobbyLoadedMarker>(true))
                { marker.SetOfflineConfigPrefab(prefab); EditorUtility.SetDirty(marker); found++; }
                if(found!=1) throw new Exception("Expected one LobbyLoadedMarker");
                EditorSceneManager.MarkSceneDirty(scene);
                if(!EditorSceneManager.SaveScene(scene)) throw new Exception("Could not save Lobby integration");
                Debug.Log("GlobalConfig replacement type, assembly, GUID, prefab and Lobby binding verified.");
                EditorApplication.Exit(0);
            }
            catch(Exception e){Debug.LogException(e);EditorApplication.Exit(1);}
        }
    }
}
#endif
