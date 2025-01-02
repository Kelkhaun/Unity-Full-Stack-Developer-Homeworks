using System;
using Game.Scripts.Window;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Scripts.Gameplay.PlanetPopup
{
    public class PlanetPopupView : MonoWindow<IPlanetPopupPresenter>
    {
        [SerializeField] private TMP_Text _planetName;
        [SerializeField] private Button _closeButton;
        [SerializeField] private TMP_Text _population;
        [SerializeField] private TMP_Text _levelText;
        [SerializeField] private TMP_Text _incomeText;
        [SerializeField] private Button _upgradeButton;
        [SerializeField] private TMP_Text _costText;
        

        private IPlanetPopupPresenter _presenter;

        protected override void OnShow(IPlanetPopupPresenter presenter)
        {
            if (presenter is not IPlanetPopupPresenter popupPresenter)
                throw new Exception("Expected IPlanetPopupPresenter Presenter");
            
            _presenter = popupPresenter;
            
            _presenter.OnPlanetUpgrade += UpdateView;
            _presenter.OnPopulationChanged += OnOnPopulationChanged;
            
            UpdateView();

            gameObject.SetActive(true);
            _closeButton.onClick.AddListener(OnCloseButtonClicked);
            _upgradeButton.onClick.AddListener(OnUpgradeButtonClicked);
        }

        private void OnOnPopulationChanged(int _)
        {
            _population.SetText(_presenter.PlanetPopulation);
        }

        private void UpdateView()
        {
            _planetName.SetText(_presenter.PlanetName);
            _population.SetText(_presenter.PlanetPopulation);
            _levelText.SetText(_presenter.PlanetLevel);
            _incomeText.SetText(_presenter.PlanetIncome);
            _costText.SetText(_presenter.PlanetPrice);
            _upgradeButton.interactable = _presenter.IsButtonActive;
        }

        private void OnCloseButtonClicked()
        {
            Hide();
        }

        protected override void OnHide()
        {
            _presenter.OnPlanetUpgrade -= UpdateView;
            _closeButton.onClick.RemoveListener(OnCloseButtonClicked);
            _upgradeButton.onClick.RemoveListener(OnUpgradeButtonClicked);
            gameObject.SetActive(false);
        }

        private void OnUpgradeButtonClicked()
        {
            _presenter.OnUpgradeButtonClick();
        }
    }
}