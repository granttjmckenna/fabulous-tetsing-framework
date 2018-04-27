using System;

namespace fabulous_testing_framework
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class TestAttributes : Attribute
    {
        
    }

    public class FabulousTestClass : TestAttributes
    {
        
    }

    public class FabulousTestMethod : TestAttributes
    {
        
    }
}
