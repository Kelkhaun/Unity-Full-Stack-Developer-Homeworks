using System.Collections;
using System.Collections.Generic;
using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using SampleGame;
using UnityEngine;
using UnityEngine.Serialization;

public class PistolInstaller : SceneEntityInstaller<IWeaponEntity>
{
    [SerializeField] private WeaponEntity _weapon;
    [SerializeField] private Transform _firePoint;
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Countdown _fireTimer;
    [SerializeField] private ReactiveFloat _fireSpread;
    [SerializeField] private ReactiveInt _initialBulletCount;
    [SerializeReference] private IEntityPredicateAsset[] _fireConditions;
    [SerializeReference] private IEntityActionAsset[] _fireActions;

    protected override void Install(IWeaponEntity entity)
    {
        //Data
        entity.AddBulletPrefab(_bulletPrefab);
        entity.AddFirePoint(_firePoint);
        entity.AddFireSpread(_fireSpread);
        entity.AddBulletCount(_initialBulletCount);
        //Shooting
        entity.AddWeapon(_weapon);
        entity.AddShootTimer(_fireTimer);
        entity.AddCanShoot(new ReactiveBool(true));
        entity.AddBehaviour<CanShootDelayBehaviour>();
        entity.AddBehaviour<ShootingBehaviour>();
        entity.AddBehaviour<WeaponFiringBehaviour>();
        //Event
        BaseEvent shootRequestEvent = new BaseEvent();
        entity.AddShootingRequest(shootRequestEvent);

        AndExpression condition = new AndExpression();
        condition.AppendBy(_fireConditions, entity);
        entity.AddShootingCondition(condition);

        BaseEvent shootEvent = new BaseEvent();
        shootEvent.SubscribeAllBy(_fireActions, entity);
        entity.AddShootEvent(shootEvent);
    }
}