using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XMLCodeGenerator.Exceptions;
using XMLCodeGenerator.Schemas.Pocos.Version1;

namespace XMLCodeGenerator.Services
{
    internal static class InjectedObjectService
    {
        private static List<object> _injectedObjects = new List<object>();

        internal static void AddObject(object obj)
        {
            _injectedObjects.Add(obj);
        }

        public static string GetStringValueFromObjectProperty(int objectIndex, string propertyName)
        {
            object src;
            try
            {
                src = _injectedObjects[objectIndex];
            }
            catch
            {
                throw new InvalidObjectIndexException(objectIndex, _injectedObjects.Count - 1);
            }
            
            var property = src.GetType().GetProperty(propertyName);
            
            if (property == null)
            {
                throw new PropertyNotFoundException(src.GetType(), propertyName);
            }

            var value = property.GetValue(src);

            if (value == null) 
            {
                throw new NullValueException(src.GetType(), objectIndex, propertyName);
            }

            return value.ToString()!;
        }

        public static string GetStringValueUsingDynamicString(DynamicString dynamicString)
        {
            return GetStringValueFromObjectProperty((int)dynamicString.InjectedObjectIndex, dynamicString.PropertyName);
        }

        public static void ClearObjects()
        {
            _injectedObjects = new List<object>();
        }
    }
}
