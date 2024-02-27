using System;
using System.Collections.Generic;
using UnityEngine;

namespace CleanTest.Scripts.Gateways.Data
{
    [CreateAssetMenu(fileName = "DataBase", menuName = "DataBase")]
    [Serializable]
    public class DataBase : ScriptableObject
    {
        public List<UnitScriptable> unitScriptableList;
        public SpawnerScriptable spawnerScriptable;
    }
}
