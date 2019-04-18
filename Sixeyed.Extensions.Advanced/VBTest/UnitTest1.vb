Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Sixeyed.Extensions.Advanced.Demo3

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub ToXmlDateTime()
        Dim dateTime As New DateTime(2013, 10, 24)
        Assert.AreEqual("2013-10-24T00:00:00Z", dateTime.ToXmlDateTime())
    End Sub

    <TestMethod()> Public Sub FormatWith()
        Assert.AreEqual("Demo 4VB", "Demo {0}".FormatWith("4VB"))
    End Sub

End Class