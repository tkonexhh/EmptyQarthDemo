using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace GFrame.Odin.Demo
{
    public class InlineEditorExamples : MonoBehaviour
    {


        // [Title("Boxed / Default")]
        // [InlineEditor(InlineEditorObjectFieldModes.Boxed)]
        // public ExampleTransform Boxed = ExampleHelper.GetScriptableObject<ExampleTransform>();
    }

    public class ExampleTransform : ScriptableObject
    {
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Scale = Vector3.one;
    }
}