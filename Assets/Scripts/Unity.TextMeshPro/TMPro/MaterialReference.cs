namespace TMPro
{
	public struct MaterialReference
	{
		public int index;

		public global::TMPro.TMP_FontAsset fontAsset;

		public global::TMPro.TMP_SpriteAsset spriteAsset;

		public global::UnityEngine.Material material;

		public bool isDefaultMaterial;

		public bool isFallbackMaterial;

		public global::UnityEngine.Material fallbackMaterial;

		public float padding;

		public int referenceCount;

		public MaterialReference(int index, global::TMPro.TMP_FontAsset fontAsset, global::TMPro.TMP_SpriteAsset spriteAsset, global::UnityEngine.Material material, float padding)
		{
			this.index = 0;
			this.fontAsset = null;
			this.spriteAsset = null;
			this.material = null;
			isDefaultMaterial = false;
			isFallbackMaterial = false;
			fallbackMaterial = null;
			this.padding = 0f;
			referenceCount = 0;
		}

		public static bool Contains(global::TMPro.MaterialReference[] materialReferences, global::TMPro.TMP_FontAsset fontAsset)
		{
			return false;
		}

		public static int AddMaterialReference(global::UnityEngine.Material material, global::TMPro.TMP_FontAsset fontAsset, ref global::TMPro.MaterialReference[] materialReferences, global::System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup)
		{
			return 0;
		}

		public static int AddMaterialReference(global::UnityEngine.Material material, global::TMPro.TMP_SpriteAsset spriteAsset, ref global::TMPro.MaterialReference[] materialReferences, global::System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup)
		{
			return 0;
		}
	}
}
