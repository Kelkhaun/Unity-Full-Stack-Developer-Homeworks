using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Game.Scripts.Views
{
    public class PlanetPopupView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _planetName;
        [SerializeField] private Button _closeButton;
        [SerializeField] private TMP_Text _population;
        [SerializeField] private TMP_Text _levelText;
        [SerializeField] private TMP_Text _incomeText;
        [SerializeField] private Button _upgradeButton;
        [SerializeField] private TMP_Text _costText;

        private IPlanetPopupPresenter _presenter;

        [Inject]
        public void Construct(IPlanetPopupPresenter planetPopupPresenter)
        {
            _presenter = planetPopupPresenter;
        }

        private void OnEnable()
        {
            _presenter.Enable();
            _presenter.OnPlanetUpgrade += UpdateView;
            _presenter.OnMoneyChanged += UpdateView;
            _presenter.OnPopulationChanged += OnPopulationChanged;

            UpdateView();

            gameObject.SetActive(true);
            _closeButton.onClick.AddListener(OnCloseButtonClicked);
            _upgradeButton.onClick.AddListener(OnUpgradeButtonClicked);
        }

        private void OnDisable()
        {
            _presenter.Disable();
            _presenter.OnPlanetUpgrade -= UpdateView;
            _presenter.OnMoneyChanged -= UpdateView;
            _closeButton.onClick.RemoveListener(OnCloseButtonClicked);
            _upgradeButton.onClick.RemoveListener(OnUpgradeButtonClicked);
            gameObject.SetActive(false);
        }

        private void OnPopulationChanged(int _)
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
            gameObject.SetActive(false);
        }

        private void OnUpgradeButtonClicked()
        {
            _presenter.OnUpgradeButtonClick();
        }
    }
}