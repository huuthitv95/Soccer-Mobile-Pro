using System;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace Soccer.Recovery.GlobalConfig
{
    public class OfflineConfigWindow : MonoBehaviour
    {
        private GameObject canvasRoot, panel;
        private RectTransform content;
        private Font font;
        private Text status, banner, heading;
        private Image background, launcherImage;
        private InputField search, number, profile;
        private Toggle showBanner;
        private readonly List<GameObject> rows = new List<GameObject>();
        public OfflineConfigSession Session { get; private set; }
        public bool IsOpen { get { return panel != null && panel.activeSelf; } }
        public string StoragePath { get; private set; }
        public Color AppliedAccent { get; private set; }
        public float AppliedOpacity { get { return background == null ? 0 : background.color.a; } }
        public string AppliedProfile { get { return banner == null ? null : banner.text; } }
        public bool BannerVisible { get { return banner != null && banner.gameObject.activeSelf; } }

        public void Initialize(string path = null)
        {
            if (Session != null) return;
            StoragePath=path ?? System.IO.Path.Combine(Application.persistentDataPath,"Recovery","global-config-v1.json");
            Session=new OfflineConfigSession(new OfflineConfigStore(StoragePath));
            font=Resources.GetBuiltinResource<Font>("Arial.ttf");
            canvasRoot=new GameObject("Offline configuration",typeof(RectTransform),typeof(Canvas),typeof(CanvasScaler),typeof(GraphicRaycaster));
            canvasRoot.transform.SetParent(transform,false);
            var canvas=canvasRoot.GetComponent<Canvas>(); canvas.renderMode=RenderMode.ScreenSpaceOverlay; canvas.sortingOrder=100;
            var scaler=canvasRoot.GetComponent<CanvasScaler>(); scaler.uiScaleMode=CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution=new Vector2(1920,1080); scaler.matchWidthOrHeight=.5f;
            var launch=Button(canvasRoot.transform,"Open offline config","Cấu hình offline",new Vector2(760,480),new Vector2(320,60),Open);
            launcherImage=launch.GetComponent<Image>();
            banner=Label(canvasRoot.transform,"Config profile","",new Vector2(-700,480),new Vector2(460,50),24);
            panel=Rect(canvasRoot.transform,"Global config panel",Vector2.zero,new Vector2(1150,850)).gameObject;
            background=panel.AddComponent<Image>();
            heading=Label(panel.transform,"Config heading","CẤU HÌNH OFFLINE",new Vector2(-160,370),new Vector2(760,65),34);
            Label(panel.transform,"Config origin","Bản tái tạo • thiết lập cho recovery",new Vector2(-130,318),new Vector2(820,42),23);
            Button(panel.transform,"Close config","Đóng",new Vector2(450,370),new Vector2(180,55),Cancel);
            search=Input(panel.transform,"Config search","Tìm thiết lập…",new Vector2(0,260),new Vector2(1050,52));
            var viewport=Rect(panel.transform,"Config viewport",new Vector2(0,-8),new Vector2(1050,440));
            viewport.gameObject.AddComponent<Image>().color=new Color(.03f,.07f,.09f,.8f);
            viewport.gameObject.AddComponent<RectMask2D>();
            content=Rect(viewport,"Config rows",Vector2.zero,new Vector2(1050,OfflineConfigRegistry.Fields.Length*66));
            content.anchorMin=new Vector2(.5f,1); content.anchorMax=content.anchorMin; content.pivot=new Vector2(.5f,1);
            var scroll=viewport.gameObject.AddComponent<ScrollRect>(); scroll.viewport=viewport; scroll.content=content; scroll.horizontal=false; scroll.movementType=ScrollRect.MovementType.Clamped; scroll.scrollSensitivity=35;
            for(var i=0;i<OfflineConfigRegistry.Fields.Length;i++) BuildRow(i);
            search.onValueChanged.AddListener(Filter);
            status=Label(panel.transform,"Config status",Session.Notice ?? "Chỉnh giá trị rồi chọn Lưu và áp dụng.",new Vector2(0,-290),new Vector2(1050,65),23);
            Button(panel.transform,"Reset config","Mặc định",new Vector2(-350,-365),new Vector2(290,60),ResetDraft);
            Button(panel.transform,"Cancel config","Hủy",new Vector2(0,-365),new Vector2(270,60),Cancel);
            Button(panel.transform,"Save config","Lưu và áp dụng",new Vector2(350,-365),new Vector2(330,60),SaveFromControls);
            Bind(); Apply(); panel.SetActive(false);
        }

        private void BuildRow(int index)
        {
            var field=OfflineConfigRegistry.Fields[index];
            var row=Rect(content,"Config row "+field.Key,new Vector2(0,-index*66-33),new Vector2(1040,60));
            row.anchorMin=row.anchorMax=new Vector2(.5f,1); rows.Add(row.gameObject);
            Label(row,field.Key+" label",field.Label,new Vector2(-210,0),new Vector2(610,52),23);
            if (!field.Editable) { Label(row,field.Key+" unsupported","Chưa hỗ trợ • gốc: "+field.DefaultValue,new Vector2(325,0),new Vector2(365,52),20); return; }
            if(field.Key=="showBanner")
            {
                var rect=Rect(row,"Config showBanner",new Vector2(325,0),new Vector2(350,50));
                showBanner=rect.gameObject.AddComponent<Toggle>();
                var box=Rect(rect,"Toggle box",new Vector2(-135,0),new Vector2(36,36)).gameObject.AddComponent<Image>(); box.color=new Color(.25f,.3f,.35f);
                var check=Rect(box.transform,"Check",Vector2.zero,new Vector2(24,24)).gameObject.AddComponent<Image>(); check.color=Color.white;
                showBanner.targetGraphic=box; showBanner.graphic=check;
                Label(rect,"Toggle label","Hiện nhãn",new Vector2(30,0),new Vector2(270,48),22);
            }
            else if(field.Key=="panelOpacity") number=Input(row,"Config opacity","0.65–1.00",new Vector2(325,0),new Vector2(350,50));
            else if(field.Key=="profileName") { profile=Input(row,"Config name","Tên hồ sơ",new Vector2(325,0),new Vector2(350,50)); profile.characterLimit=32; }
            else
            {
                // Explicit enum cycling keeps the control usable without a prefab template.
                var b=Button(row,"Config accent","",new Vector2(325,0),new Vector2(350,50),()=> {
                    Session.Draft.accent=(OfflineAccent)(((int)Session.Draft.accent+1)%3); UpdateAccentText();
                });
                accentText=b.GetComponentInChildren<Text>();
            }
        }
        private Text accentText;
        private void UpdateAccentText() { accentText.text=Session.Draft.accent+"  ›"; }
        private void Bind()
        { showBanner.isOn=Session.Draft.showBanner; number.text=Session.Draft.panelOpacity.ToString("0.00",CultureInfo.InvariantCulture); profile.text=Session.Draft.profileName; UpdateAccentText(); }
        public void Open() { Initialize(); Session.Begin(); Bind(); search.text=""; panel.SetActive(true); status.text=Session.Notice ?? "Chỉnh giá trị rồi chọn Lưu và áp dụng."; }
        public void Cancel() { if(Session==null)return; Session.Cancel(); Bind(); panel.SetActive(false); }
        public void ResetDraft() { Session.ResetDraft(); Bind(); status.text="Đã chọn mặc định. Chọn Lưu để áp dụng, hoặc Hủy."; }
        public void SaveFromControls()
        {
            string error;
            if(!Session.SetNumber(number.text,out error)){status.text=error;return;}
            Session.Draft.showBanner=showBanner.isOn; Session.Draft.profileName=profile.text.Trim();
            if(!Session.Save(out error)){status.text=error;return;}
            Apply(); status.text="Đã lưu và áp dụng cấu hình offline.";
        }
        public void Apply()
        {
            var data=Session.Current;
            AppliedAccent=data.accent==OfflineAccent.Blue?new Color(.35f,.75f,1):data.accent==OfflineAccent.Amber?new Color(1,.75f,.3f):new Color(.70f,.98f,.35f);
            background.color=new Color(.025f,.065f,.08f,data.panelOpacity);
            heading.color=AppliedAccent; launcherImage.color=AppliedAccent;
            banner.text="Hồ sơ: "+data.profileName; banner.color=AppliedAccent; banner.gameObject.SetActive(data.showBanner);
        }
        private void Filter(string query)
        {
            var n=0;
            for(var i=0;i<rows.Count;i++) {
                var visible=OfflineConfigRegistry.Matches(OfflineConfigRegistry.Fields[i],query);
                rows[i].SetActive(visible);
                if(visible) ((RectTransform)rows[i].transform).anchoredPosition=new Vector2(0,-n++*66-33);
            }
            content.sizeDelta=new Vector2(1050,Mathf.Max(440,n*66)); content.anchoredPosition=Vector2.zero;
        }
        private RectTransform Rect(Transform parent,string name,Vector2 position,Vector2 size)
        { var r=new GameObject(name,typeof(RectTransform)).GetComponent<RectTransform>(); r.SetParent(parent,false); r.anchorMin=r.anchorMax=r.pivot=new Vector2(.5f,.5f); r.sizeDelta=size;r.anchoredPosition=position;return r; }
        private Text Label(Transform parent,string name,string value,Vector2 position,Vector2 size,int fontSize)
        { var t=Rect(parent,name,position,size).gameObject.AddComponent<Text>(); t.font=font;t.fontSize=fontSize;t.color=Color.white;t.text=value;t.supportRichText=false;t.alignment=TextAnchor.MiddleLeft;t.raycastTarget=false;return t; }
        private Button Button(Transform parent,string name,string value,Vector2 position,Vector2 size,UnityEngine.Events.UnityAction action)
        { var r=Rect(parent,name,position,size); var image=r.gameObject.AddComponent<Image>();image.color=new Color(.21f,.34f,.39f); var b=r.gameObject.AddComponent<Button>();b.targetGraphic=image;b.onClick.AddListener(action);var t=Label(r,name+" text",value,Vector2.zero,size-new Vector2(20,0),24);t.alignment=TextAnchor.MiddleCenter;t.color=Color.white;return b; }
        private InputField Input(Transform parent,string name,string placeholder,Vector2 position,Vector2 size)
        { var r=Rect(parent,name,position,size);r.gameObject.AddComponent<Image>().color=new Color(.14f,.21f,.26f);var input=r.gameObject.AddComponent<InputField>();input.targetGraphic=r.GetComponent<Image>();input.textComponent=Label(r,name+" text","",Vector2.zero,size-new Vector2(24,4),23);var hint=Label(r,name+" placeholder",placeholder,Vector2.zero,size-new Vector2(24,4),23);hint.color=new Color(.65f,.72f,.77f);input.placeholder=hint;return input; }
    }
}
