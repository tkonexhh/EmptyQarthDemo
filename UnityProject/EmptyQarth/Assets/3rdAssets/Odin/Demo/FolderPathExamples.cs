using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;


namespace GameWish.Game
{
    public class FolderPathExamples : MonoBehaviour
    {
        // By default, FolderPath provides a path relative to the Unity project.
        [FolderPath]
        public string UnityProjectPath;

        // It is possible to provide custom parent patn. ParentFolder paths can be relative to the Unity project, or absolute.
        [FolderPath(ParentFolder = "Assets/Plugins/Sirenix")]
        public string RelativeToParentPath;

        // Using ParentFolder, FolderPath can also provide a path relative to a resources folder.
        [FolderPath(ParentFolder = "Assets/Resources")]
        public string ResourcePath;

        // By setting AbsolutePath to true, the FolderPath will provide an absolute path instead.
        [FolderPath(AbsolutePath = true)]
        public string AbsolutePath;

        // FolderPath can also be configured to show an error, if the provided path is invalid.
        [FolderPath(RequireValidPath = true)]
        public string ValidPath;

        // By default, FolderPath will enforce the use of forward slashes. It can also be configured to use backslashes instead.
        [FolderPath(UseBackslashes = true)]
        public string Backslashes;

        // FolderPath also supports member references with the $ symbol.
        [FolderPath(ParentFolder = "$DynamicParent")]
        public string DynamicFolderPath;

        public string DynamicParent = "Assets/Plugins/Sirenix";
    }

}