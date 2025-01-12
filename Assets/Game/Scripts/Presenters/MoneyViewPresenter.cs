using System;
using System.Collections.Generic;
using Game.Scripts.Views;
using Modules.Money;
using Modules.UI;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Presenters
{
    public class MoneyViewPresenter : IInitializable, IDisposable
    {
        private readonly MoneyView _view;
        private readonly IMoneyStorage _storage;
        private readonly ParticleAnimator _particleAnimator;

        private Queue<int> _moneyToAddQueue = new Queue<int>();

        public MoneyViewPresenter(MoneyView view,
            IMoneyStorage storage,
            ParticleAnimator particleAnimator)
        {
            _view = view;
            _storage = storage;
            _particleAnimator = particleAnimator;
        }

        public void Initialize()
        {
            _storage.OnMoneyEarned += OnMoneyEarned;
            _storage.OnMoneySpent += OnMoneySpent;
            _view.SetupMoney(_storage.Money.ToString());
        }

        public void Dispose()
        {
            _storage.OnMoneyEarned -= OnMoneyEarned;
            _storage.OnMoneySpent -= OnMoneySpent;
        }

        private void OnMoneySpent(int newValue, int previousValue)
        {
            _view.ChangeMoney(_storage.Money.ToString());
        }

        private void OnMoneyEarned(int newValue, int previousValue)
        {
            _moneyToAddQueue.Enqueue(newValue - previousValue);
        }

        public void AnimateIncome(Vector3 startPosition)
        {
            var previousValue = _moneyToAddQueue.Dequeue();

            _particleAnimator.Emit(startPosition,
                _view.GetCoinPosition(),
                1f,
                () => { ChangeMoney(_storage.Money, previousValue); });
        }

        private void ChangeMoney(int newValue, int previousValue)
        {
            _view.PlayCoinAnimation(previousValue, newValue, 0.75f);
        }
    }
}