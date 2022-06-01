using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using Xunit;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using Royal_Navy.Test_Cases;


namespace Royal_Navy
{
    public class Program
    {
        private static ExtentReports extent;
        private static object perform;


        // Start method for extent reports
        [OneTimeSetUp]
        public static void ExtentStart()
        {
            extent = new ExtentReports();

            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            string reportPath = projectPath + "TestReport\\Start Script Button Royal Navy Test Documentation - Passed - 24-05-2022.html";
            // string reportPath = projectPath + "TestReport\\Tasks Button Royal Navy Test Documentation - Passed - 21-03-2022.html";
            // string reportPath = projectPath + "TestReport\\Next Task Button Royal Navy Test Documentation - Passed - 21-03-2022.html";
            // string reportPath = projectPath + "TestReport\\Task Admin Button Royal Navy Test Documentation - Passed - 21-03-2022.html";
            // string reportPath = projectPath + "TestReport\\DRS Feedback Button Royal Navy Test Documentation - Passed - 21-03-2022.html";
            // string reportPath = projectPath + "TestReport\\Search Applications Button Royal Navy Test Documentation - Passed - 22-03-2022.html";
            // string reportPath = projectPath + "TestReport\\AFCO Manager Button Royal Navy Test Documentation - Passed - 28-03-2022.html";
            // string reportPath = projectPath + "TestReport\\Careers Admin Button Royal Navy Test Documentation - Passed - 23-03-2022.html";
            // string reportPath = projectPath + "TestReport\\Contact History Button Royal Navy Test Documentation - Passed - 23-03-2022.html";
            // string reportPath = projectPath + "TestReport\\Data Capture Button Royal Navy Test Documentation - Passed - 23-03-2022.html";
            // string reportPath = projectPath + "TestReport\\Reserve Sessions Button Royal Navy Test Documentation - Passed - 24-03-2022.html";
            // string reportPath = projectPath + "TestReport\\Data Export Button Royal Navy Test Documentation - Passed - 24-03-2022.html";
            // string reportPath = projectPath + "TestReport\\Fulfilment Button Royal Navy Test Documentation - Passed - 24-03-2022.html";
            // string reportPath = projectPath + "TestReport\\Bulk Emails Button Royal Navy Test Documentation - Passed - 24-03-2022.html";
            // string reportPath = projectPath + "TestReport\\Career Adviser Referrals Button Royal Navy Test Documentation - Passed - 28-03-2022.html";
            // string reportPath = projectPath + "TestReport\\Agent Alerts Button Royal Navy Test Documentation - Passed - 28-03-2022.html";
            // string reportPath = projectPath + "TestReport\\Commonwealth Utility Button Royal Navy Test Documentation - Passed - 28-03-2022.html";
            // string reportPath = projectPath + "TestReport\\Right to be forgotten Button Royal Navy Test Documentation - Passed - 28-03-2022.html";

            



            var htmlReporter = new ExtentV3HtmlReporter(reportPath);

            extent.AttachReporter(htmlReporter);

        }



        public void ExtentClose()
        {
            extent.Flush();
        }


        class OneTimeSetUpAttribute : Attribute
        {
        }


        [Fact]
        static void Main()
        {
            // Test
            // This is where everything is run
            IWebDriver driver = new ChromeDriver();


            ExtentStart();


            StartScriptTest.StartScript(driver, extent);
            // TasksTest.Tasks(driver, extent);
            // NextTaskTest.NextTask(driver, extent);
            // TaskAdminTest.TaskAdmin(driver, extent);
            // DRSFeedbackTest.DRSFeedback(driver, extent);
            // SearchApplicationsTest.SearchApplications(driver, extent);
            // AFCOManagerTest.AFCOManager(driver, extent);
            // CareersAdminTest.CareersAdmin(driver, extent);
            // ContactHistoryTest.ContactHistory(driver, extent);
            // DataCaptureTest.DataCapture(driver, extent);
            // ReserveSessionsTest.ReserveSessions(driver, extent);
            // DataExportTest.DataExport(driver, extent);
            // FulfilmentTest.Fulfilment(driver, extent);
            // BulkEmailsTest.BulkEmails(driver, extent);
            // CareerAdviserReferralsTest.CareerAdviserReferrals(driver, extent);
            // AgentAlertsTest.AgentAlerts(driver, extent);
            // CommonwealthUtilityTest.CommonwealthUtility(driver, extent);
            // RighttobeforgottenTest.Righttobeforgotten(driver, extent);

        }
    }
}

