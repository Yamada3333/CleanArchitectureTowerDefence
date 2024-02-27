using System;
using System.Collections.Generic;
using CleanTest.Scripts.Entities.Implement;

namespace CleanTest.Scripts.UseCases.DataStruct.OutputData
{
    public class GameStartOutputData
    {
        // タイマーの作成
        // Spawnerの作成
        public readonly SpawnerData playerSpawnerData;
        public readonly SpawnerData enemySpawnerData;
        // プレイヤーのコストUIの作成
        public readonly IObservable<int> cost;
        // ユニットUIリストの作成
        public readonly List<CardData> unitDataList;
        
        public GameStartOutputData(
            SpawnerEntity playerSpawner, 
            SpawnerEntity enemySpawner, 
            IObservable<int> cost,
            List<UnitEntity> unitList)
        {
            playerSpawnerData = new SpawnerData(playerSpawner.Sprite, playerSpawner.Position);
            enemySpawnerData = new SpawnerData(enemySpawner.Sprite, enemySpawner.Position);
            unitDataList = new List<CardData>();
            this.cost = cost;
            foreach (var unit in unitList)
            {
                unitDataList.Add(new CardData(unit.Sprite, unit.Cost));
            }
        }
    }
}
