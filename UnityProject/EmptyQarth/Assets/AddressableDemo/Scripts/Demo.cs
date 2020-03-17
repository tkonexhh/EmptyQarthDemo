using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Qarth;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GameWish.Game
{
    public class Demo : MonoBehaviour
    {
        public AssetReference asset;
        AsyncOperationHandle handle1;
        AddressableRes handle2;

        // private List<GameObject> lst = new List<GameObject>();
        private List<AsyncOperationHandle> handles = new List<AsyncOperationHandle>();
        // Start is called before the first frame update
        void Start()
        {
            //handle1 = asset.LoadAssetAsync<GameObject>();
            handle2 = AddressableResMgr.S.LoadAssetAsync<GameObject>("Cube");

            //Debug.LogError(asset.Asset.name);
            //asset.LoadAssetAsync<GameObject>().Completed += OnAssetLoaded;
            //AddressableResMgr.S.LoadAssetAsync<GameObject>(asset, OnAssetLoaded);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                for (int i = 0; i < 50; i++)
                    SpawnCube();
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                //AddressableResMgr.S.ReleaseAsset(handle1);
                Debug.LogError(handle2);
                AddressableResMgr.S.ReleaseRes(handle2);

            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                AddressableResMgr.S.ReleaseAllAsset();
            }
        }

        void SpawnCube()
        {
            handle2.InstantiateAsync().AddCompleteCallback(OnAssetLoaded);
        }


        private void OnAssetLoaded(AsyncOperationHandle<GameObject> handle)
        {
            GameObject gameObject = handle.Result;
            Vector3 pos = Random.insideUnitSphere * 10;
            gameObject.SetPos(pos);
            //lst.Add(gameObject);

            handles.Add(handle);
        }
    }

}