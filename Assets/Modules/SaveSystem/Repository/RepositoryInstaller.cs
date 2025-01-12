using UnityEngine;
using Zenject;

namespace Modules.SaveSystem.Repository
{
    [CreateAssetMenu(
        fileName = "RepositoryInstaller",
        menuName = "Zenject/App/New RepositoryInstaller"
    )]
    public sealed class RepositoryInstaller : ScriptableObjectInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<GameRepository>()
                .AsSingle();
        }
    }
}