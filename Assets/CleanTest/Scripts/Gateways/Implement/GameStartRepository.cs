using System.Collections.Generic;
using CleanTest.Scripts.Entities.Implement;
using CleanTest.Scripts.Gateways.Data;
using CleanTest.Scripts.UseCases.Interface;
using UnityEngine;
using VContainer;

namespace CleanTest.Scripts.Gateways.Implement
{
    public class GameStartRepository : IGameStartRepository
    {
        private readonly DataBase _dataBase;
        
        [Inject]
        public GameStartRepository(DataBase dataBase)
        {
            _dataBase = dataBase;
        }


        public List<UnitEntity> GetUnitList()
        {
            var unitList = new List<UnitEntity>();
            foreach (var unitScriptable in _dataBase.unitScriptableList)
            {
                var unit = new UnitEntity
                {
                    UnitName = unitScriptable.unitName,
                    Cost = unitScriptable.cost,
                    Health =
                    {
                        Value = unitScriptable.health
                    },
                    Attack = unitScriptable.attack,
                    Defense = unitScriptable.defense,
                    MoveSpeed = unitScriptable.moveSpeed,
                    AttackSpeed = unitScriptable.attackSpeed,
                    AttackRange = unitScriptable.attackRange,
                    UnitSize = unitScriptable.unitSize
                };
                unitList.Add(unit);
            }

            return unitList;
        }

        public SpawnerEntity GetSpawner(bool isPlayer)
        {
            var distance = _dataBase.spawnerScriptable.distance;
            var positionX = isPlayer ? -distance : distance;
            var position = new Vector3(positionX, 0, 0);

            var spawner = new SpawnerEntity
            {
                Sprite = _dataBase.spawnerScriptable.sprite,
                Position = position
            };
            
            return spawner;
        }
    }
}
