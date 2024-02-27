using CleanTest.Scripts.Entities.Implement;
using CleanTest.Scripts.Gateways.Data;
using CleanTest.Scripts.Gateways.Implement;
using CleanTest.Scripts.Presenters.Implement;
using CleanTest.Scripts.Presenters.Interface;
using CleanTest.Scripts.UseCases.DataStruct.OutputData;
using CleanTest.Scripts.UseCases.Implement;
using CleanTest.Scripts.UseCases.Interface;
using CleanTest.Scripts.View.Implement;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace CleanTest.Scripts.Application.LifeTimeScope
{
    public class MainLifeTimeScope : LifetimeScope
    {
        public Spawner spawner;
        public Card card;
        public DataBase dataBase;
        public CostText costText;
        
        // ここでやるのは良くないかも？
        public Transform cardParent;
        
        protected override void Configure(IContainerBuilder builder)
        {
            // 1層 Entity
            builder.Register<CostEntity>(Lifetime.Singleton);
            
            // 2層 UseCase Interactor
            builder.Register<IGameStartUseCase, GameStartInteractor>(Lifetime.Singleton);
            
            // 3層 Adapters (Presenter Gateway 等々)
            builder.Register<IGameStartPresenter, GameStartPresenter>(Lifetime.Singleton);
            builder.Register<IGameStartRepository, GameStartRepository>(Lifetime.Singleton);
            
            // 4層 pure C#以外のもの (MonoBehaviour ScriptableObject 等々)
            // ScriptableObjectをDIする場合は、RegisterInstanceで登録する
            builder.RegisterInstance(dataBase);
            
            // UnityのHierarchyにあるオブジェクトをDIする場合は、RegisterInstanceで登録する
            builder.RegisterInstance<ICost>(costText);
            
            // UIをスクリプトで動的に生成する場合は、RegisterFactoryで登録する
            builder.RegisterFactory<SpawnerData, ISpawner>(Instantiate);
            builder.RegisterFactory<CardData, ICard>(Instantiate);
        }
        
        private ISpawner Instantiate(SpawnerData data)
        {
            var spawnerObject = Instantiate(spawner);
            spawnerObject.Initialize(data);
            return spawnerObject;
        }
        
        private ICard Instantiate(CardData data)
        {
            var cardObject = Instantiate(card, cardParent);
            cardObject.Initialize(data);
            return cardObject;
        }
    }
}
