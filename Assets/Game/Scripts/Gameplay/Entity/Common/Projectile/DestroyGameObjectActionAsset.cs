using System;
using Atomic.Entities;
using Atomic.Extensions;
using SampleGame;
using Object = UnityEngine.Object;

public class DestroyGameObjectActionAsset : IEntityActionAsset
{
    public Action Create(IEntity entity)
    {
        return () =>
        {
            Object.Destroy(entity.GetGameObject());
        };
    }
}