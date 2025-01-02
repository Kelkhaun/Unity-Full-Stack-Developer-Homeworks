using System;
using Modules.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Game.Scripts.Views
{
    public sealed class PlanetView : MonoBehaviour, IInitializable, IDisposable
    {
        public event Action<PlanetView> OnClicked;
        public event Action<PlanetView> OnHolded;

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

        public Vector3 CoinPosition => _coin.transform.position;

        public void Initialize()
        {
            _smartButton.OnClick += OnClick;
            _smartButton.OnHold += OnHold;
        }

        public void Dispose()
        {
            _smartButton.OnClick -= OnClick;
            _smartButton.OnHold -= OnHold;
        }

        private void OnClick()
        {
            OnClicked?.Invoke(this);
        }

        private void OnHold()
        {
            OnHolded?.Invoke(this);
        }

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

        public void OnIncomeTimeChanged(string remainigTime, float progress)
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