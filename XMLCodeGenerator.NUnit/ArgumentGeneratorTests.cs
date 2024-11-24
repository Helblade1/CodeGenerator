using XMLCodeGenerator.Generators.Concrete;
using XMLCodeGenerator.Schemas.Pocos.Version1;

namespace XMLCodeGenerator.NUnit
{
    public class ArgumentGeneratorTests
    {
        [TestCase("string", "yourMom", "string yourMom") ]
        public void SingleArgument_GeneratesCorrectly(string argumentType, string argumentName, string expected)
        {
            var argGen = new ArgumentGenerator(new Argument[] { new Argument() { ArgumentType = argumentType, Name = argumentName } });

            Assert.That(argGen.Generate(), Is.EqualTo(expected));
        }
    }
}