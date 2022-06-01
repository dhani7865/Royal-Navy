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
    public static class NextTaskTest
    {
        private static double maxWaitSeconds;
        private static object byLocatorType;
        private static IWebElement element;

        public static void NextTask(IWebDriver driver, ExtentReports extent)
        {
            var test = extent.CreateTest("Royal Navy - Next Task Test").Info("Test Started");

            // Test 1
            // Openning the tp oxygen Royal Navy and setting the window size
            driver.Navigate().GoToUrl("https://tpoxygen-rn-recruitment-qa/");
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Royal Navy QA Oxygon Launched");
            test.Log(Status.Pass, "Test 1 Passed");
            extent.Flush();

            // Test 2
            // Clicking on the Next Task button
            driver.FindElement(By.CssSelector("li:nth-child(3) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the next task button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Selecting the StatusID
            driver.FindElement(By.CssSelector("input:nth-child(8)")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the StatusID");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Clicking the Contact Answered button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(9) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Contact Answered button");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Selecting the call reason
            driver.FindElement(By.Id("CallReasons_5__isSelected")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the call reason");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Selecting the media ID
            var dropdown = driver.FindElement(By.Id("SelectedMedia_ID"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Website");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the media ID");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Selecting the marketingCampaign_ID
            dropdown = driver.FindElement(By.Id("SelectedMarketingCampaign_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("RFA");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the marketingCampaign_ID");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Selecting the Outcome_ID
            dropdown = driver.FindElement(By.Id("SelectedOutcome_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Overseas DND (Did not dial)");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Outcome_ID");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Entering the notes
            driver.FindElement(By.Id("Notes")).Clear();
            driver.FindElement(By.Id("Notes")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the notes");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Clicking the finish button
            driver.FindElement(By.CssSelector(".cti")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the finish button");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Clicking the Next Task button
            driver.FindElement(By.CssSelector("li:nth-child(3) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Next Task button");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Clicking the No Answer button
            driver.FindElement(By.CssSelector(".narrowbtn:nth-child(7)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the No Answer button");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Selecting the date and time
            // driver.FindElement(By.Id("ScheduleDate")).SendKeys("15/03/2022");
            driver.FindElement(By.LinkText("25")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);

            driver.FindElement(By.Id("ScheduleTime")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the date and time");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Clicking the continue button
            driver.FindElement(By.CssSelector("input:nth-child(11)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Task 16
            // Clicking the Next Task button
            driver.FindElement(By.CssSelector("li:nth-child(3) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Next Task button");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Clicking the Contact Answered button
            driver.FindElement(By.CssSelector(".narrowbtn:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            // test.Log(Status.Info, "Clicking the Contact Answered button");
            test.Log(Status.Pass, "Test 17 Passed");
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
