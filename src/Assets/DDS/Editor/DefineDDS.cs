using UnityEngine;
using UnityEditor;

public class DefineDDS : EditorWindow
{
    string OsplHomeDirectory = "D:\\HDE\\x86_64.win64";
    string OsplConfigFile = "D:\\HDE\\x86_64.win64\\etc\\config\\ospl_vm.xml";

    [MenuItem("DDS/Vortex")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        DefineDDS window = (DefineDDS)EditorWindow.GetWindow(typeof(DefineDDS));
        window.Show();
    }

    void OnGUI()
    {
        GUILayout.Label("Vortex DDS Locations", EditorStyles.boldLabel);
        EditorGUILayout.BeginHorizontal();
        OsplHomeDirectory = EditorGUILayout.TextField("OSPL Home Directory", OsplHomeDirectory);
        if (GUILayout.Button("Find", EditorStyles.miniButtonRight, GUILayout.Width(40)))
        {
            string FileOsplHomeDirectory = EditorUtility.OpenFolderPanel("OSPL Home Directory", "C:\\", "HDE");
            if (FileOsplHomeDirectory != "")
            {
                OsplHomeDirectory = FileOsplHomeDirectory;
                EditorPrefs.SetString("OsplHomeDirectory", OsplHomeDirectory);
            }
        }
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.BeginHorizontal();
        OsplConfigFile = EditorGUILayout.TextField("OSPL Config File", OsplConfigFile);
        if (GUILayout.Button("Find", EditorStyles.miniButtonRight, GUILayout.Width(40)))
        {
            string FileOsplConfigFile = EditorUtility.OpenFilePanel("OSDPL Config File", "C:\\", "xml");
            if (FileOsplConfigFile != "")
            {
                OsplConfigFile = FileOsplConfigFile;
                EditorPrefs.SetString("OsplConfigFile", OsplConfigFile);
            }
        }
        EditorGUILayout.EndHorizontal();
    }

    void OnFocus()
    {
        if (EditorPrefs.HasKey("OsplHomeDirectory"))
            OsplHomeDirectory = EditorPrefs.GetString("OsplHomeDirectory");
        if (EditorPrefs.HasKey("OsplConfigFile"))
            OsplConfigFile = EditorPrefs.GetString("OsplConfigFile");
    }

    void OnLostFocus()
    {
        SetEditorPrefs();
    }

    void OnDestroy()
    {
        SetEditorPrefs();
    }

    void SetEditorPrefs()
    {
        EditorPrefs.SetString("OsplHomeDirectory", OsplHomeDirectory);
        EditorPrefs.SetString("OsplConfigFile", OsplConfigFile);
    }
}