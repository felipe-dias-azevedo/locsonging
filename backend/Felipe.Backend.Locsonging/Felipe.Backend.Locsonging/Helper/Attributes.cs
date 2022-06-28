using System;

namespace Felipe.Backend.Locsonging.Helper
{
    public static class Attributes
    {
        public static Attribute Get<T>(Type type)
        {
            var attribute = Attribute.GetCustomAttribute(type, typeof(T));

            if (attribute == null)
            {
                throw new Exception();
            }
            
            return attribute;
        }
    }
}