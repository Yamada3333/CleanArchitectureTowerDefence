using CleanTest.Scripts.Entities.Implement;
using CleanTest.Scripts.UseCases.DataStruct.OutputData;
using CleanTest.Scripts.UseCases.Interface;
using VContainer;

namespace CleanTest.Scripts.UseCases.Implement
{
    public class GameStartInteractor : IGameStartUseCase
    {
        private IGameStartRepository _gameStartRepository;
        private IGameStartPresenter _gameStartPresenter;
        private CostEntity _costEntity;
        
        [Inject]
        public void Container(
            IGameStartRepository gameStartRepository, 
            IGameStartPresenter gameStartPresenter,
            CostEntity costEntity)
        {
            _gameStartRepository = gameStartRepository;
            _gameStartPresenter = gameStartPresenter;
            _costEntity = costEntity;
        }
        
        public void GameStart()
        {
            var playerSpawner = _gameStartRepository.GetSpawner(true);
            var enemySpawner = _gameStartRepository.GetSpawner(false);
            var cost = _costEntity.Cost;
            var unitList = _gameStartRepository.GetUnitList();
            
            var outputData = new GameStartOutputData(playerSpawner, enemySpawner,cost , unitList);
            _gameStartPresenter.GameStart(outputData);
        }
    }
}
