using ProjectA;

namespace ProjectB
{
    class ClassesTest
    {
        public ClassesTest()
        {
            var publicTest = new Public();
            // var privateTest = new Private();
            // var abstractTest = new Abstract();
        }
    }

    class ModifierTest1
    {
        public ModifierTest1()
        {
            var publicTest = new Public();
            // publicTest.InternalTest();
            // publicTest.ProtectedInternalTest();
            // publicTest.ProtectedTest();
            // publicTest.PrivateProtectedTest();
            // publicTest.PrivateTest();
        }
    }

    class ModifierTest2 : Public
    {
        public ModifierTest2()
        {
            PublicTest();
            ProtectedTest();
            ProtectedInternalTest();
            // InternalTest();
            // PrivateProtectedTest();
            // PrivateTest();
        }
    }
}