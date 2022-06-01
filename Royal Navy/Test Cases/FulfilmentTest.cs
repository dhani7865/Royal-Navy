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
    public static class FulfilmentTest
    {
        private static double maxWaitSeconds;
        private static object byLocatorType;
        private static IWebElement element;

        public static void Fulfilment(IWebDriver driver, ExtentReports extent)
        {
            var test = extent.CreateTest("Royal Navy - Fulfilment Test").Info("Test Started");

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
            // Clicking on the Fulfilment button
            driver.FindElement(By.CssSelector("li:nth-child(13) span")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Fulfilment button");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();


            // Test 4
            // Clicking the Create New Fulfilment Item button
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Create New Fulfilment Item"))).Click();

            // driver.FindElement(By.LinkText("Create New Fulfilment Item")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create New Fulfilment Item button");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Entering the Fulfilment Type Prompt
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("FulfilmentTypePrompt"))).Click();

            // driver.FindElement(By.Id("FulfilmentTypePrompt")).Click();
            driver.FindElement(By.Id("FulfilmentTypePrompt")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Fulfilment Type Prompt");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Clicking the save button
            driver.FindElement(By.CssSelector("input:nth-child(10)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the save button");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Clicking the Fulfilment Admin Button
            driver.FindElement(By.LinkText("Fulfilment Admin")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Fulfilment Admin button");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Clicking the edit button
            driver.FindElement(By.LinkText("Edit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the edit button");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Selecting Remove Fulfilment Admin
            driver.FindElement(By.Id("FulfilmentAdminDetails_8__RemoveFulfilmentType")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Remove Fulfilment Admin");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Clicking the save button
            driver.FindElement(By.CssSelector("input:nth-child(12)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the save button");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Clicking the Product Admin Button
            driver.FindElement(By.LinkText("Product Admin")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Product Admin Button");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Clicking the Edit Button
            driver.FindElement(By.LinkText("Edit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Edit Button");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Clicking the Save Button
            driver.FindElement(By.CssSelector("input:nth-child(12)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Save Button");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Clicking the Create New Product Button
            driver.FindElement(By.LinkText("Create New Product")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create New Product Button");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Entering the Name
            driver.FindElement(By.Id("Name")).Click();
            driver.FindElement(By.Id("Name")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Name");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            // Entering the Code
            driver.FindElement(By.Id("Code")).Click();
            driver.FindElement(By.Id("Code")).SendKeys("2");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Code");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Clicking the Save Button
            driver.FindElement(By.CssSelector("input:nth-child(12)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Save Button");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Clicking the Fulfilment Admin Button
            driver.FindElement(By.LinkText("Fulfilment Admin")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Fulfilment Admin Button");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Clicking the Home Button
            driver.FindElement(By.LinkText("Home")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Home Button");
            test.Log(Status.Pass, "Test 19 Passed");
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
