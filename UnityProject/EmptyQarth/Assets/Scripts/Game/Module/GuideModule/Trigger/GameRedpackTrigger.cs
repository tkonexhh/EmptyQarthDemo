using System;
using System.Collections;
using System.Collections.Generic;
using Qarth;
using UnityEngine;


namespace GameWish.Game
{
    public class GameRedpackTrigger : ITrigger
    {
        public bool isReady
        {
            get { return true; }
        }

        public void SetParam(object[] param)
        {
            
        }

        public void Start(Action<bool, ITrigger> l)
        {
            
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

}