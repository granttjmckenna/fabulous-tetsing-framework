using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace fabulous_testing_framework.unit_tests
{
    [TestFixture]
    public class TestFinderTests
    {
        private Assembly _assembly;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _assembly = Assembly.LoadFile(@"C:\temp\fabulous-testing-framework\fabulous-testing-framework.unit-tests\bin\Debug\project-being-tested.dll");
        }

        [Test]
        public void Return_classes_from_project_with_test_class_attribute()
        {
            var classes = new TestFinder().GetClassesWithFabulousTestClassAttribute(_assembly);

            Assert.That(classes.Any());
        }

        [Test]
        public void Return_methods_in_class_with_test_method_attribute()
        {
            var classes = new TestFinder().GetClassesWithFabulousTestClassAttribute(_assembly);

            var methods = new TestFinder().GetMethodsWithFabulousTestMethodAttribute(classes.First());

            Assert.That(methods.Any());
        }
    }
}
