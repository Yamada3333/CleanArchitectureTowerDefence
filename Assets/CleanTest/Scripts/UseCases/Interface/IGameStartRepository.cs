using System.Collections.Generic;
using CleanTest.Scripts.Entities.Implement;

namespace CleanTest.Scripts.UseCases.Interface
{
    public interface IGameStartRepository
    {
        public List<UnitEntity> GetUnitList();
        public SpawnerEntity GetSpawner(bool isPlayer);
    }
}
