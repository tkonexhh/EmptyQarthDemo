﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Qarth;
using DG.Tweening;

namespace GameWish.Game
{
    [TMonoSingletonAttribute("[App]/ApplicationMgr")]
    public class ApplicationMgr : AbstractApplicationMgr<ApplicationMgr>
    {

        protected override void InitThirdLibConfig()
        {
            Application.targetFrameRate = 60;
            DOTween.Init(false, true, LogBehaviour.ErrorsOnly);
            //DOTween.defaultEaseType = Ease.Linear;
            //SDKMgr.S.Init();            
        }

        protected override void InitAppEnvironment()
        {
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }

        protected override void StartGame()
        {
            GameMgr.S.InitGameMgr();
        }

    }
}
