using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Advanced.Demo2;

namespace Sixeyed.Extensions.Advanced.Tests.Demo2
{
    [TestClass]
    public class InternalClassesTests
    {
        [TestMethod]
        public void Class1()
        {
            var obj1 = new Class1();
            Assert.AreEqual("a", obj1.GetString1());
            Assert.AreEqual("A", obj1.GetStringUpper());
            Assert.AreEqual("", obj1.GetString3ToUpper());
            Assert.AreEqual("abc", obj1.GetString0());
            Assert.AreEqual("ABC", obj1.GetString0Upper());
        } 

        [TestMethod]
        public void Class2()
        {
            var obj2 = new Class1.Class2();
            Assert.AreEqual("b", obj2.GetString2());
            Assert.AreEqual("B", obj2.GetString2ToUpper());
            Assert.AreEqual("", obj2.GetString3ToUpper());
            Assert.AreEqual("xyz", obj2.GetString0());
            Assert.AreEqual("XYZ", obj2.GetString0Upper());
        } 

        [TestMethod]
        public void Class3()
        {
            var type3 = typeof(Class1.Class2).GetNestedType("Class3", BindingFlags.NonPublic);
            var methodInfo = type3.GetMethod("GetString3", BindingFlags.NonPublic | BindingFlags.Instance);
            var obj3 = Activator.CreateInstance(type3);
            Assert.AreEqual("c", methodInfo.Invoke(obj3, null));
            Assert.AreEqual("C", obj3.GetString3ToUpper());
        } 
    }
}
