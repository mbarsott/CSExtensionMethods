using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Samples.Demo3;
using Sixeyed.Extensions.Samples.Demo3.Impl;
using Sixeyed.Extensions.Samples.Demo5;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sixeyed.Extensions.Tests.Demo5
{
    [TestClass]
    public class ObjectExtensionsTests
    {
        [TestMethod]
        public void ToJsonStringTests()
        {
            var obj = int.MaxValue;
            Debug.WriteLine("obj1 - " + obj.ToJsonString());

            var obj2 = new DateTime(2000, 12, 31);
            Debug.WriteLine("obj2 - " + obj2.ToJsonString());

            var obj3 = new ReferenceDataItem { Code = "xyz", Description = "123" };
            Debug.WriteLine("obj3 - " + obj3.ToJsonString());

            IEnumerable<IReferenceDataSource> obj4 = new List<IReferenceDataSource> { new SqlReferenceDataSource() };
            Debug.WriteLine("obj4 - " + obj4.ToJsonString());
        }

        [TestMethod]
        public void ToJsonTypeDescriptionTests()
        {
            var obj = int.MaxValue;
            Debug.WriteLine("obj1 - " + obj.GetJsonTypeDescription());

            var obj2 = new DateTime(2000, 12, 31);
            Debug.WriteLine("obj2 - " + obj2.GetJsonTypeDescription());

            var obj3 = new ReferenceDataItem { Code = "xyz", Description = "123" };
            Debug.WriteLine("obj3 - " + obj3.GetJsonTypeDescription());

            IEnumerable<IReferenceDataSource> obj4 = new List<IReferenceDataSource> { new SqlReferenceDataSource() };
            Debug.WriteLine("obj4 - " + obj4.GetJsonTypeDescription());
        }
    }
}