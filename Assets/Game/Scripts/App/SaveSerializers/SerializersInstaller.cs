using Modules.SaveSystem.SaveLoader;
using Modules.SaveSystem.SaveLoader.Serializator;
using Zenject;

namespace Game.Scripts.App.SaveSerializers
{
    public sealed class SerializersInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<GameSaveLoader>().AsSingle();
            
            Container.Bind<IGameSerializer[]>().FromMethod((context) =>
            {
                return new IGameSerializer[]
                {
                    context.Container.Instantiate<EntitySerializer>(),
                    context.Container.Instantiate<EntityHealthComponentSerializer>(),
                    context.Container.Instantiate<TeamComponentSerializer>(),
                    context.Container.Instantiate<EntityDestinationSerializer>(),
                    context.Container.Instantiate<TargetObjectSerializer>(),
                    context.Container.Instantiate<ResourceBagSerializer>(),
                    context.Container.Instantiate<CountdownSerializer>(),
                    context.Container.Instantiate<ProductionOrderSerializer>(),
                };
            }).AsSingle();
        }
    }
}