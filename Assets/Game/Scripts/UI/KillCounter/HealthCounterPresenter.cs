using Atomic.Entities;
using SampleGame;
using UnityEngine;

public class HealthCounterPresenter : StatsPresenter
{
    [SerializeField]
    private SceneEntity _entity;

    protected override void OnInit()
    {
        _count = _entity.GetCurrentHealth();
        _maxValue = _entity.GetMaxHealth().Value;
        base.OnInit();
    }
}