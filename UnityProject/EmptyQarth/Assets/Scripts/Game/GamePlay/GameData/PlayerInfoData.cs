using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Qarth;


namespace GameWish.Game
{

    public class PlayerInfoData : IDataClass
    {
        public string strGas = "5000";


        public PlayerInfoData()
        {
            SetDirtyRecorder(PlayerInfoMgr.dataDirtyRecorder);
        }


        public override void InitWithEmptyData()
        {
        }

        public override void OnDataLoadFinish()
        {

        }


    }
}
