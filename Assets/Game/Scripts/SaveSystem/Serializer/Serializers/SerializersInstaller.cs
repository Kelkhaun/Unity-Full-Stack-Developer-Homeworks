using Game.Scripts.SaveSystem.SaveLoader;
using Zenject;

namespace Game.Scripts.SaveSystem.Serializer.Serializers
{
    public sealed class SerializersInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<GameSaveLoader>().AsSingle();

            Container.BindInterfacesTo<EntitySerializer>()
                .AsSingle();

            Container.BindInterfacesTo<EntityHealthComponentSerializer>()
                .AsSingle();

            Container.BindInterfacesTo<TeamComponentSerializer>()
                .AsSingle();

            Container.BindInterfacesTo<EntityDestinationSerializer>()
                .AsSingle();
        
            Container.BindInterfacesTo<TargetObjectSerializer>()
                .AsSingle();

            Container.BindInterfacesTo<ResourceBagSerializer>()
                .AsSingle();

            Container.BindInterfacesTo<CountdownSerializer>()
                .AsSingle();

            Container.BindInterfacesTo<ProductionOrderSerializer>()
                .AsSingle();
        }
    }
}