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
using NUnit.Framework;
using System.Runtime.Remoting.Contexts;
using SeleniumExtras.WaitHelpers;

namespace Royal_Navy.Test_Cases
{
    public static class CareersAdminTest
    {
        private static double maxWaitSeconds;
        private static object byLocatorType;
        private static IWebElement element;

        public static void CareersAdmin(IWebDriver driver, ExtentReports extent)
        {
            var test = extent.CreateTest("Royal Navy - Careers Admin Test").Info("Test Started");

            // Test 1
            // Openning the tp oxygen Royal Navy and setting the window size
            driver.Navigate().GoToUrl("https://tpoxygen-rn-recruitment-qa/");
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Royal Navy QA Oxygon Launched");
            test.Log(Status.Pass, "Test 1 Passed");
            extent.Flush();

            // Test 2
            // Clicking on the Careers Admin button
            driver.FindElement(By.CssSelector("li:nth-child(8) span")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the DRS Feedback button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Clicking the Create New Role Button
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Create New Role"))).Click();


            // driver.FindElement(By.LinkText("Create New Role")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create New Role Button");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Entering the role
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("E3Role"))).Click();

            driver.FindElement(By.Id("E3Role")).Clear();
            driver.FindElement(By.Id("E3Role")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the role");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Entering the provider id
            driver.FindElement(By.Id("ProviderId")).Clear();
            driver.FindElement(By.Id("ProviderId")).SendKeys("12");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the provider id");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Entering the Website URL
            driver.FindElement(By.Id("WebsiteURL")).Clear();
            driver.FindElement(By.Id("WebsiteURL")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Website URL");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Entering the Description
            driver.FindElement(By.Id("Description")).Clear();
            driver.FindElement(By.Id("Description")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Description");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Selecting the Career Service ID
            var dropdown = driver.FindElement(By.Id("CareerService_ID"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Royal Navy");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Career Service ID");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Selecting the Career Job Level ID
            dropdown = driver.FindElement(By.Id("CareerJobLevelId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Officer");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Career Job Level ID");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Selecting the Career Area ID
            dropdown = driver.FindElement(By.Id("CareerArea_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Logistics");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Career Area ID");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Selecting the Career Field ID
            dropdown = driver.FindElement(By.Id("CareerFieldId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Royal Navy");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Career Field ID");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Selecting the Career Journey ID
            dropdown = driver.FindElement(By.Id("CareerJourney_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Inspire3Chef");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Career Journey ID");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Selecting the Career Minimum Height Id
            dropdown = driver.FindElement(By.Id("CareerMinimumHeightId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("157 cm");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Career Minimum Height Id");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Entering the Degree Qualifications
            driver.FindElement(By.Id("DegreeQualifications")).Click();
            driver.FindElement(By.Id("DegreeQualifications")).SendKeys("degree");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Degree Qualifications");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Entering the Professional Other Qualifications
            driver.FindElement(By.Id("ProfessionalOtherQualifications")).Click();
            driver.FindElement(By.Id("ProfessionalOtherQualifications")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Professional Other Qualifications");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            // Entering the Notes
            driver.FindElement(By.Id("Notes")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Notes");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Selecting is Active
            driver.FindElement(By.Id("isActive")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting is Active");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Clicking the Create Button
            // driver.FindElement(By.CssSelector("fieldset")).Click();
            //driver.FindElement(By.CssSelector("input:nth-child(31)")).Click();
            
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input:nth-child(31)"))).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create Button");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            driver.FindElement(By.Id("modal-bg")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);

            // Test 20
            // Clicking the Careers Admin Button
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Careers Admin"))).Click();

            // driver.FindElement(By.LinkText("Careers Admin")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Careers Admin Button");
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            // Test 21
            // Selecting Service ID
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("SelectedService_ID"))).Click();

            dropdown = driver.FindElement(By.Id("SelectedService_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Royal Navy");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Service ID");
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();

            // Test 22
            // Clicking the Filter Roles Button
            driver.FindElement(By.CssSelector("input:nth-child(7)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Filter Roles Button");
            test.Log(Status.Pass, "Test 22 Passed");
            extent.Flush();

            // Test 23
            driver.FindElement(By.Id("modal-bg")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);

            // Test 24
            // Clicking the edit button
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Edit"))).Click();

            // driver.FindElement(By.CssSelector("tr:nth-child(2) a")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the edit button");
            test.Log(Status.Pass, "Test 24 Passed");
            extent.Flush();

            // Test 25
            driver.FindElement(By.Id("modal-bg")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);

            // Test 26
            // Clicking the save button
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input:nth-child(32)"))).Click();

           //  driver.FindElement(By.CssSelector("input:nth-child(32)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the save button");
            test.Log(Status.Pass, "Test 26 Passed");
            extent.Flush();

            // Test 2
            driver.FindElement(By.Id("modal-bg")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);

            // Test 27
            // Clicking the Career Services button
            // wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Career Services"))).Click();

            driver.FindElement(By.LinkText("Career Services")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Career Services button");
            test.Log(Status.Pass, "Test 27 Passed");
            extent.Flush();

            // Test 28
            // Clicking the Careers Admin button
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Careers Admin"))).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Careers Admin button");
            test.Log(Status.Pass, "Test 28 Passed");
            extent.Flush();

            // Test 29
            driver.FindElement(By.Id("modal-bg")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);

            // Test 30
            // Clicking the Careers Journeys button
            // wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Careers Journeys"))).Click();

            driver.FindElement(By.LinkText("Career Journeys")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Careers Journeys button");
            test.Log(Status.Pass, "Test 30 Passed");
            extent.Flush();

            // Test 31
            // Clicking the Careers Admin button
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Careers Admin"))).Click();

           // driver.FindElement(By.LinkText("Careers Admin")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Careers Admin button");
            test.Log(Status.Pass, "Test 31 Passed");
            extent.Flush();

            // Test 32
            // Clicking the Export Careers button
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Export Careers"))).Click();

            // driver.FindElement(By.LinkText("Export Careers")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Export Careers button");
            test.Log(Status.Pass, "Test 32 Passed");
            extent.Flush();

            // Test 33
            driver.FindElement(By.Id("modal-bg")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);

            // Test 34
            // Selecting the Service ID
            dropdown = driver.FindElement(By.Id("SelectedService_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Royal Navy");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Service ID");
            test.Log(Status.Pass, "Test 34 Passed");
            extent.Flush();

            // Test 35
            // Selecting the Career Area ID
            dropdown = driver.FindElement(By.Id("SelectedCareerArea_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Engineering");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Career Area ID");
            test.Log(Status.Pass, "Test 35 Passed");
            extent.Flush();


            // Test 36
            // Clicking the filter roles button
            driver.FindElement(By.CssSelector("input:nth-child(7)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the filter roles button");
            test.Log(Status.Pass, "Test 36 Passed");
            extent.Flush();

            // Test 37
            driver.FindElement(By.Id("modal-bg")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);

            // Test 38
            // Clicking the edit button
            driver.FindElement(By.CssSelector("tr:nth-child(2) a")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the edit roles button");
            test.Log(Status.Pass, "Test 38 Passed");
            extent.Flush();

            // Test 39
            // Clicking the update button
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input:nth-child(32)"))).Click();

            // driver.FindElement(By.CssSelector("input:nth-child(32)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the update button");
            test.Log(Status.Pass, "Test 39 Passed");
            extent.Flush();

            // Test 40
            driver.FindElement(By.Id("modal-bg")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);

            // Test 41
            // Clicking the home button
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Home"))).Click();

            // driver.FindElement(By.LinkText("Home")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the home button");
            test.Log(Status.Pass, "Test 41 Passed");
            extent.Flush();

            // quit driver after all tests completed
            driver.Quit();

        }


        // Creating a public static method for the radio buttons and creating a for each loop to get the attribute ID for the radio buttons
        public static void SelectRadioButtonWithIdStarting(string Id, IWebDriver driver)
        {
            var elements = driver.FindElements(By.XPath("//input[@type='radio']"));
            var isClicked = false;

            foreach (var item in elements)
            {
                if (item.Displayed && item.Enabled && isClicked == false)
                {
                    var radio = item.GetAttribute("id");
                    if (radio.StartsWith(Id))
                    {
                        item.Click();
                        isClicked = true;
                    }
                }
            }
            NUnit.Framework.Assert.IsTrue(isClicked);
        }
    }
}
