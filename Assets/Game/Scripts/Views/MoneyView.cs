using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Scripts.Views
{
    public sealed class MoneyView : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _moneyText;

        [SerializeField]
        private Image _coinImage;

        public void SetupMoney(string moneyText)
        {
            _moneyText.SetText(moneyText);
        }
        
        public void ChangeMoney(string moneyText)
        {
            _moneyText.SetText(moneyText);
        }

        public void PlayCoinAnimation(int previousValue, int newValue, float f)
        {
            _moneyText.DOCounter(previousValue, newValue, 0.75f);
        }

        public Vector3 GetCoinPosition()
        {
            return _coinImage.transform.position;
        }
    }
}