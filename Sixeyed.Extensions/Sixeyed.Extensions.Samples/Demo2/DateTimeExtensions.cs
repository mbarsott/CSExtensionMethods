using System.Xml;

namespace System
{
    public static class DateTimeExtensions
    {
        //        public static string ToXmlDateTime(this DateTime dateTime)
        //        {
        //            //            return XmlConvert.ToString(dateTime, XmlDateTimeSerializationMode.Utc);
        //            return dateTime.ToXmlDateTime(XmlDateTimeSerializationMode.Utc);
        //        }

        public static string ToXmlDateTime(this DateTime dateTime, XmlDateTimeSerializationMode mode = XmlDateTimeSerializationMode.Utc)
        {
            return XmlConvert.ToString(dateTime, mode);
        }
    }
}
