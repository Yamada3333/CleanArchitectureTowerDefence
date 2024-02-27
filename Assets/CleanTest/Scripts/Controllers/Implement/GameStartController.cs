using CleanTest.Scripts.UseCases.Interface;
using UnityEngine;
using VContainer;

namespace CleanTest.Scripts.Controllers.Implement
{
    public class GameStartController : MonoBehaviour
    {
        private IGameStartUseCase _gameStartUseCase;
        
        [Inject]
        public void Container(IGameStartUseCase gameStartUseCase)
        {
            _gameStartUseCase = gameStartUseCase;
        }

        private void Start()
        {
            _gameStartUseCase.GameStart();
        }
    }
}
