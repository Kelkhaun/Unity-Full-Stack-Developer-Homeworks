using Atomic.Elements;
using Atomic.Presenters;
using UnityEngine;

public abstract class CounterPresenter : Presenter
{
    [SerializeField]
    private CounterView _view;

    protected ReactiveInt _count;

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
        _view.SetCounterText(value.ToString());
    }
}