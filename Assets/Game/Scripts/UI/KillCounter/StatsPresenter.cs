using Atomic.Elements;
using Atomic.Presenters;
using Game.Scripts.UI.Stats;
using UnityEngine;

public abstract class StatsPresenter : Presenter
{
    [SerializeField]
    private StatView _view;

    protected ReactiveInt _count;
    protected int _maxValue;

    protected override void OnInit()
    {
        _count.Observe(OnCounterChanged);
    }

    protected override void OnDispose()
    {
        _count.Unsubscribe(OnCounterChanged);
    }

    private void OnCounterChanged(int value)
    {
        _view.SetText(value.ToString());
        _view.SetProgress((float)value /_maxValue);
    }
}