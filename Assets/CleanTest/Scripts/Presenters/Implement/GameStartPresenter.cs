using System;
using CleanTest.Scripts.Presenters.Interface;
using CleanTest.Scripts.UseCases.DataStruct.OutputData;
using CleanTest.Scripts.UseCases.Interface;
using VContainer;

namespace CleanTest.Scripts.Presenters.Implement
{
    public class GameStartPresenter : IGameStartPresenter
    {
        private readonly Func<SpawnerData, ISpawner> _spawner;
        private readonly Func<CardData, ICard> _card;
        private readonly ICost _cost;
        
        [Inject]
        public GameStartPresenter(
            Func<SpawnerData, ISpawner> spawner,
            Func<CardData, ICard> card,
            ICost cost)
        {
            _spawner = spawner;
            _card = card;
            _cost = cost;
        }
        
        public void GameStart(GameStartOutputData outputData)
        {
            _spawner.Invoke(outputData.playerSpawnerData);
            _spawner.Invoke(outputData.enemySpawnerData);
            _cost.Initialize(outputData.cost);

            foreach (var cardData in outputData.unitDataList)
            {
                _card.Invoke(cardData);
            }
        }
    }
}
