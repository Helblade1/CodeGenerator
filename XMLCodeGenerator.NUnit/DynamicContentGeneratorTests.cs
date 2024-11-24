using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLCodeGenerator.Exceptions;
using XMLCodeGenerator.Generators.Concrete;
using XMLCodeGenerator.Schemas.Pocos.Version1;
using XMLCodeGenerator.Services;

namespace XMLCodeGenerator.NUnit
{
    public class DynamicContentGeneratorTests
    {
        private class TestClass
        {
            public string TestProperty => "testValue";
        }

        private class TestClass2
        {
            public string TestProperty2 => "testValue2";
        }

        private DynamicString[] _references;

        [SetUp]
        public void SetUp()
        {
            InjectedObjectService.ClearObjects();
            InjectedObjectService.AddObject(new TestClass());

            _references = new DynamicString[] { new DynamicString() { InjectedObjectIndex = 0, PropertyName = "TestProperty" } };
        }

        [Test]
        public void DynamicContentGeneratorSingleObject_Succeeds()
        {
            string rawContent = "Test@0";
            var dynamicContent = new DynamicContent() { RawContent = rawContent, Reference = _references };

            var generator = new DynamicContentGenerator(dynamicContent);

            Assert.That(generator.Generate(), Is.EqualTo("TesttestValue"));
        }

        [Test]
        public void DynamicContentGeneratorMultipleObject_Succeeds()
        {
            InjectedObjectService.AddObject(new TestClass2());

            string rawContent = "Test@0@1";
            var tempList = _references.ToList();
            tempList.Add(new DynamicString() { InjectedObjectIndex = 1, PropertyName = "TestProperty2"});
            var dynamicContent = new DynamicContent() { RawContent = rawContent, Reference = tempList.ToArray() };

            var generator = new DynamicContentGenerator(dynamicContent);

            Assert.That(generator.Generate(), Is.EqualTo("TesttestValuetestValue2"));
        }
    }
}
