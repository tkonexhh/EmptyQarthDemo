using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Qarth;
using System;

namespace GameWish.Game
{
	public class EffectMgr : TSingleton<EffectMgr>
	{
        private ResLoader m_ResLoader = null;
	    private Transform m_EffectRoot;

        public void Init()
        {
            
            AddParticalPool(Define.CLEAR_BLUE_EFFECT, 8, 5);
            AddParticalPool(Define.CLEAR_GREEN_EFFECT, 8, 5);
            AddParticalPool(Define.CLEAR_PURPLE_EFFECT, 8, 5);
            AddParticalPool(Define.CLEAR_RED_EFFECT, 8, 5);
            AddParticalPool(Define.CLEAR_YELLOW_EFFECT, 8, 5);
            AddParticalPool(Define.CLEAR_SCORE_EFFECT, 8, 5);
            AddParticalPool(Define.CLEAR_PROP_EFFECT, 8, 5);

            AddParticalPool(Define.CUBE_BLUE_EFFECT,8,8);
            AddParticalPool(Define.CUBE_CYAN_EFFECT,8,8);
            AddParticalPool(Define.CUBE_GREEN_EFFECT,8,8);
            AddParticalPool(Define.CUBE_PURPLE_EFFECT,8,8);
            AddParticalPool(Define.CUBE_RED_EFFECT,8,8);
            AddParticalPool(Define.CUBE_YELLOW_EFFECT,8,8);
        }

	    public override void OnSingletonInit()
	    {
	        base.OnSingletonInit();
	        //m_ResLoader = ResLoader.Allocate("EffectLoader");
	        m_EffectRoot = GameObject.Find("GameplayRoot/EffectRoot").transform;
	    }

	    private void AddParticalPool(string name, int max, int init)
        {
            GameObject prefab = null;
            //prefab = m_ResLoader.LoadSync(name) as GameObject;
            prefab = Resources.Load("Effect/" + name) as GameObject;
            if (prefab)
                GameObjectPoolMgr.S.AddPool(name, prefab, max, init);
        }

	    public void ShowEffect(string name, Vector3 worldPos, float lifeTime, Action callback)
	    {
	        GameObject effect = GameObjectPoolMgr.S.Allocate(name);
	        effect.transform.SetParent(m_EffectRoot);
	        effect.transform.position = worldPos;

	        if (lifeTime < 0) return;
	        UnityExtensions.CallWithDelay(GameplayMgr.S, () =>
	        {
	            //todo :如果挂有脚本记得reset,引用置空
	            if (effect == null)//effect被destroy
	                return;
	            ResetPartical(effect);
	            GameObjectPoolMgr.S.Recycle(effect);
	            if (callback != null)
	            {
	                callback.Invoke();
	            }
	        }, lifeTime);
	    }

        #region show effect in UI

        //根节点在指定的root
        public void ShowUIEffectInPanel(string name, Vector3 worldPos, float lifeTime, Transform root, int sortOrder, Action callback)
        {
            if (root)
                DoShowUIEffect(name, root, sortOrder, worldPos, lifeTime, callback);
            else
            {
                ShowUIEffect(name, worldPos, lifeTime, callback);
            }
        }

        public void ShowUIEffect(string name, Vector3 worldPos, float lifeTime, Action callback)
        {
            UIParticalPanel panel = UIMgr.S.FindPanel(UIID.UIParticalPanel) as UIParticalPanel;

            if (panel == null)
            {
                UIMgr.S.OpenPanel(UIID.UIParticalPanel, (p) =>
                {
                    panel = p as UIParticalPanel;
                    DoShowUIEffect(name, panel.transform, panel.sortIndex+20, worldPos, lifeTime, callback);
                });//panel的回调方法不在这一帧执行,所以不能在回调中对panel赋值然后调用do方法，而是在回调中调用,不然panel会报空

                return;
            }

            DoShowUIEffect(name, panel.transform, panel.sortIndex+20, worldPos, lifeTime, callback);
        }

        private void DoShowUIEffect(string name, Transform root, int sortOrder, Vector3 worldPos, float lifeTime, Action callback)
        {
            GameObject effect = GameObjectPoolMgr.S.Allocate(name);
            effect.transform.SetParent(root);
            //effect.transform.localScale = Vector3.one;

            //set ui layer 
            UnityExtensions.SetAllLayer(effect, LayerDefine.LAYER_UI);
            //set render order
            SetParticalRender(effect, sortOrder);

            effect.transform.position = worldPos;

            if (lifeTime < 0) return;
            UnityExtensions.CallWithDelay(GameplayMgr.S.Mono, () =>
            {
                //todo :如果挂有脚本记得reset,引用置空
                if (effect == null)
                    return;
                ResetPartical(effect);
                GameObjectPoolMgr.S.Recycle(effect);
                if (callback != null)
                {
                    callback.Invoke();
                }
            }, lifeTime);
        }


        private void SetParticalRender(GameObject effect, int order)
        {
            foreach (var r in effect.GetComponentsInChildren<Renderer>())
            {
                r.sortingOrder = order;
            }
        }

        private void ResetPartical(GameObject effect)
        {
            foreach (var r in effect.GetComponentsInChildren<ParticleSystem>())
            {
                r.Stop(true);
            }
        }
        #endregion

    }
}