public class AvataTest1 : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform Camera;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform player;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown Up;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown down;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown sock;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown shoe;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl up1;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl up2;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl down1;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl down2;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl sock1;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl sock2;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl coatNumberMainColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl coatNumberOutlineColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField upResult;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField downResult;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField sockResult;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField coatNumberColorResult;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField shortsNumberColorResult;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField shoeResult;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField faceResult;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown faceInput;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown headMeshInput;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField headMeshInputResult;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField skinResult;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown skinInput;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField eyeResult;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown eyeInput;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField eyebrowResult;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown eyebrowInput;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField hairResult;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown hairInput;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown hairColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField BeardResult;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown BeardInput;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField headDataResult;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown genderResult;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Slider[] headDatas;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Slider[] headDatasFemale;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Slider strong;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown height;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Slider thin;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField strongText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown JerseyStyle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField JerseyStyleText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown FaceDecorate;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField FaceDecorateText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown armSleeve;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField armSleeveText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Dropdown wristband;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField wristbandText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image frontCover;
    private ActionPlayerTextureSupplier supplier;
    private global::UnityEngine.Vector3 pos;
    private global::UnityEngine.Rect selectExcelsFolderButtonRect;
    private global::UnityEngine.Rect startButtonRect;
    private bool FoceHead;
    private int initState;
    private global::System.Collections.Generic.List<string> faces;
    private global::System.Collections.Generic.List<string> Memalefaces;
    private global::System.Collections.Generic.HashSet<string> externalFace;
    private global::System.Collections.Generic.List<string> HeadMeshs;
    private global::System.Collections.Generic.List<string> skins;
    private global::System.Collections.Generic.List<string> eyes;
    private global::System.Collections.Generic.List<string> eyebrows;
    private global::System.Collections.Generic.List<string> hairs;
    private global::System.Collections.Generic.List<string> FemaleHair;
    private global::System.Collections.Generic.List<int> hairColors;
    private global::System.Collections.Generic.List<string> Beards;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject man;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject female;
    private void Start()
    {
    }

    public void init()
    {
    }

    private void ChangeHairOption(bool female)
    {
    }

    private void rotatePlayer()
    {
    }

    private void OnGUI()
    {
    }

    private void Update()
    {
    }

    private string colorStr(global::UnityEngine.Color c)
    {
        return null;
    }

    private global::UnityEngine.Color GetPickerColor(global::UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl picker, global::UnityEngine.Color defaultColor)
    {
        return default;
    }

    private void InitNumberColorControls()
    {
    }

    private void AddNumberColorListener(global::UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl picker)
    {
    }

    private void ApplyNumberColorControls()
    {
    }

    private void SetNumberColors(global::UnityEngine.Color mainColor, global::UnityEngine.Color outlineColor)
    {
    }

    private void SetCoat(int id, global::UnityEngine.Color main, global::UnityEngine.Color AuxilColor)
    {
    }

    private void SetShorts(int id, global::UnityEngine.Color main, global::UnityEngine.Color AuxilColor)
    {
    }

    private void SetSock(int id, global::UnityEngine.Color main, global::UnityEngine.Color AuxilColor)
    {
    }

    private void SetShoe(int id)
    {
    }

    private void InitHeadData()
    {
    }

    public void ResetFace()
    {
    }

    private void ChangeHead(float v)
    {
    }

    public void ChangeHeadFromText()
    {
    }

    private void InitExternalFace()
    {
    }

    private void ChangeFace(string face)
    {
    }

    private void InitHeadMeshOption()
    {
    }

    private void ChangeHeadMesh(string mesh)
    {
    }

    private void ChangeSkin(string skin)
    {
    }

    private void ChangeEye(string eye)
    {
    }

    private void ChangeEyebrow(string eyebrow)
    {
    }

    private void InitHair()
    {
    }

    private void OnHairColorSetect(int v)
    {
    }

    private void ChangeHair(string hair)
    {
    }

    private void ChangeBeard(string beard)
    {
    }

    private void ApplySinglePlayer()
    {
    }

    public void OpenFaceOption()
    {
    }

    public void CloseFaceOption()
    {
    }
}