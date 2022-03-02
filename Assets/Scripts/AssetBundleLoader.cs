using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class AssetBundleLoader : MonoBehaviour
{
    public string assetBundleName = "MaliciousBundle_calcexe";

    private void Start()
    {
        AssetBundle bundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, assetBundleName));
        if (bundle == null) return;

        GameObject prefab = bundle.LoadAsset<GameObject>("ObjectWithUnityEvent");
        Instantiate(prefab);

        bundle.Unload(false);
    }
}
