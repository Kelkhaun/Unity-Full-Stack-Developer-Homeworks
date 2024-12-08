using Zenject;

namespace Snake
{
    public class SnakeInputInstaller : Installer<
        KeybordInput.KeybordMap,
        KeybordInput.KeybordMap,
        SnakeInputInstaller>
    {                                  
        private readonly KeybordInput.KeybordMap _secondMap;
        private readonly KeybordInput.KeybordMap _firstMap;

        public SnakeInputInstaller(KeybordInput.KeybordMap secondMap, KeybordInput.KeybordMap firstMap)
        {
            _secondMap = secondMap;
            _firstMap = firstMap;
        }

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<KeybordInput>()
                .AsSingle()
                .WithArguments(_firstMap, _secondMap);

            Container.BindInterfacesTo<MoveController>()
                .AsCached()
                .NonLazy();
        }
    }
}