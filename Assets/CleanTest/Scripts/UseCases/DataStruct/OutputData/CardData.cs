using UnityEngine;

namespace CleanTest.Scripts.UseCases.DataStruct.OutputData
{
    public class CardData
    {
        public readonly Sprite sprite;
        public readonly int cost;
        
        public CardData(Sprite sprite, int cost)
        {
            this.sprite = sprite;
            this.cost = cost;
        }
    }
}
