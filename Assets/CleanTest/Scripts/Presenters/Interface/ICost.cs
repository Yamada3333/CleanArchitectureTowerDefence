using System;

namespace CleanTest.Scripts.Presenters.Interface
{
    public interface ICost
    {
        public void Initialize(IObservable<int> cost);
    }
}
