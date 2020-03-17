using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;


namespace GameWish.Game
{
    public class ColorPaletteExamples : MonoBehaviour
    {
        [ColorPalette]
        public Color ColorOptions;

        [InfoBox("会选用Odin ColorPalette 配色板")]
        [ColorPalette("Underwater")]
        public Color UnderwaterColor;

        [ColorPalette("Fall"), HideLabel]
        public Color WideColorPalette;

        [InfoBox("会选用Odin ColorPalette 配色板，如果不存在会显示创建")]
        [ColorPalette("My Palette")]
        public Color MyColor;

        [ColorPalette("Clovers")]
        public Color[] ColorArray;
    }

}