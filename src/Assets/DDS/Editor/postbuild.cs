using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

public class postbuild : MonoBehaviour
{
    [PostProcessBuild(1)]
    public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject)
    {
        FileUtil.CopyFileOrDirectory("Assets/DDS/ManagedPlugins/dcpssacs.netmodule", pathToBuiltProject.Replace(".exe", "") + "_Data/Managed/dcpssacs.netmodule");
        Debug.Log("Copied dcpssacs.netmodule to build-directory");
    }

}
