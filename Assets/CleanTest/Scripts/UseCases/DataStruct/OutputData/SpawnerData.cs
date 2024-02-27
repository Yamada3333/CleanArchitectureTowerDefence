using UnityEngine;

namespace CleanTest.Scripts.UseCases.DataStruct.OutputData
{
    public class SpawnerData
    {
        public readonly Sprite spawnerSprite;
        public readonly Vector3 position;
        
        public SpawnerData(Sprite sprite, Vector3 position)
        {
            spawnerSprite = sprite;
            this.position = position;
        }
    }
}
