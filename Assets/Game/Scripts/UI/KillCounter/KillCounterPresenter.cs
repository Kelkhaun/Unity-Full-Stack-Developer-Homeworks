using Game.Scripts.Context;
using SampleGame;

public class KillCounterPresenter : CounterPresenter
{
    protected override void OnInit()
    {
        _count = GameContext.Instance.GetEnemyKillCount();
        base.OnInit();
    }
}