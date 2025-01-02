using System;
using System.Collections.Generic;
using DG.Tweening;
using Game.Scripts.Views;
using Modules.Money;
using Modules.UI;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Presenters
{
    public class MoneyViewPresenter : IInitializable, IDisposable
    {
        private MoneyView _view;
        private IMoneyStorage _storage;
        private PlanetGroupPresenter _planetGroupPresenter;
        private ParticleAnimator _particleAnimator;

        private Queue<int> _moneyToAddQueue = new Queue<int>();

        public MoneyViewPresenter(MoneyView view,
            IMoneyStorage storage,
            PlanetGroupPresenter planetGroupPresenter,
            ParticleAnimator particleAnimator)
        {
            _view = view;
            _storage = storage;
            _planetGroupPresenter = planetGroupPresenter;
            _particleAnimator = particleAnimator;
        }

        public void Initialize()
        {
            _storage.OnMoneyEarned += OnMoneyEarned;
            _storage.OnMoneySpent += OnMoneySpent;
            _planetGroupPresenter.OnPlanetGathered += OnPlanetGathered;
            _view.MoneyText.text = _storage.Money.ToString();
        }

        public void Dispose()
        {
            _storage.OnMoneyEarned -= OnMoneyEarned;
            _storage.OnMoneySpent -= OnMoneySpent;
            _planetGroupPresenter.OnPlanetGathered -= OnPlanetGathered;
        }

        private void OnMoneySpent(int newValue, int previousValue)
        {
            _view.MoneyText.text = _storage.Money.ToString();
        }

        private void OnMoneyEarned(int newValue, int previousValue)
        {
            _moneyToAddQueue.Enqueue(newValue - previousValue);
        }

        private void OnPlanetGathered(Vector3 startPosition)
        {
            var previousValue = _moneyToAddQueue.Dequeue();
            _particleAnimator.Emit(startPosition,
                _view.CoinImage.transform.position,
                1f,
                () => { ChangeMoney(_storage.Money, previousValue); });
        }

        private void ChangeMoney(int newValue, int previousValue)
        {
            _view.MoneyText.DOCounter(previousValue, newValue, 0.75f);
        }
    }
}