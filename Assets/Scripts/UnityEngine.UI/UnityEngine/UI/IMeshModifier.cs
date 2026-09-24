namespace UnityEngine.UI
{
	public interface IMeshModifier
	{
		[global::System.Obsolete]
		void ModifyMesh(global::UnityEngine.Mesh mesh);

		void ModifyMesh(global::UnityEngine.UI.VertexHelper verts);
	}
}
