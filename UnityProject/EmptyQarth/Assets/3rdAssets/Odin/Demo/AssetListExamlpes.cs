using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;


namespace GFrame.Odin.Demo
{
    /// <summary>
    /// 
    /// </summary>
    public class AssetListExamlpes : MonoBehaviour
    {
        [AssetList]
        public List<GameObject> AssetList;

        [AssetList(Path = "3rdAssets/Odin/Demo")]
        public List<Object> ObjectsWithPath;

        [AssetList(Tags = "Player, MyTabB", Path = "3rdAssets/Odin/Demo/Test")]
        public List<GameObject> GameObjectsWithTag;

        [AssetList]
        public List<ScriptableObject> AllScriptableObjects;

        [InfoBox("Use a method as a custom filter for the asset list.")]
        [AssetList(CustomFilterMethod = "HasRigidbodyComponent")]
        public List<GameObject> MyRigidbodyPrefabs;

        private bool HasRigidbodyComponent(GameObject obj)
        {
            return obj.GetComponent<Rigidbody>() != null;
        }
    }


}