public class ActionShadowMaterialsSupplier : ShadowMaterialsSupplier
{
    private static global::UnityEngine.Material[] shareMaterials;
    private static global::UnityEngine.Material[] shareMaterials_night;
    public override global::UnityEngine.Material[] ShareMaterials => null;
    public static global::UnityEngine.Material[] ShareMaterialsStatic => null;

    public static void ChangeLight(global::UnityEngine.Quaternion lightDir)
    {
    }
}