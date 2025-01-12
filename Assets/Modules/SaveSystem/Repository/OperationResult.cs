using System.Collections.Generic;

namespace Modules.SaveSystem.Repository
{
    public struct OperationResult
    {
        public bool Success;
        public int SaveVersion;
        public Dictionary<string, string> SaveData;
    }
}