using UnityEngine;
using UnityEditor;
using UnityEngine.Rendering;

public class ExportAssetBundle
{
	[MenuItem("Assets/Build AssetBundle From Selection")]
    public static void ExportBundle()
    {
        string path = EditorUtility.SaveFilePanel("Save AssetBundle", "", "MaliciousBundle", "");
        if (path.Length != 0)
        {
            PlayerSettings.SetGraphicsAPIs(BuildTarget.StandaloneWindows, new GraphicsDeviceType[] { GraphicsDeviceType.Direct3D11, GraphicsDeviceType.OpenGLCore, GraphicsDeviceType.Vulkan});

            Object[] selection = Selection.GetFiltered(typeof(Object), SelectionMode.DeepAssets);
            BuildPipeline.BuildAssetBundle(Selection.activeObject, selection, path, BuildAssetBundleOptions.CollectDependencies | BuildAssetBundleOptions.CompleteAssets, BuildTarget.StandaloneWindows);
            Selection.objects = selection;
        }
    }
}