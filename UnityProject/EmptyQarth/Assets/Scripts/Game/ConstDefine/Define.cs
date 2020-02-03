using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Qarth;

namespace GameWish.Game
{
    public class Define
    {
        public const int DEFAULT_COIN_NUM = 0;
        public const int DEFAULT_DIAMOND_NUM = 0;

        //public const string SOUND_BUTTON_CLICK = "Sound_ButtonClick";
        //public const string SOUND_BLOCK_UPGRADE = "Sound_LevelUp"; 
        //public const string SOUND_PANEL_CLOSE = "Sound_Close";    
        //public const string SOUND_POSITIVE_EFFECT = "Sound_Positive"; 
        //public const string SOUND_EVOLVE = "Sound_Evolve";

        public const string NAME_SPACE_PREFIX = "GameWish.Game.";
        //offline
        public const int OFFLINE_MAX_TIME = 120;
        public const int OFFLINE_MIN_TIME = 120;
        public const int OFFLINE_RATE_MIN = 2;
        public const int OFFLINE_RATE_MAX = 6;

        //offline earning
        public const int OFFLINE_MONEY_RATE = 1;
        public const int OFFLINE_EXP_RATE = 30;
        public const int OFFLINE_DIAMOND_COST = 100;

        //rate record
        public const string RATE_RECORD = "rate";

        //Addressable asset
        public const string BATTLE_FIELD_PREFAB = "BattleField";

        public const string PROGRESS_BAR = "ProgressBar";

        public const int CLASSIC_MODE_MAX_LEVEL = 100;

        //AD
        public const string AD_PLACEMENT_REWARD = "MainReward";
        public const string AD_PLACEMENT_INTER = "MainInter";
        //Effect
        public const string CLEAR_BLUE_EFFECT = "blue-1";
        public const string CLEAR_GREEN_EFFECT = "green-1";
        public const string CLEAR_PURPLE_EFFECT = "purple-1";
        public const string CLEAR_RED_EFFECT = "red-1";
        public const string CLEAR_YELLOW_EFFECT = "yellow-1";
        public const string CLEAR_PROP_EFFECT = "prop_effect";
        public const string CLEAR_SCORE_EFFECT = "score_effect";
        //cube effect
        public const string CUBE_YELLOW_EFFECT = "cube_Yellow";
        public const string CUBE_RED_EFFECT = "cube_Red";
        public const string CUBE_GREEN_EFFECT = "cube_Green";
        public const string CUBE_BLUE_EFFECT = "cube_Blue";
        public const string CUBE_CYAN_EFFECT = "cube_Cyan";
        public const string CUBE_PURPLE_EFFECT = "cube_Purple";

        //credit mission
        public const string GET_CLEAR_BONUS = "day{0}_single";
        public const string FIRST_BONUS = "first_bonus";
        public const float FIRST_BONUS_VALUE = 8.8f;
 
        ////Task
        public const int MAIN_TASK_MAX_COUNT = 50;

        //ADname
        public const string AD_MAIN_INTER = "MainInter";
        public const string AD_BONUS_REWARD = "MainReward";
        public const float AD_MAX_TIME = 10800;

        ////Sound
        public const string SOUND_DEFAULT_UI_BTN = "default_UIBtn";
        public const string SOUND_DEFAULT_SOUND = "default_Btn";
        public const string SOUND_LOGO_BGM = "logo_bgm";
        public const string SOUND_CLASSIC_MODE_BGM = "classic_mode_bgm";
        public const string SOUND_CLEAR_NORMAL = "clear_normal";
        public const string SOUND_CLEAR_5 = "clear_5";
        public const string SOUND_CLEAR_6 = "clear_6";
        public const string SOUND_CLEAR_7 = "clear_7";
        public const string SOUND_CLEAR_CUBE = "clear_cube";
        public const string SOUND_LEVEL_COMPLETE = "level_complete";
        public const string SOUND_LOGO_BTN = "logo_btn";
        public const string SOUND_PUT_CUBE = "put_cube";

        //Data Analysis
        public const string CLASSIC_MODE = "PopStar";
        public const string CUBE_MODE = "PutMatch";
        public const string Turkey_MODE = "TurkeyMatch";
        public const string LIFE_TIME_AD_COUNT = "LifeTimeAdCount";
        public const string PLAY_GAME = "PlayGame";
        public const string REBORN = "Reborn";
        public const string FAIL = "Fail";
        public const string USE_ITEM = "UseItem";
        public const string PASS_STAR_LEVEL = "PassStarLevel";
        public const string PUT_SCORE = "PutScore";
        public const string TURKEY_SCORE = "TurkeyScore";
        public const string GET_RED_PACK = "GetRedPack";
        public const string OPEN_RED_PACK = "OpenRedPack";
        public const string ENTER_POP_STAR = "EnterPopStar";
        public const string RANDOM_RED_PACK_GET = "GameRedpackGet";
        public const string RANDOM_RED_PACK_OPEN = "GameRedpackOpen";
        public const string GAME_REDPACK_DOUBLE = "GameRedpackDouble";
        public const string ENERGY_REDPACK_FULL = "EnergyRedpackFull";
        public const string ENERGY_REDPACK_OPEN = "EnergyRedpackOpen";
    }
}
