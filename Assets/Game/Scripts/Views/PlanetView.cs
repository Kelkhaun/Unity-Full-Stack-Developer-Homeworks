using System;
using Modules.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Scripts.Views
{
    public sealed class PlanetView : MonoBehaviour
    {
        public event Action OnClicked
        {
            add { _smartButton.OnClick += value; }
            remove { _smartButton.OnClick -= value;  }
        }

        public event Action OnHolded
        {
            add { _smartButton.OnHold += value; }
            remove { _smartButton.OnHold -= value; }
        }

        [SerializeField]
        private Image _icon;

        [SerializeField]
        private Image _lock;

        [SerializeField]
        private Image _coin;

        [SerializeField]
        private Image _sliderBackground;

        [SerializeField]
        private Image _sliderProgress;

        [SerializeField]
        private TMP_Text _sliderText;

        [SerializeField]
        private GameObject _planetPriceObject;

        [SerializeField]
        private TMP_Text _planetPriceText;

        [SerializeField]
        private SmartButton _smartButton;

        public void Lock(Sprite sprite, string price)
        {
            _icon.sprite = sprite;
            _lock.gameObject.SetActive(true);
            _coin.gameObject.SetActive(false);
            _sliderBackground.gameObject.SetActive(false);
            _planetPriceObject.SetActive(true);
            _planetPriceText.SetText(price);
        }

        public void Unlock(Sprite sprite)
        {
            _icon.sprite = sprite;
            _lock.gameObject.SetActive(false);
            _planetPriceObject.SetActive(false);
            _sliderBackground.gameObject.SetActive(true);
            _sliderText.SetText("");
        }

        public Vector3 GetCoinPosition()
        {
            return _coin.transform.position;
        }

        public void SetTime(string remainigTime, float progress)
        {
            _sliderText.SetText(remainigTime);
            _sliderProgress.fillAmount = progress;
        }

        public void SetIncomeReadyStatus(bool isIncomeReady)
        {
            _sliderBackground.gameObject.SetActive(!isIncomeReady);
            _coin.gameObject.SetActive(isIncomeReady);
        }
    }
}