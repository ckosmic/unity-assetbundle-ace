# ACE in Unity AssetBundles
Based on https://blog.includesecurity.com/2021/06/hacking-unity-games-malicious-unity-game-objects/

---
\
The project includes a few modified prefabs in the `Prefabs` folder that, when bundled, can be loaded in a Unity game and run a static method specified in the original .prefab file. \
These prefabs have already been bundled under `StreamingAssets` and the `BundleLoader` game object in `SampleScene` will load one by name at Start.
- `MaliciousBundle_calcexe`: Opens C:\Windows\System32\calc.exe
- `MaliciousBundle_googlecom`: Opens https://google.com in the default browser
- `MaliciousBundle_CrashGame`: Crashes the game/editor
This exploit has been tested on Unity 2020.2.0f1 and seems to not be present in tested 2019 versions.