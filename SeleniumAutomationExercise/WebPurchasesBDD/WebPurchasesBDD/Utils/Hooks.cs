using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectLearn.utils;

namespace DomainWebsiteBDD.Utils
{
    [Binding]
    public sealed class Hooks
    {
        private IWebDriver? driver;


        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Running before test run...");
            ExtentReport.ExtentReportInit();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Console.WriteLine("Running before feature...");
            ExtentReport._feature = ExtentReport._extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario(ScenarioContext scenarioContext)
        {
            _ = new WebDriverManager();
            driver = WebDriverManager.instanceDriver();
            ExtentReport._scenario = ExtentReport._feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("Running after test run...");
            ExtentReport.ExtentReportTearDown();
        }

        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {
            Console.WriteLine("Running after step....");
            string stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepName = scenarioContext.StepContext.StepInfo.Text;

            var driver = WebDriverManager.instanceDriver();

            //When scenario passed
            if (scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                {
                    ExtentReport._scenario.CreateNode<Given>(stepName);
                }
                else if (stepType == "When")
                {
                    ExtentReport._scenario.CreateNode<When>(stepName);
                }
                else if (stepType == "But")
                {
                    ExtentReport._scenario.CreateNode<But>(stepName);
                }
                else if (stepType == "Then")
                {
                    ExtentReport._scenario.CreateNode<Then>(stepName).Pass("Exitoso",
                        MediaEntityBuilder.CreateScreenCaptureFromPath(ExtentReport.addScreenshot(driver, scenarioContext)).Build());
                }
                else if (stepType == "And")
                {
                    ExtentReport._scenario.CreateNode<And>(stepName);
                }
            }

            //When scenario fails
            if (scenarioContext.TestError != null)
            {

                if (stepType == "Given")
                {
                    ExtentReport._scenario.CreateNode<Given>(stepName).Fail(scenarioContext.TestError.Message,
                        MediaEntityBuilder.CreateScreenCaptureFromPath(ExtentReport.addScreenshot(driver, scenarioContext)).Build());
                }
                else if (stepType == "When")
                {
                    ExtentReport._scenario.CreateNode<When>(stepName).Fail(scenarioContext.TestError.Message,
                        MediaEntityBuilder.CreateScreenCaptureFromPath(ExtentReport.addScreenshot(driver, scenarioContext)).Build());
                }
                else if (stepType == "Then")
                {
                    ExtentReport._scenario.CreateNode<Then>(stepName).Fail(scenarioContext.TestError.Message,
                        MediaEntityBuilder.CreateScreenCaptureFromPath(ExtentReport.addScreenshot(driver, scenarioContext)).Build());
                }
                else if (stepType == "And")
                {
                    ExtentReport._scenario.CreateNode<And>(stepName).Fail(scenarioContext.TestError.Message,
                    MediaEntityBuilder.CreateScreenCaptureFromPath(ExtentReport.addScreenshot(driver, scenarioContext)).Build());
                 }
                else if (stepType == "But")
                {
                    ExtentReport._scenario.CreateNode<But>(stepName).Fail(scenarioContext.TestError.Message,
                    MediaEntityBuilder.CreateScreenCaptureFromPath(ExtentReport.addScreenshot(driver, scenarioContext)).Build());
                }
            }
        }
    }
}