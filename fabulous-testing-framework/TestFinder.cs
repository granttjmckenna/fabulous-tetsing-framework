using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace fabulous_testing_framework
{
    public class TestFinder
    {
        public IEnumerable<MethodInfo> GetMethodsWithFabulousTestMethodAttribute(Type testClass)
        {
            return testClass
                .GetMethods()
                .Where(m => m.GetCustomAttributes(typeof(FabulousTestMethod), false).Length > 0)
                .ToArray();
        }

        public IEnumerable<Type> GetClassesWithFabulousTestClassAttribute(Assembly assembly)
        {
            return assembly
                .GetTypes()
                .Where(type => type.GetCustomAttributes(typeof(FabulousTestClass), true)
                                   .Length > 0);
        }
    }
}
