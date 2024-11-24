using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLCodeGenerator.Exceptions
{
    internal class InvalidObjectIndexException : Exception
    {
        public InvalidObjectIndexException(int index, int maxIndex) : base($"Object does not exist at Index: {index}. Max Index is: {maxIndex}")
        {
        }
    }
}
