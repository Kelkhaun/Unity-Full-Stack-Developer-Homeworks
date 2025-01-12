using System.Collections.Generic;
using Modules.Entities;
using Modules.SaveSystem.SaveLoader.Serializator;
using Newtonsoft.Json;
using Zenject;

namespace Game.Scripts.App.SaveSerializers
{
    public abstract class EntityComponentSerializer<TService1, TData, TComponent> : IGameSerializer
    {
        protected virtual string Key => typeof(TData).Name;

        [Inject]
        private EntityWorld _entityWorld;

        [Inject]
        private TService1 _service1;

        public void Serialize(IDictionary<string, string> saveState)
        {
            Dictionary<int, TComponent> components = GetComponents();

            TData data = this.Serialize(_service1, components);
            saveState[this.Key] = JsonConvert.SerializeObject(data);
        }

        public void Deserialize(IDictionary<string, string> loadState)
        {
            if (!loadState.TryGetValue(this.Key, out string json))
                return;

            TData data = JsonConvert.DeserializeObject<TData>(json);

            Dictionary<int, TComponent> components = GetComponents();

            this.Deserialize(_service1, data, components);
        }

        private Dictionary<int, TComponent> GetComponents()
        {
            Dictionary<int, TComponent> components = new();

            foreach (var entity in _entityWorld.GetAll())
            {
                if (entity.TryGetComponent(out TComponent component))
                    components.Add(entity.Id, component);
            }

            return components;
        }

        protected abstract TData Serialize(TService1 service1, Dictionary<int, TComponent> components);
        protected abstract void Deserialize(TService1 service1, TData data, Dictionary<int, TComponent> components);
    }
}