public interface IPlayerRender
{
	void ApplyMainTexture(global::UnityEngine.Texture texture);

	void SetHeight(int height);

	void ChangeHair(string name, global::UnityEngine.Color? color, global::UnityEngine.Color? color2, global::UnityEngine.Color? colorSpec, bool hairAtlas, bool useHDHair, bool useBlinnPhongInGame);

	void ApplyHDTexture(global::System.Collections.Generic.List<global::UnityEngine.Texture> lod, global::System.Collections.Generic.List<global::UnityEngine.Texture> head);

	void ApplyHead(global::System.Collections.Generic.List<global::UnityEngine.Texture> head);

	void SetClothColor(global::UnityEngine.Color color);

	void SetBlendShapeWeight(sbyte[] datas, sbyte[] somatotype);

	void ChangeJerseyStyle(int style);

	void SetFaceDecoration(string decoration);

	void ReleaseCurrentMainTexture();

	void ReleaseCurrentHDTexture();

	void ReleaseCurrentHeadTexture();
}
