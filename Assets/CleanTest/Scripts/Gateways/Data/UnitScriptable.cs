using System;
using UnityEngine;

namespace CleanTest.Scripts.Gateways.Data
{
    [CreateAssetMenu(fileName = "Unit", menuName = "Unit")]
    [Serializable]
    public class UnitScriptable : ScriptableObject
    {
        public Sprite sprite;
        public string unitName;
        public int cost;
        public int health;
        public float attack;
        public float defense;
        public float moveSpeed;
        public float attackSpeed;
        public float attackRange;
        public float unitSize;
    }
}
