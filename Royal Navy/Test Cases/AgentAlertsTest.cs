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
    public static class AgentAlertsTest
    {
        private static double maxWaitSeconds;
        private static object byLocatorType;
        private static IWebElement element;

        public static void AgentAlerts(IWebDriver driver, ExtentReports extent)
        {
            var test = extent.CreateTest("Royal Navy - Agent Alerts Test").Info("Test Started");

            // Test 1
            // Openning the tp oxygen Royal Navy and setting the window size
            driver.Navigate().GoToUrl("https://tpoxygen-rn-recruitment-qa/");
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Royal Navy QA Oxygon Launched");
            test.Log(Status.Pass, "Test 1 Passed");
            extent.Flush();

            // Test 2
            // Clicking on the Agent Alerts button
            driver.FindElement(By.CssSelector("li:nth-child(16) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Agent Alerts button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Clicking the Create New Agent Alert Button
            driver.FindElement(By.LinkText("Create New Agent Alert")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create New Agent Alert Button");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Entering the Name
            driver.FindElement(By.Id("Name")).Clear();
            driver.FindElement(By.Id("Name")).SendKeys("tester");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Name");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Entering the Description
            driver.FindElement(By.Id("Description")).Clear();
            driver.FindElement(By.Id("Description")).SendKeys("tester");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Description");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Selecting the start date
            driver.FindElement(By.Id("StartDate")).Clear();
            driver.FindElement(By.Id("StartDate")).SendKeys("01/04/2022");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the start date");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Selecting the end date
            driver.FindElement(By.Id("EndDate")).Clear();
            driver.FindElement(By.Id("EndDate")).SendKeys("14/04/2022");


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the end date");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Selecting the TriggerEventStatusId
            var dropdown = driver.FindElement(By.Id("TriggerEventStatusId"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Active");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the TriggerEventStatusId");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Clicking the save button
            driver.FindElement(By.CssSelector("input:nth-child(6)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the save button");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Clicking off the toast message
            driver.FindElement(By.CssSelector(".toast > p")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking off the toast message");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Clicking the home button
            driver.FindElement(By.LinkText("Home")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the home button");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Clicking on the Agent Alerts button
            driver.FindElement(By.CssSelector("li:nth-child(16) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Agent Alerts button");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Entering the name
            driver.FindElement(By.Id("Name")).SendKeys("tester");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the name");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Clicking the filter button
            driver.FindElement(By.CssSelector(".isValid:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the filter button");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Clicking the edit button 
            driver.FindElement(By.CssSelector("tr:nth-child(2) a")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the edit button");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            // Selecting the start date
            driver.FindElement(By.Id("StartDate")).Click();
            driver.FindElement(By.CssSelector(".ui-datepicker-year")).Click();
            driver.FindElement(By.CssSelector(".ui-datepicker-month")).Click();
            driver.FindElement(By.LinkText("19")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the start date");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Selecting the end date
            driver.FindElement(By.Id("EndDate")).Click();
            driver.FindElement(By.CssSelector(".ui-datepicker-year")).Click();
            driver.FindElement(By.LinkText("28")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the end date");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Clicking the save button
            driver.FindElement(By.CssSelector("input:nth-child(8)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the save button");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Clicking the toast message
            driver.FindElement(By.CssSelector("h1:nth-child(2)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the toast message");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // Test 20
            // Clicking the home button
            driver.FindElement(By.LinkText("Home")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the home button");
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            // quit driver after all tests completed
            driver.Quit();

        }

        private static void ScrollintoView(IWebDriver driver, By bySelector)
        {
            var element = driver.FindElement(bySelector);
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
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
