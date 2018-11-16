﻿namespace NUnit.Engine.Listeners
{
    using System.Xml;

    public static class TestUtil
    {
        public static XmlNode CreateStartRun(int count)
        {
            return CreateMessage(string.Format("<start-run count='{0}'/>", count));
        }

        public static XmlNode CreateTestRun()
        {
            return CreateMessage("<test-run></test-run>");
        }

        public static XmlNode CreateStartSuite(string id, string parentId, string name)
        {
            return CreateMessage(string.Format("<start-suite id=\"{0}\" {1} name=\"{2}\" fullname=\"{2}\"/>", id, GetNamedAttr("parentId", parentId), name));
        }

        public static XmlNode CreateFinishSuite(string id, string parentId, string name)
        {
            return CreateMessage(string.Format("<test-suite id=\"{0}\" {1} name=\"{2}\" fullname=\"{2}\" runstate=\"Runnable\" testcasecount=\"3\" result=\"Failed\" duration=\"0.251125\" total=\"3\" passed=\"0\" failed=\"0\" inconclusive=\"0\" skipped=\"0\" asserts=\"0\"><failure><message><![CDATA[One or more child tests had errors]]></message><stack-trace><![CDATA[stack abc]]></stack-trace></failure></test-suite>", id, GetNamedAttr("parentId", parentId), name));
        }

        public static XmlNode CreateStartTest(string id, string parentId, string name)
        {
            return CreateMessage(string.Format("<start-test id=\"{0}\" {1} name=\"{2}\" fullname=\"{2}\"/>", id, GetNamedAttr("parentId", parentId), name));
        }

        public static XmlNode CreateTestCaseSuccessful(string id, string parentId, string name, string duration, string output)
        {
            return CreateMessage(string.Format("<test-case id=\"{0}\" {1} name=\"{2}\" fullname=\"{2}\" runstate=\"Runnable\" result=\"Passed\" duration=\"{3}\" asserts=\"0\">{4}</test-case>", id, GetNamedAttr("parentId", parentId), name, duration, GetNamedElement("output", output)));
        }

        public static XmlNode CreateTestCaseFailed(string id, string parentId, string name, string duration, string message, string stackTrace)
        {
            return CreateMessage(string.Format("<test-case id=\"{0}\" {1} name=\"{2}\" fullname=\"{2}\" runstate=\"Runnable\" result=\"Failed\" duration=\"{3}\" asserts=\"0\"><properties><property name=\"_CATEGORIES\" value=\"F\" /></properties><failure><message><![CDATA[{4}]]></message><stack-trace><![CDATA[{5}]]></stack-trace></failure></test-case>", id, GetNamedAttr("parentId", parentId), name, duration, message, stackTrace));
        }

        private static string GetNamedAttr(string attrName, string attrValue)
        {
            if (attrValue == null)
            {
                return string.Empty;
            }

            return string.Format("{0}=\"{1}\"", attrName, attrValue);
        }

        private static string GetNamedElement(string elementName, string elementValue)
        {
            if (elementValue == null)
            {
                return string.Empty;
            }

            return string.Format("<{0}>{1}</{0}>", elementName, elementValue);
        }

        private static XmlNode CreateMessage(string text)
        {
            var doc = new XmlDocument();
            doc.LoadXml(text);
            return doc.FirstChild;
        }
    }
}