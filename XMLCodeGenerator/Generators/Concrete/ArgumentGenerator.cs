using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XMLCodeGenerator.Generators.Abstract;
using XMLCodeGenerator.Schemas.Pocos.Version1;

[assembly: InternalsVisibleTo("XMLCodeGenerator.NUnit")]
namespace XMLCodeGenerator.Generators.Concrete
{
    internal class ArgumentGenerator : ABaseGenerator
    {
        private Argument[] _arguments;
        public ArgumentGenerator(Argument[] arguments)
        {
            _arguments = arguments;
        }

        public override string Generate()
        {
            var sb = new StringBuilder();
            foreach (var arg in _arguments)
            {
                if (sb.Length != 0) sb.Append(", ");
                sb.Append($"{arg.ArgumentType} {arg.Name}");
            }
            return sb.ToString();
        }
    }
}
