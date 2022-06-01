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
    public static class DRSFeedbackTest
    {
        private static double maxWaitSeconds;
        private static object byLocatorType;
        private static IWebElement element;

        public static void DRSFeedback(IWebDriver driver, ExtentReports extent)
        {
            var test = extent.CreateTest("Royal Navy - DRS Feedback Test").Info("Test Started");

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
            // Clicking on the DRS Feedback button
            driver.FindElement(By.CssSelector("li:nth-child(5) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the DRS Feedback button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Selecting the second DRS Feedback
            driver.FindElement(By.CssSelector("tr:nth-child(2) > td:nth-child(3)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the second DRS Feedback");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Selecting the status ID
            var dropdown = driver.FindElement(By.Id("SelectedStatus_ID"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("DRS - Commonwealth On Hold");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the status ID");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Entering the DRS URN
            driver.FindElement(By.Id("TafmisUrn")).Click();
            driver.FindElement(By.Id("TafmisUrn")).SendKeys("a12345678");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the DRS URN");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Clicking the DRS Role ID
            driver.FindElement(By.Id("DrsRole_ID")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the DRS Role ID");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Selecting Allocate to AFCO
            dropdown = driver.FindElement(By.Id("AllocatedAfco_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Dundee");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Allocate to AFCO");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Entering the notes
            driver.FindElement(By.Id("Notes")).Click();
            driver.FindElement(By.Id("Notes")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the notes");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Clicking the update button
            driver.FindElement(By.CssSelector("form > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the update button");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Clicking the search button
            driver.FindElement(By.LinkText("Search")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Entering the email address
            driver.FindElement(By.Id("EmailAddress")).SendKeys("123@gmail.com");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the email address");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Entering the Lastname
            driver.FindElement(By.Id("Lastname")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Lastname");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Clicking the search button
            driver.FindElement(By.CssSelector("form > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Clicking the Home button
            driver.FindElement(By.LinkText("Home")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the home button");
            test.Log(Status.Pass, "Test 14 Passed");
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
