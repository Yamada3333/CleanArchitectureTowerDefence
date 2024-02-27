using CleanTest.Scripts.Presenters.Interface;
using CleanTest.Scripts.UseCases.DataStruct.OutputData;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CleanTest.Scripts.View.Implement
{
    public class Card : MonoBehaviour, ICard
    {
        [SerializeField] private Image image;
        [SerializeField] private TextMeshProUGUI costText;
        
        public void Initialize(CardData data)
        {
            image.sprite = data.sprite;
            costText.text = data.cost.ToString();
        }
    }
}
