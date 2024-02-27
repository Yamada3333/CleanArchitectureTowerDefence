using CleanTest.Scripts.Presenters.Interface;
using CleanTest.Scripts.UseCases.DataStruct.OutputData;
using UnityEngine;

namespace CleanTest.Scripts.View.Implement
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Spawner : MonoBehaviour, ISpawner
    {
        private SpriteRenderer _spriteRenderer;

        public void Initialize(SpawnerData data)
        {
            transform.position = data.position;
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _spriteRenderer.sprite = data.spawnerSprite;
        }
    }
}
