using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace GFrame.Odin.Demo
{
    public class FilePathExamples : MonoBehaviour
    {
        // By default, FilePath provides a path relative to the Unity project.
        [FilePath]
        public string UnityProjectPath;

        // It is possible to provide custom parent path. Parent paths can be relative to the Unity project, or absolute.
        [FilePath(ParentFolder = "Assets/Plugins/Sirenix")]
        public string RelativeToParentPath;

        // Using parent path, FilePath can also provide a path relative to a resources folder.
        [FilePath(ParentFolder = "Assets/Resources")]
        public string ResourcePath;

        // Provide a comma seperated list of allowed extensions. Dots are optional.
        [FilePath(Extensions = "cs")]
        public string ScriptFiles;

        // By setting AbsolutePath to true, the FilePath will provide an absolute path instead.
        [FilePath(AbsolutePath = true)]
        [BoxGroup("Conditions")]
        public string AbsolutePath;

        // FilePath can also be configured to show an error, if the provided path is invalid.
        [FilePath(RequireValidPath = true)]
        public string ValidPath;

        // By default, FilePath will enforce the use of forward slashes. It can also be configured to use backslashes instead.
        [FilePath(UseBackslashes = true)]
        public string Backslashes;

        // FilePath also supports member references with the $ symbol.
        [FilePath(ParentFolder = "$DynamicParent", Extensions = "$DynamicExtensions")]
        public string DynamicFilePath;

        public string DynamicParent = "Assets/Plugin/Sirenix";

        public string DynamicExtensions = "cs, unity, jpg";
    }

}