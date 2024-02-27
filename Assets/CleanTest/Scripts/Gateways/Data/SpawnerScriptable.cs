using System;
using UnityEngine;

namespace CleanTest.Scripts.Gateways.Data
{
    [CreateAssetMenu(fileName = "Spawner", menuName = "Spawner")]
    [Serializable]
    public class SpawnerScriptable : ScriptableObject
    {
        public Sprite sprite;
        public float distance;
    }
}
