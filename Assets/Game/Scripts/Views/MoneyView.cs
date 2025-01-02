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

        public TMP_Text MoneyText => _moneyText;

        public Image CoinImage => _coinImage;
    }
}