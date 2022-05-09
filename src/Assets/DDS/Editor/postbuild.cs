﻿/* 
 Copyright 2020 Edward Hage

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

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
