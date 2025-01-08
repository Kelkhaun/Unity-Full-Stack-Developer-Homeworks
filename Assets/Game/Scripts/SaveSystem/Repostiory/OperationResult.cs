using System.Collections.Generic;

namespace Game.Scripts.SaveSystem.Repostiory
{
    public struct OperationResult
    {
        public bool Success;
        public int SaveVersion;
        public Dictionary<string, string> SaveData;
    }
}