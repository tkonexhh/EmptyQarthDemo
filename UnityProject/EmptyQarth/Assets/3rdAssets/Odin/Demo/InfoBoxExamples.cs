using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace GFrame.Odin.Demo
{
    public class InfoBoxExamples : MonoBehaviour
    {
        [InfoBox("This is an int property")]
        public int MyInt;

        [InfoBox("This info box is a warning", InfoMessageType.Warning)]
        public float MyFloat;

        [InfoBox("This info box is an error", InfoMessageType.Error)]
        public object MyObject;

        [InfoBox("This info box is just a box", InfoMessageType.None)]
        public Vector3 MyVector;
    }

}