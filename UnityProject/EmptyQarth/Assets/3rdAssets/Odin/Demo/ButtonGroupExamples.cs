using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;


namespace GFrame.Odin.Demo
{
    public class ButtonGroupExamples : MonoBehaviour
    {
        [ButtonGroup("MyGroup")]
        private void A()
        {
            // ..
        }

        [ButtonGroup("MyGroup")]
        private void B()
        {
            // ..
        }

        [ButtonGroup("MyGroup")]
        private void C()
        {
            // ..
        }


        [ButtonGroup("First")]
        private void A1()
        { }

        [ButtonGroup("First")]
        private void B1()
        { }

        [ButtonGroup]
        private void A2()
        { }

        [ButtonGroup]
        private void B2()
        { }

        [ButtonGroup("")]
        private void One()
        { }

        [ButtonGroup("")]
        private void Two()
        { }

        [ButtonGroup("")]
        private void Three()
        { }
    }

}