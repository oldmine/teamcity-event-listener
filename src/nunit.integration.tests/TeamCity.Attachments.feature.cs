// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace nunit.integration.tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TeamCity attachments")]
    public partial class TeamCityAttachmentsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TeamCity.Attachments.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "TeamCity attachments", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
    testRunner.Given("NUnit path is ..\\nunit\\", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User can attach artifacts and test metadata to test")]
        [NUnit.Framework.CategoryAttribute("3.9")]
        [NUnit.Framework.CategoryAttribute("teamcity")]
        [NUnit.Framework.TestCaseAttribute("2018.2 (build SNAPSHOT)", null)]
        [NUnit.Framework.TestCaseAttribute("2018.2", null)]
        [NUnit.Framework.TestCaseAttribute("2019", null)]
        [NUnit.Framework.TestCaseAttribute("2019.2", null)]
        public virtual void UserCanAttachArtifactsAndTestMetadataToTest(string teamCityVersion, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "3.9",
                    "teamcity"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User can attach artifacts and test metadata to test", null, @__tags);
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 9
    testRunner.Given("Framework version is Version45", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
    testRunner.And("I added SuccessfulWithAttachedFiles method as SuccessfulTest to the class Foo.Tes" +
                    "ts.UnitTests1 for foo.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
    testRunner.And("I created the folder mocks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
    testRunner.And("I added NUnit framework references to foo.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
    testRunner.And("I copied NUnit framework references to folder mocks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
    testRunner.And("I compiled the assembly foo.tests to file mocks\\foo.tests.dll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
    testRunner.And("I added the assembly mocks\\foo.tests.dll to the list of testing assemblies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
    testRunner.And("I want to use CmdArguments type of TeamCity integration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
    testRunner.And(string.Format("I added the environment variable TEAMCITY_VERSION as {0}", teamCityVersion), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
    testRunner.And("I appended the string MyImage to file Data\\MyImage.jpg", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
    testRunner.And("I appended the string MyImage2 to file Data\\MyImage2.gif", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
    testRunner.And("I appended the string Class to file Data\\Class.cs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
    testRunner.And("I appended the string report.txt to file Data\\report.txt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
    testRunner.When("I run NUnit console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
    testRunner.Then("the exit code should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
    testRunner.And("the output should contain correct set of TeamCity service messages", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "",
                        ".",
                        "name",
                        "testName",
                        "type",
                        "value",
                        "name",
                        "flowId"});
            table23.AddRow(new string[] {
                        "flowStarted",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table23.AddRow(new string[] {
                        "testSuiteStarted",
                        "",
                        "foo.tests.dll",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table23.AddRow(new string[] {
                        "flowStarted",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table23.AddRow(new string[] {
                        "testStarted",
                        "",
                        "Foo.Tests.UnitTests1.SuccessfulTest",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table23.AddRow(new string[] {
                        "publishArtifacts",
                        ".+MyImage.jpg\\s=>\\s.+",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table23.AddRow(new string[] {
                        "testMetadata",
                        "",
                        "",
                        "Foo.Tests.UnitTests1.SuccessfulTest",
                        "image",
                        ".+MyImage.jpg",
                        "My Image",
                        ".+"});
            table23.AddRow(new string[] {
                        "publishArtifacts",
                        ".+MyImage2.gif\\s=>\\s.+",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table23.AddRow(new string[] {
                        "testMetadata",
                        "",
                        "",
                        "Foo.Tests.UnitTests1.SuccessfulTest",
                        "image",
                        ".+MyImage2.gif",
                        "",
                        ".+"});
            table23.AddRow(new string[] {
                        "publishArtifacts",
                        ".+Class.cs\\s=>\\s.+",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table23.AddRow(new string[] {
                        "testMetadata",
                        "",
                        "",
                        "Foo.Tests.UnitTests1.SuccessfulTest",
                        "artifact",
                        ".+Class.cs",
                        "source",
                        ".+"});
            table23.AddRow(new string[] {
                        "publishArtifacts",
                        ".+report.txt\\s=>\\s.+",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table23.AddRow(new string[] {
                        "testMetadata",
                        "",
                        "",
                        "Foo.Tests.UnitTests1.SuccessfulTest",
                        "artifact",
                        ".+report.txt",
                        "",
                        ".+"});
            table23.AddRow(new string[] {
                        "testFinished",
                        "",
                        "Foo.Tests.UnitTests1.SuccessfulTest",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table23.AddRow(new string[] {
                        "flowFinished",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table23.AddRow(new string[] {
                        "testSuiteFinished",
                        "",
                        "foo.tests.dll",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table23.AddRow(new string[] {
                        "flowFinished",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
#line 25
    testRunner.And("the output should contain TeamCity service messages:", ((string)(null)), table23, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User can attach artifacts and test metadata using custom path")]
        [NUnit.Framework.CategoryAttribute("3.9")]
        [NUnit.Framework.CategoryAttribute("teamcity")]
        public virtual void UserCanAttachArtifactsAndTestMetadataUsingCustomPath()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User can attach artifacts and test metadata using custom path", null, new string[] {
                        "3.9",
                        "teamcity"});
#line 52
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 53
    testRunner.Given("Framework version is Version45", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 54
    testRunner.And("I added SuccessfulWithAttachedFileToCustomPath method as SuccessfulTest to the cl" +
                    "ass Foo.Tests.UnitTests1 for foo.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
    testRunner.And("I created the folder mocks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
    testRunner.And("I added NUnit framework references to foo.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
    testRunner.And("I copied NUnit framework references to folder mocks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
    testRunner.And("I compiled the assembly foo.tests to file mocks\\foo.tests.dll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
    testRunner.And("I added the assembly mocks\\foo.tests.dll to the list of testing assemblies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
    testRunner.And("I want to use CmdArguments type of TeamCity integration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
    testRunner.And("I added the environment variable TEAMCITY_VERSION as 2018.2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
    testRunner.And("I appended the string MyImage to file Data\\MyImage.jpg", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
    testRunner.And("I appended the string report.txt to file Data\\report.txt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
    testRunner.When("I run NUnit console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
    testRunner.Then("the exit code should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
    testRunner.And("the output should contain correct set of TeamCity service messages", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "",
                        ".",
                        "name",
                        "testName",
                        "type",
                        "value",
                        "name",
                        "flowId"});
            table24.AddRow(new string[] {
                        "flowStarted",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table24.AddRow(new string[] {
                        "testSuiteStarted",
                        "",
                        "foo.tests.dll",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table24.AddRow(new string[] {
                        "flowStarted",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table24.AddRow(new string[] {
                        "testStarted",
                        "",
                        "Foo.Tests.UnitTests1.SuccessfulTest",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table24.AddRow(new string[] {
                        "publishArtifacts",
                        ".+MyImage.jpg => images",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table24.AddRow(new string[] {
                        "testMetadata",
                        "",
                        "",
                        "Foo.Tests.UnitTests1.SuccessfulTest",
                        "image",
                        "images/MyImage.jpg",
                        "My Image",
                        ".+"});
            table24.AddRow(new string[] {
                        "publishArtifacts",
                        ".+report.txt => reports",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table24.AddRow(new string[] {
                        "testMetadata",
                        "",
                        "",
                        "Foo.Tests.UnitTests1.SuccessfulTest",
                        "artifact",
                        "reports/report.txt",
                        "",
                        ".+"});
            table24.AddRow(new string[] {
                        "testFinished",
                        "",
                        "Foo.Tests.UnitTests1.SuccessfulTest",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table24.AddRow(new string[] {
                        "flowFinished",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table24.AddRow(new string[] {
                        "testSuiteFinished",
                        "",
                        "foo.tests.dll",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table24.AddRow(new string[] {
                        "flowFinished",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
#line 67
    testRunner.And("the output should contain TeamCity service messages:", ((string)(null)), table24, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Attachments should be suppressed")]
        [NUnit.Framework.CategoryAttribute("3.9")]
        [NUnit.Framework.CategoryAttribute("teamcity")]
        [NUnit.Framework.TestCaseAttribute("10.2", "false", "true", null)]
        [NUnit.Framework.TestCaseAttribute("2018.1 (build SNAPSHOT)", "false", "true", null)]
        [NUnit.Framework.TestCaseAttribute("2018.2 (build SNAPSHOT)", "false", "true", null)]
        [NUnit.Framework.TestCaseAttribute("2018.2", "false", "true", null)]
        [NUnit.Framework.TestCaseAttribute("2019", "false", "true", null)]
        [NUnit.Framework.TestCaseAttribute("2018.2", "False", "true", null)]
        [NUnit.Framework.TestCaseAttribute("2018.2", "FALSE", "true", null)]
        [NUnit.Framework.TestCaseAttribute("10.2", "true", "false", null)]
        [NUnit.Framework.TestCaseAttribute("2018.1 (build SNAPSHOT)", "true", "false", null)]
        [NUnit.Framework.TestCaseAttribute("2018.2 (build SNAPSHOT)", "true", "false", null)]
        [NUnit.Framework.TestCaseAttribute("2018.2", "true", "false", null)]
        [NUnit.Framework.TestCaseAttribute("2019", "true", "false", null)]
        [NUnit.Framework.TestCaseAttribute("2018.2", "true", "False", null)]
        [NUnit.Framework.TestCaseAttribute("2018.2", "true", "FALSE", null)]
        [NUnit.Framework.TestCaseAttribute("10.2", "true", "true", null)]
        [NUnit.Framework.TestCaseAttribute("10", "true", "true", null)]
        [NUnit.Framework.TestCaseAttribute("2018.1 (build SNAPSHOT)", "true", "true", null)]
        [NUnit.Framework.TestCaseAttribute("2018.1 RC", "true", "true", null)]
        [NUnit.Framework.TestCaseAttribute("2018.1", "true", "true", null)]
        public virtual void AttachmentsShouldBeSuppressed(string teamCityVersion, string teamcityloggerExperimental, string teamcityDotnetTestMetadataEnable, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "3.9",
                    "teamcity"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Attachments should be suppressed", null, @__tags);
#line 84
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 85
    testRunner.Given("Framework version is Version45", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 86
    testRunner.And("I added SuccessfulWithAttachedFiles method as SuccessfulTest to the class Foo.Tes" +
                    "ts.UnitTests1 for foo.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
    testRunner.And("I created the folder mocks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
    testRunner.And("I added NUnit framework references to foo.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
    testRunner.And("I copied NUnit framework references to folder mocks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
    testRunner.And("I compiled the assembly foo.tests to file mocks\\foo.tests.dll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
    testRunner.And("I added the assembly mocks\\foo.tests.dll to the list of testing assemblies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
    testRunner.And("I want to use CmdArguments type of TeamCity integration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
    testRunner.And(string.Format("I added the environment variable TEAMCITY_LOGGER_ALLOW_EXPERIMENTAL as {0}", teamcityloggerExperimental), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
    testRunner.And(string.Format("I added the environment variable TEAMCITY_DOTNET_TEST_METADATA_ENABLE as {0}", teamcityDotnetTestMetadataEnable), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
    testRunner.And(string.Format("I added the environment variable TEAMCITY_VERSION as {0}", teamCityVersion), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
    testRunner.And("I appended the string MyImage to file Data\\MyImage.jpg", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
    testRunner.And("I appended the string MyImage2 to file Data\\MyImage2.gif", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
    testRunner.And("I appended the string Class to file Data\\Class.cs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
    testRunner.And("I appended the string report.txt to file Data\\report.txt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
    testRunner.When("I run NUnit console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
    testRunner.Then("the exit code should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
    testRunner.And("the output should contain correct set of TeamCity service messages", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "",
                        ".",
                        "name",
                        "testName",
                        "type",
                        "value",
                        "name",
                        "flowId"});
            table25.AddRow(new string[] {
                        "flowStarted",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table25.AddRow(new string[] {
                        "testSuiteStarted",
                        "",
                        "foo.tests.dll",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table25.AddRow(new string[] {
                        "flowStarted",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table25.AddRow(new string[] {
                        "testStarted",
                        "",
                        "Foo.Tests.UnitTests1.SuccessfulTest",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table25.AddRow(new string[] {
                        "testFinished",
                        "",
                        "Foo.Tests.UnitTests1.SuccessfulTest",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table25.AddRow(new string[] {
                        "flowFinished",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table25.AddRow(new string[] {
                        "testSuiteFinished",
                        "",
                        "foo.tests.dll",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
            table25.AddRow(new string[] {
                        "flowFinished",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ".+"});
#line 103
    testRunner.And("the output should contain TeamCity service messages:", ((string)(null)), table25, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
