using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLCodeGenerator.Exceptions;
using XMLCodeGenerator.Schemas.Pocos.Version1;
using XMLCodeGenerator.Services;

namespace XMLCodeGenerator.NUnit
{
    public class InjectedObjectServiceTests
    {
        private class TestClass
        {
            public string TestProperty => "testValue";
            public string NullProperty => null;
        }

        [SetUp]
        public void SetUp()
        {
            InjectedObjectService.ClearObjects();
        }

        [Test]
        public void GetStringValueFromObjectProperty_ThrowsInvalidObjectIndexException()
        {
            Assert.Throws<InvalidObjectIndexException>(() => InjectedObjectService.GetStringValueFromObjectProperty(0, "TestProperty"));
        }

        [Test]
        public void GetStringValueFromObjectProperty_ThrowsPropertyNotFoundException()
        {
            InjectedObjectService.AddObject(new TestClass());

            Assert.Throws<PropertyNotFoundException>(() => InjectedObjectService.GetStringValueFromObjectProperty(0, "NotAProperty"));
        }

        [Test]
        public void GetStringValueFromObjectProperty_ThrowsNullValueException()
        {
            InjectedObjectService.AddObject(new TestClass());

            Assert.Throws<NullValueException>(() => InjectedObjectService.GetStringValueFromObjectProperty(0, "NullProperty"));
        }

        [Test]
        public void GetStringValueFromObjectProperty_Succeeds()
        {
            InjectedObjectService.AddObject(new TestClass());

            Assert.That(InjectedObjectService.GetStringValueFromObjectProperty(0, "TestProperty"), Is.EqualTo("testValue"));
        }

        [Test]
        public void GetStringValueUsingDynamicString_Succeeds()
        {
            InjectedObjectService.AddObject(new TestClass());

            var dynamicString = new DynamicString() { InjectedObjectIndex = 0, PropertyName = "TestProperty" };

            Assert.That(InjectedObjectService.GetStringValueUsingDynamicString(dynamicString), Is.EqualTo("testValue"));
        }
    }
}
