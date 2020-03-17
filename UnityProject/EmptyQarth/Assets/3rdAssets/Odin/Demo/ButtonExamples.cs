using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;


namespace GFrame.Odin.Demo
{
    public class ButtonExamples : MonoBehaviour
    {
        [Button]
        private void Click()
        {
            Debug.LogError("ButtonExamples");
        }

        // [Button(ButtonSizes.Small, ButtonStyle.CompactBox)]
        // private void Function()
        // {
        //     Debug.LogError("Function");
        // }
    }

}