using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace MetaverseSandbox.Core {
    [Serializable]
    public class SceneReference : AssetReferenceT<SceneAsset>
    {
        public SceneReference(string guid) : base(guid)
        {
        }
    }

    [CreateAssetMenu(fileName = "Environment", menuName = "ScriptableObjects/EnvironmentScriptableObject", order = 1)]
    public class Environment : ScriptableObject
    {
        public SceneReference environmentAddressableScene;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}