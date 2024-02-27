using System;
using CleanTest.Scripts.Presenters.Interface;
using TMPro;
using UniRx;
using UnityEngine;

namespace CleanTest.Scripts.View.Implement
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class CostText : MonoBehaviour, ICost
    {
        private TextMeshProUGUI _costText;
        
        public void Initialize(IObservable<int> cost)
        {
            _costText = GetComponent<TextMeshProUGUI>();
            cost.Subscribe(ChangeCost);
        }
        
        private void ChangeCost(int cost)
        {
            _costText.text = cost.ToString();
        }
    }
}
