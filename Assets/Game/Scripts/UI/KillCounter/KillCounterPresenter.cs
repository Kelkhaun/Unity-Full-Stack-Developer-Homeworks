using Atomic.Elements;
using Atomic.Presenters;
using Game.Scripts.Context;
using SampleGame;
using UnityEngine;

public class KillCounterPresenter : Presenter
{
    [SerializeField]
    private KillCounterView _view;

    private ReactiveInt _killCount;

    protected override void OnInit()
    {
        _killCount = GameContext.Instance.GetEnemyKillCount();
        _killCount.Observe(OnCounterChanged);
    }

    protected override void OnDispose()
    {
        _killCount.Unsubscribe(OnCounterChanged);
    }

    private void OnCounterChanged(int value)
    {
        _view.SetCounterText(value.ToString());
    }
}