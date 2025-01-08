using UnityEngine;
using Zenject;

namespace Game.Scripts.SaveSystem.Repostiory
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