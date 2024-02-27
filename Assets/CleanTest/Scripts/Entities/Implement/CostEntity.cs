using UniRx;

namespace CleanTest.Scripts.Entities.Implement
{
    public class CostEntity
    {
        private readonly ReactiveProperty<int> _cost = new();
        public IReadOnlyReactiveProperty<int> Cost => _cost;
    }
}
