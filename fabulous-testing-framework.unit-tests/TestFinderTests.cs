using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace fabulous_testing_framework.unit_tests
{
    [TestFixture]
    public class TestFinderTests
    {
        [Test]
        public void Return_classes_from_project_with_test_class_attribute()
        {
            var assembly = Assembly.LoadFile(@"C:\temp\fabulous-testing-framework\fabulous-testing-framework.unit-tests\bin\Debug\project-being-tested.dll");

            var classes = GetClassesWithFabulousTestClassAttribute(assembly);

            Assert.That(classes.Any());
        }

        private IEnumerable<Type> GetClassesWithFabulousTestClassAttribute(Assembly assembly)
        {
            return assembly
                .GetTypes()
                .Where(type => type.GetCustomAttributes(typeof(FabulousTestClass), true)
                .Any());
        }
    }
}
