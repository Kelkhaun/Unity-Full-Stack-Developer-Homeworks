using Modules;
using Zenject;

namespace Infrasctrusture
{
    public sealed class DifficultyInstaller : Installer<DifficultyInstaller>
    {
        private readonly int _maxLevels = 9;

        override public void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<Difficulty>()
                .AsSingle()
                .WithArguments(_maxLevels);

            Container.BindInterfacesAndSelfTo<DifficultyChanger>()
                .AsSingle();
        }
    }
}