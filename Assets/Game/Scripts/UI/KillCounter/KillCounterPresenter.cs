using Atomic.Elements;
using Atomic.Presenters;
using Game.Scripts.Context;
using SampleGame;
using UnityEngine;

public class KillCounterPresenter : Presenter
{
    [SerializeField] private KillCounterView _view;

    protected override void OnInit()
    {
        GameContext.Instance.GetEnemyKillCount().Observe(OnCounterChanged);
    }

    protected override void OnDispose()
    {
        GameContext.Instance.GetEnemyKillCount().Unsubscribe(OnCounterChanged);
    }

    private void OnCounterChanged(int value)
    {
        _view.SetCounterText(value.ToString());
    }
}