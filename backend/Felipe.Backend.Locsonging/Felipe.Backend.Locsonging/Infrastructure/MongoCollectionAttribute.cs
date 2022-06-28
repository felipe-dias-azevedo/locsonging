using System;

namespace Felipe.Backend.Locsonging.Infrastructure
{   
    [AttributeUsage(AttributeTargets.Class)]
    public class MongoCollectionAttribute : Attribute
    {
        public readonly string Name;
        
        public MongoCollectionAttribute(string name)
        {
            Name = name;
        }
    }
}