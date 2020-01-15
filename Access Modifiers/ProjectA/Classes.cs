using System.Runtime.CompilerServices;

// [assembly: InternalsVisibleTo("ProjectB")]
namespace ProjectA
{
    #region Classes

    public class Public
    {
        public void PublicTest() { }
        private void PrivateTest() { }
        internal void InternalTest() { }
        protected void ProtectedTest() { }
        private protected void PrivateProtectedTest() { }
        protected internal void ProtectedInternalTest() { }
    }

    public sealed class Sealed { }

    class Private { }

    internal class Internal { }

    abstract class Abstract { }

    #endregion

    #region Tests

    class ClassesTest
    {
        public ClassesTest()
        {
            var publicTest = new Public();
            var privateTest = new Private();
            var internalTest = new Internal();
            // var abstractTest = new Abstract(); // Cannot create an instance of the abstract class or interface 'Abstract'
        }
    }

    // class SealedTest : Sealed { } // 'SealedTest': cannot derive from sealed type 'Sealed'

    class ModifierTest1
    {
        public ModifierTest1()
        {
            var publicTest = new Public();

            publicTest.PublicTest();
            publicTest.InternalTest();
            publicTest.ProtectedInternalTest();
            // publicTest.ProtectedTest(); // 'Public.ProtectedTest()' is inaccessible due to its protection level
            // publicTest.PrivateProtectedTest(); // 'Public.PrivateProtectedTest()' is inaccessible due to its protection leval
            // publicTest.PrivateTest(); // 'Public.PrivateTest()' is inaccessible due to its protection level
        }
    }

    class ModifierTest2 : Public
    {
        public ModifierTest2()
        {
            PublicTest();
            InternalTest();
            ProtectedTest();
            ProtectedInternalTest();
            PrivateProtectedTest();
            // PrivateTest(); // 'Public.PrivateTest()' is inaccessible due to its protection level
        }
    }

    #endregion
}

/*******************************************************/
// public:

// Access is not restricted.
/*******************************************************/
// protected:

// Access is limited to the containing class or types
// derived from the containing class.
/*******************************************************/
// internal:

// Access is limited to the current assembly.
/*******************************************************/
// protected internal:

// Access is limited to the current assembly or types
// derived from the containing class.
/*******************************************************/
// private:

// Access is limited to the containing type.
/*******************************************************/
// private protected:

// Access is limited to the containing class or types
// derived from the containing class within the current
// assembly.Available since C# 7.2.
/*******************************************************/
