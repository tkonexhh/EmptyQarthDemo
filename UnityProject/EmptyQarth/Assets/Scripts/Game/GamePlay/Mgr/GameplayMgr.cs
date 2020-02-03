using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Qarth;
using System;
//using BitBenderGames;
using UnityEngine.SceneManagement;
using Int64 = System.Int64;
using Random = UnityEngine.Random;

namespace GameWish.Game
{
    public partial class GameplayMgr : TMonoSingleton<GameplayMgr>
    {
        [SerializeField] private Transform m_EntityRoot;

        public Transform EntityRoot { get => m_EntityRoot; set => m_EntityRoot = value; }
        public MonoBehaviour Mono { get => m_Mono; set => m_Mono = value; }
        public bool ClearInterReady { get => m_ClearInterReady; set => m_ClearInterReady = value; }

        private bool m_IsLoadingBarFinished = false;
        private bool m_IsGameStart = false;

        private bool m_ClearInterReady;
        private float m_ClearInterTimer;

        private MonoBehaviour m_Mono;

        public void InitGameplay()
        {
            m_Mono = GetComponent<MonoBehaviour>();

            UIMgr.S.ClosePanelAsUIID(UIID.LogoPanel);
            StartGamePlay();
        }

        private void StartGamePlay()
        {
            // Init Managers
            //GameDataMgr.S.Init();

            AssetPreloaderMgr.S.Init();
            UIMgr.S.OpenPanel(UIID.MainGamePanel);


            AudioMgr.S.OnSingletonInit();

            EventSystem.S.Register(EngineEventID.OnApplicationQuit, ApplicationQuit);
            EventSystem.S.Register(EngineEventID.OnApplicationPauseChange, OnGamePauseChange);
            EventSystem.S.Register(EngineEventID.OnApplicationFocusChange, OnGameFocusChange);

            //Set language
            //I18Mgr.S.SwitchLanguage(SystemLanguage.German);

            GameMgr.S.StartGuide();


            m_IsLoadingBarFinished = true;
        }


        private void OnGamePauseChange(int key, params object[] args)
        {
            bool pause = (bool)args[0];
            if (!pause)
            {
                TimeUpdateMgr.S.Resume();
            }
            else
            {
                TimeUpdateMgr.S.Pause();
            }
        }

        private void OnGameFocusChange(int key, params object[] args)
        {
            bool focusState = (bool)args[0];
            if (focusState)
            {
                return;
            }

            //GameDataMgr.S.Save();
        }

        private void ApplicationQuit(int key, params object[] args)
        {
            //GameDataMgr.S.GetPlayerInfoData().SetLoginTime();
        }

        private void Update()
        {
            if (m_IsLoadingBarFinished == false)
                return;

            if (m_IsGameStart == false)
            {
                if (AssetPreloaderMgr.S.IsPreloaderDone())
                {
                    m_IsGameStart = true;

                    //UIMgr.S.ClosePanelAsUIID(UIID.LogoPanel);
                    //UIMgr.S.OpenPanel(UIID.MainGamePanel);

                    //MusicMgr.S.PlayBgMusic();
                    //GameWorldMgr.S.Init();
                }
            }


            if (!m_ClearInterReady)
            {
                m_ClearInterTimer += Time.deltaTime;
                if (m_ClearInterTimer >= 90)
                {
                    m_ClearInterReady = true;
                }
            }
            else
            {
                m_ClearInterTimer = 0;
            }
        }

        public void ResetClearInterCD()
        {
            m_ClearInterTimer = 0;
            m_ClearInterReady = false;
        }

        private void FixedUpdate()
        {

        }
    }
}