using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLCodeGenerator.Exceptions
{
    internal class PropertyNotFoundException : Exception
    {
        public PropertyNotFoundException(Type type, string propertyName) : base($"Type: {type.FullName} does not have Property with Name: {propertyName}")
        {

        }
    }
}
