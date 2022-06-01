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
    public static class TaskAdminTest
    {
        private static double maxWaitSeconds;
        private static object byLocatorType;
        private static IWebElement element;

        public static void TaskAdmin(IWebDriver driver, ExtentReports extent)
        {
            var test = extent.CreateTest("Royal Navy - Task Admin Test").Info("Test Started");

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
            // Clicking on the Task Admin button
            driver.FindElement(By.CssSelector("li:nth-child(4) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Task Admin button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Setting the Task Priority order
            driver.FindElement(By.Id("TaskTypes_0__Order")).Clear();
            driver.FindElement(By.Id("TaskTypes_0__Order")).SendKeys("2");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Setting the Task Priority order");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Clicking the View Active Tasks button
            driver.FindElement(By.LinkText("View Active Tasks")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the View Active Tasks button");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Selecting the status ID
            driver.FindElement(By.Id("StatusID")).Click();

            var dropdown = driver.FindElement(By.Id("StatusID"));
            dropdown.FindElement(By.XPath("//option[. = 'Active']")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the status ID");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Clicking the filter button
            driver.FindElement(By.Id("btnFilter")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the filter button");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Clicking the Home button
            driver.FindElement(By.LinkText("Home")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the home button");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Clicking the Task admin button
            driver.FindElement(By.CssSelector("li:nth-child(4) span")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Task admin button");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Clicking the Edit Roles button
            driver.FindElement(By.LinkText("Edit Roles")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Edit Roles button");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Selecting the BranchIds
            dropdown = driver.FindElement(By.Id("SelectedBranchIds"));
            dropdown.FindElement(By.XPath("//option[. = 'Deck']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the BranchIds");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Selecting the Role Ids
            dropdown = driver.FindElement(By.Id("SelectedRoleIds"));
            dropdown.FindElement(By.XPath("//option[. = 'Royal Marines Officer']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the RoleIds");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Clicking the save button
            driver.FindElement(By.CssSelector("input:nth-child(8)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the save button");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Clicking the Save Task Order Button
            driver.FindElement(By.CssSelector("input:nth-child(3)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the save task order button");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Clicking the home button
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
