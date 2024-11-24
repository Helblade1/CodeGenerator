using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLCodeGenerator.Generators.Abstract
{
    internal class ABaseGenerator : IGenerator
    {
        protected static int _depth = 0;

        public virtual string Generate()
        {
            throw new NotImplementedException();
        }
    }
}
