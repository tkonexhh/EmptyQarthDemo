using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;


namespace GFrame.Odin.Demo
{
    public class InlineButtonExamples : MonoBehaviour
    {
        //在一个属性之后添加按钮


        [InlineButton("A")]
        public int InlineButton;

        [InlineButton("A")]
        [InlineButton("B", "Custom Button Name")]
        public int ChainedButtons;

        private void A()
        {
            Debug.Log("A");
        }

        private void B()
        {
            Debug.Log("B");
        }
    }

}