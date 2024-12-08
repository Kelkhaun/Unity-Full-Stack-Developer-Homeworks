using Modules;
using UnityEngine;
using Zenject;

namespace Snake
{
    public sealed class SnakeInstaller : MonoInstaller
    {
        [SerializeField]
        private Modules.Snake _snakePrefab;

        [SerializeField]
        private Transform _worldTransform;

        [Space]
        [SerializeField]
        private KeybordInput.KeybordMap _firstMap;

        [SerializeField]
        private KeybordInput.KeybordMap _secondMap;

        public override void InstallBindings()
        {
            Container.Bind<ISnake>()
                .FromComponentInNewPrefab(_snakePrefab)
                .UnderTransform(_worldTransform)
                .AsSingle()
                .NonLazy();

            Container.BindInterfacesAndSelfTo<SnakeCoinEater>()
                .AsSingle();

            SnakeInputInstaller.Install(Container, _firstMap, _secondMap);

        }
    }
}
