using UnityEngine;
using System.Collections;
using Qarth;

namespace GameWish.Game
{
    public class UIDataModule : AbstractModule
    {
        public static void RegisterStaticPanel()
        {
            InitUIPath();
            UIDataTable.SetABMode(false);

            UIDataTable.AddPanelData(UIID.LogoPanel, null, "LogoPanel/LogoPanel");
        }

        protected override void OnComAwake()
        {
            InitUIPath();
            RegisterAllPanel();
        }

        private static void InitUIPath()
        {
            PanelData.PREFIX_PATH = "Resources/UI/Panels/{0}";
            PageData.PREFIX_PATH = "Resources/UI/Panels/{0}";
        }

        private void RegisterAllPanel()
        {
            UIDataTable.SetABMode(true);

            UIDataTable.AddPanelData(EngineUI.FloatMessagePanel, null, "Common/FloatMessagePanel", true, 1);
            //UIDataTable.AddPanelData(UIID.FloatMessagePanel1, null, "Common/FloatMessagePanel1", true, 1);
            UIDataTable.AddPanelData(EngineUI.MsgBoxPanel, null, "Common/MsgBoxPanel", true, 1);
            UIDataTable.AddPanelData(EngineUI.HighlightMaskPanel, null, "Guide/HighlightMaskPanel", true, 0);
            //UIDataTable.AddPanelData(EngineUI.GuideHandPanel, null, "Guide/GuideHandPanel", true, 0);
            UIDataTable.AddPanelData(EngineUI.MaskPanel, null, "Common/MaskPanel", true, 1);
            UIDataTable.AddPanelData(EngineUI.ColorFadeTransition, null, "Common/ColorFadeTransition", true, 1);

            UIDataTable.AddPanelData(EngineUI.RatePanel, null, "Common/RatePanel");


            //effect panel
            UIDataTable.AddPanelData(UIID.UIParticalPanel, null, "Common/UIParticalPanel");

            //在开发阶段使用该模式方便调试
            UIDataTable.SetABMode(false);

            //guide
            UIDataTable.AddPanelData(UIID.GuideWordsPanel, null, "GuidePanel/GuideWordsPanel");
            UIDataTable.AddPanelData(UIID.GuideUIClipPanel, null, "GuidePanel/GuideUIClipPanel");
            UIDataTable.AddPanelData(EngineUI.GuideHandPanel, null, "GuidePanel/GuideHandPanel");


            //UIDataTable.AddPanelData(UIID.OfflinePanel, null, "GamePanels/OfflineRewardPanel");
            //UIDataTable.AddPanelData(UIID.ShopPanel, null, "GamePanels/ShopPanel", true, 1);
            UIDataTable.AddPanelData(UIID.SettingPanel, null, "GamePanels/SettingPanel/SettingPanel", true);
            UIDataTable.AddPanelData(UIID.MainGamePanel, null, "GamePanels/MainGamePanel/MainGamePanel", true, 1);
            //UIDataTable.AddPanelData(UIID.TopPanel, null, "GamePanels/TopPanel/TopPanel", true, 1);
            //UIDataTable.AddPanelData(UIID.OccupyOverPanel, null, "GamePanels/OccupyOverPanel/OccupyOverPanel", true, 1);
            //UIDataTable.AddPanelData(UIID.AdDynamicShowPanel, null, "GamePanels/AdDynamicShowPanel/AdDynamicShowPanel", true, 1);
            //UIDataTable.AddPanelData(UIID.AdStaticShowPanel, null, "GamePanels/AdStaticShowPanel/AdStaticShowPanel", true, 1);
            //UIDataTable.AddPanelData(UIID.UnlockSoldierPanel, null, "GamePanels/UnlockTipPanel/UnlockSoldierPanel", true, 1);
            //UIDataTable.AddPanelData(UIID.UnlockEnemyPanel, null, "GamePanels/UnlockTipPanel/UnlockEnemyPanel", true, 1);
            //UIDataTable.AddPanelData(UIID.UnlockWeaponPanel, null, "GamePanels/UnlockTipPanel/UnlockWeaponPanel", true, 1);
            //UIDataTable.AddPanelData(UIID.OfflinePanel, null, "GamePanels/OfflinePanel/OfflinePanel", true, 1);
            //UIDataTable.AddPanelData(UIID.SettingPanel, null, "GamePanels/SettingPanel/SettingPanel");
            //UIDataTable.AddPanelData(UIID.MissionCompletePanel, null, "GamePanels/MissionCompletePanel/MissionCompletePanel");
            //UIDataTable.AddPanelData(UIID.MilestonePanel, null, "GamePanels/MilestonePanel/MilestonePanel");
            UIDataTable.AddPanelData(UIID.ClassicModeGamePanel, null, "GamePanels/ClassicModePanel/GamePanel/ClassicModeGamePanel");
            UIDataTable.AddPanelData(UIID.ClassicModeLevelCompletePanel, null, "GamePanels/ClassicModePanel/ClassicModeLevelCompletePanel/ClassicModeLevelCompletePanel");
            UIDataTable.AddPanelData(UIID.ClassicModePausePanel, null, "GamePanels/PausePanel/ClassicModePausePanel");
            UIDataTable.AddPanelData(UIID.CubeModeGamePanel, null, "GamePanels/CubeModePanel/CubeModeGamePanel");
            UIDataTable.AddPanelData(UIID.CubeModeRevivePanel, null, "GamePanels/CubeModePanel/CubeModeRevivePanel");
            UIDataTable.AddPanelData(UIID.CubeModeGameOverPanel, null, "GamePanels/CubeModePanel/CubeModeGameOverPanel");
            UIDataTable.AddPanelData(UIID.CubeModeGameFinishPanel, null, "GamePanels/CubeModePanel/CubeModeGameFinishPanel");
            UIDataTable.AddPanelData(UIID.CubeModeToolPanel, null, "GamePanels/CubeModePanel/CubeModeToolPanel");
            UIDataTable.AddPanelData(UIID.CubeModeBombPanel, null, "GamePanels/CubeModePanel/CubeModeBombPanel");
            UIDataTable.AddPanelData(UIID.CubeModePausePanel, null, "GamePanels/CubeModePanel/CubeModePausePanel");
            UIDataTable.AddPanelData(UIID.ClassicModeContinuePanel, null, "GamePanels/ContinuePanel/ClassicModeContinuePanel");
            UIDataTable.AddPanelData(UIID.CubeModeContinuePanel, null, "GamePanels/ContinuePanel/CubeModeContinuePanel");
            UIDataTable.AddPanelData(UIID.ClaimPanel, null, "GamePanels/ClaimPanel/ClaimPanel");
            UIDataTable.AddPanelData(UIID.GetBonusPanel, null, "GamePanels/GetBonusPanel/GetBonusPanel");
            UIDataTable.AddPanelData(UIID.ClassicModeLevelFailedPanel, null, "GamePanels/ClassicModePanel/ClassicModeLevelFailedPanel/ClassicModeLevelFailedPanel");
            UIDataTable.AddPanelData(UIID.GetRedPackPanel, null, "GamePanels/GetRedPackPanel/GetRedPackPanel");
            UIDataTable.AddPanelData(UIID.ClassicModeGetPropPanel, null, "GamePanels/ClassicModePanel/ClassicModeGetPropPanel/ClassicModeGetPropPanel");

        }
    }
}
