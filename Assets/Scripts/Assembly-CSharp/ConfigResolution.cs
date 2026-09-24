public class ConfigResolution
{
    public int _height;
    private int _width;
    private int scale;
    private string scale_key;
    private global::System.Collections.Generic.List<int> optionList;
    private int max_scale => 0;
    private int min_scale => 0;

    public void InitResolution()
    {
    }

    private global::UnityEngine.Vector2Int ApplyResolution()
    {
        return default;
    }

    private global::UnityEngine.Vector2Int ClampToMultipleOfFour(float scale)
    {
        return default;
    }

    public void Init()
    {
    }

    public void SetScaleIdx(int idx)
    {
    }

    public int GetCurrentIdx()
    {
        return 0;
    }

    public int GetOptionCount()
    {
        return 0;
    }

    public string GetOptionString(int idx)
    {
        return null;
    }

    private void ApplyScale()
    {
    }
}