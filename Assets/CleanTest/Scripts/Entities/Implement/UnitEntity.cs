using UniRx;
using UnityEngine;

namespace CleanTest.Scripts.Entities.Implement
{
    public class UnitEntity
    {
        private Vector3 TargetPosition { set; get; }
        private UnitEntity TargetUnit { set; get; }

        public Vector3ReactiveProperty Position { get; set; } = new();
        
        public Sprite Sprite { get; set; }
        public string UnitName { get; set; }
        public int Cost { get; set; }
        public IntReactiveProperty Health { get; } = new();
        public float Attack { get; set; }
        public float Defense { get; set; }
        public float MoveSpeed { get; set; }
        public float AttackSpeed { get; set; }
        public float AttackRange { get; set; }
        public float UnitSize { get; set; }

        public UnitEntity()
        {
            
        }
    }
}
