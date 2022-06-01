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
    public static class CareerAdviserReferralsTest
    {
        private static double maxWaitSeconds;
        private static object byLocatorType;
        private static IWebElement element;

        public static void CareerAdviserReferrals(IWebDriver driver, ExtentReports extent)
        {
            var test = extent.CreateTest("Royal Navy - Career Adviser Referrals Test").Info("Test Started");

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
            // Clicking on the Career Adviser Referrals button
            driver.FindElement(By.CssSelector("li:nth-child(15) span")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Career Adviser Referrals button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Clicking the Filter Tasks button
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div:nth-child(7) > input"))).Click();

            // driver.FindElement(By.CssSelector("div:nth-child(7) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Filter Tasks button");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Selecting a career adviser
            driver.FindElement(By.CssSelector(".initial-data:nth-child(1) > td:nth-child(8)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting a career adviser");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            driver.FindElement(By.CssSelector(".ExpandedHistoryTop > td:nth-child(8)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            // test.Log(Status.Info, "Selecting a career adviser");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Selecting a career adviser
            driver.FindElement(By.LinkText("Select")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting a career adviser");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Clicking the cancel button
            driver.FindElement(By.CssSelector(".narrowbtn:nth-child(4)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the cancel button");
            test.Log(Status.Pass, "Test 7 Passed");
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
