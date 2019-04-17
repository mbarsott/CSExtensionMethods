using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sixeyed.Extensions.Advanced.Demo2
{
    internal static class InternalClassesExtension // cannot be public; cannot be more visible than extended class
    {

        internal static string GetStringUpper(this Class1 obj) // could be public
        {
            return obj.GetString1().ToUpper();
        }

        public static string GetString2ToUpper(this Class1.Class2 obj)
        {
            return obj.GetString2().ToUpper();
        }

        public static string GetString3ToUpper(this object obj)
        {
            var upper = string.Empty;
            var type3 = typeof(Class1.Class2).GetNestedType("Class3", BindingFlags.NonPublic);
            if (obj.GetType() == type3)
            {
                var methodInfo = type3.GetMethod("GetString3", BindingFlags.Instance | BindingFlags.NonPublic);
                var string3 = methodInfo.Invoke(obj, null) as string;
                upper = string3.ToUpper();
            }

            return upper;
        }

        public static string GetString0Upper(this Class0 obj)
        {
            return obj.GetString0().ToUpper();
        }
    }
}
