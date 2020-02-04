using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Qarth;

namespace GameWish.Game
{
    public class CommonResModule : AbstractModule
    {
        protected override void OnComAwake()
        {

            HolderCommondAudio();


            ResHolder.S.loader.LoadSync();

        }

        private void HolderCommondAudio()
        {
            //ResHolder.S.AddRes(TDConstTable.QueryString(ConstType.MUSIC_BG));
            // SoundButton.defaultClickSound = Define.SOUND_DEFAULT_UI_BTN;

            // ResHolder.S.AddRes(Define.SOUND_DEFAULT_SOUND);
            // ResHolder.S.AddRes(Define.SOUND_LOGO_BGM);
            // ResHolder.S.AddRes(Define.SOUND_CLASSIC_MODE_BGM);


        }

    }
}
