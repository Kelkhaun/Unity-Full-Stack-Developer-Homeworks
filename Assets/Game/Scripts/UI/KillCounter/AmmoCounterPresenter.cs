using Atomic.Elements;
using Atomic.Presenters;
using Game.Scripts.Types;
using SampleGame;
using UnityEngine;

public class AmmoCounterPresenter : StatsPresenter
{
    [SerializeField]
    private WeaponEntity _entity;

    protected override void OnInit()
    {
        _count = _entity.GetBulletCount();
        _maxValue = _entity.GetBulletCount().Value;
        base.OnInit();
    }
}