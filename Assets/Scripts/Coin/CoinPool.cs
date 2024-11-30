using Zenject;

namespace Coin
{
    public sealed class CoinPool : MonoMemoryPool<Modules.Coin>
    {
        protected override void Reinitialize(Modules.Coin item)
        {
            item.Generate();
        }
    }
}