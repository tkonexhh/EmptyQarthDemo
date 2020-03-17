using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;


namespace GFrame.Odin.Demo
{
    public class EnumPagingExamples : MonoBehaviour
    {
        [EnumPaging]
        public MyEnum value;

        public enum MyEnum
        {
            One,
            Two,
            Three
        }
    }

}