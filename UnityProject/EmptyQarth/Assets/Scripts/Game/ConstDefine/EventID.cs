using UnityEngine;
using System.Collections;
using Qarth;

namespace GameWish.Game
{
    public enum EventID
    {
        OnLanguageTableSwitchFinish,

        OnAddCoinNum,
        OnAddDiamondNum,

        //OnChangeMap,

        OnUpdateLoadProgress,

        OnShowPopAdUI,
        OnStartAdEffect,
        OnEndAdEffect,

        //cubemode
        OnAddScore,
        OnSpawnScoreItem,
        OnShowCheerSpine,
        OnAddCubeModeScore,
        OnShowToolTips,
        OnHammerToolCountChange,
        OnChangeToolCountChange,
        OnAddLevel,

        OnClassicModeGameRestart,
        OnClassicModeLevelFinish,
        OnClassicModeNextLevel,
        OnClassicModeRefreshPropCount,

        OnDayRefresh,
        OnChangePropItemTapped,
        OnBonusItemClicked,
        OnAddRedPackPower,
        //OnEnemyCampOccupied,
        //OnBattfieldMove,
        //OnPeriodPassed,
        //OnLevelPassed,
        ///// <summary>
        ///// 当敌方阵营血量减少时调用
        ///// </summary>
        //OnEnemyCampHPReduce,
        //OnSoldierUnlock,
        //OnSoldierUpgradeRefresh,
        //OnFoodRefresh,
        //OnOccupyProgressRefresh,
        OnTimeRefresh,


        OnStartClassicModeClearGuide,
        OnStartClassicModeGameRedpackGuide,
        OnStartClassicModePowerRedpackGuide,
    }

}
