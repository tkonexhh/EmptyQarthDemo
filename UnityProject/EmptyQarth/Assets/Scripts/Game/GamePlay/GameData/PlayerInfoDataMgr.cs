using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Qarth;

namespace GameWish.Game
{

    public class PlayerInfoMgr : DataClassHandler<PlayerInfoData>
    {
        public static DataDirtyRecorder dataDirtyRecorder = new DataDirtyRecorder();

        public PlayerInfoMgr()
        {
            Load();
            EnableAutoSave();
        }


    }
}