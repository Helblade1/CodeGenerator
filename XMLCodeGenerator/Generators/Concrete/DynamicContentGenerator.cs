using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLCodeGenerator.Exceptions;
using XMLCodeGenerator.Generators.Abstract;
using XMLCodeGenerator.Schemas.Pocos.Version1;
using XMLCodeGenerator.Services;

namespace XMLCodeGenerator.Generators.Concrete
{
    internal class DynamicContentGenerator : ABaseGenerator
    {
        private string _rawContent;
        private DynamicString[] _references;
        public DynamicContentGenerator(DynamicContent dynamicContent) 
        {
            _rawContent = dynamicContent.RawContent;
            _references = dynamicContent.Reference;
        }

        public override string Generate()
        {
            string output = _rawContent;
            for (int i = 0; i < _references.Length; i++)
            {

                var reference = _references[i];

                string toReplace = $"@{i}";
                string replaceWith = InjectedObjectService.GetStringValueUsingDynamicString(reference);
                output = output.Replace(toReplace, replaceWith);
            }

            return output;
        }
    }
}
