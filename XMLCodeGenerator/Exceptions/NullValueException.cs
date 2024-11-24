using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLCodeGenerator.Exceptions
{
    internal class NullValueException : Exception
    {
        public NullValueException(Type type, int objectIndex, string propertyName) : base($"Object of Type: {type.Name} at Index: {objectIndex} has a null value for Property: {propertyName}")
        {
        }
    }
}
