using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using System.IO;

public class CreateStartupFile : MonoBehaviour
{

    [PostProcessBuild(2)]
    public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject)
    {
        string OsplHomeDirectory = "";
        string OsplConfigFile = "";
        int cnt = 0;
        if (EditorPrefs.HasKey("OsplHomeDirectory"))
        {
            OsplHomeDirectory = EditorPrefs.GetString("OsplHomeDirectory");
            if (OsplHomeDirectory != "")
                cnt += 1;
        }
        if (EditorPrefs.HasKey("OsplConfigFile"))
        {
            OsplConfigFile = EditorPrefs.GetString("OsplConfigFile");
            if (OsplConfigFile != "")
                cnt += 1;
        }
        if (cnt < 2)
        {
            Debug.LogWarning("No batch-file is created to start the app with DDS enabled because not enough information is provided (DDS/Vortex)");
        }
        else
        {
            string filecontents = "@echo off\necho Setting paths for Vortex OpenSplice ..\nif \"%SPLICE_ORB%\"==\"\" set SPLICE_ORB=DDS_OpenFusion_1_6_1\nset OSPL_HOME=";
            filecontents += OsplHomeDirectory;
            filecontents += "\nset PATH=%OSPL_HOME%\\bin;%OSPL_HOME%\\lib;%OSPL_HOME%\\examples\\lib;%PATH%\n";
            filecontents += "set OSPL_TMPL_PATH=%OSPL_HOME%\\etc\\idlpp\n";
            filecontents += "if \"%OSPL_URI%\"==\"\" set OSPL_URI=file://" + OsplConfigFile + "\necho Starting the application ..\n";
            filecontents += "\"" + pathToBuiltProject + "\"\n";
            Debug.Log(filecontents);
            Debug.Log("PATH:" + Path.GetDirectoryName(pathToBuiltProject) + "\\start_with_DDS.bat");
            File.WriteAllText(Path.GetDirectoryName(pathToBuiltProject) + "\\start_with_DDS.bat", filecontents);
            Debug.Log("Created batch-file to start the app with DDS enabled.");
        }
    }

}
