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
    public static class ReserveSessionsTest
    {
        private static double maxWaitSeconds;
        private static object byLocatorType;
        private static IWebElement element;

        public static void ReserveSessions(IWebDriver driver, ExtentReports extent)
        {
            var test = extent.CreateTest("Royal Navy - Reserve Sessions Test").Info("Test Started");

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
            // Clicking on the Reserve Sessions button
            driver.FindElement(By.CssSelector("li:nth-child(11) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Reserve Sessions button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Selecting the Reserve Unit ID
            var dropdown = driver.FindElement(By.Id("ReserveUnitID"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("HMS CAMBRIA - TAWE DIVISION (Swansea) (LOK)");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Reserve Unit ID");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Clicking the Filter button
            driver.FindElement(By.Id("btnFilter")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Filter button");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Clicking the Details button
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Details"))).Click();

            // driver.FindElement(By.LinkText("Details")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Details button");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Clicking the back button
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Back"))).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back button");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Clicking the update button
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Update"))).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Update button");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Clicking the back button
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Back"))).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back button");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Clicking the back button
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Back"))).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back button");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Clicking the Add Session button
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Add Session"))).Click();

            // driver.FindElement(By.LinkText("Add Session")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Add Session button");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Selecting the Office_Id
            dropdown = driver.FindElement(By.Id("Office_Id"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("RMR Bristol - CARDIFF (LOK)");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Office_Id");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Selecting the SessionType_Id
            dropdown = driver.FindElement(By.Id("SessionType_Id"));

            selectElement = new SelectElement(dropdown);
            // selectElement.SelectByText("Live Event");
            selectElement.SelectByText("IMRP");


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SessionType_Id");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Selecting the Session Date
            driver.FindElement(By.Id("SessionDate")).Click();
            driver.FindElement(By.LinkText("21")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Session Date");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Selecting the Start Time
            driver.FindElement(By.Id("StartTime")).Click();
            driver.FindElement(By.Id("StartTime")).SendKeys("09:00");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Start Time");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Selecting the End Time
            driver.FindElement(By.Id("EndTime")).Click();
            driver.FindElement(By.Id("EndTime")).SendKeys("18:00");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the End Time");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            // Entering the Cut Off Days
            driver.FindElement(By.Id("CutOffDays")).Click();
            driver.FindElement(By.Id("CutOffDays")).SendKeys("3");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Cut Off Days");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Entering the Capacity
            driver.FindElement(By.Id("Capacity")).Click();
            driver.FindElement(By.Id("Capacity")).SendKeys("4");


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Capacity");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Selecting Offered
            driver.FindElement(By.Id("Offered")).Click();
            driver.FindElement(By.Id("Offered")).SendKeys("3");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Offered");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Entering the Notes
            driver.FindElement(By.Id("Notes")).Click();
            driver.FindElement(By.Id("Notes")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Notes");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // test 20
            // Clicking the save button
            driver.FindElement(By.Name("command")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the save button");
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            
            driver.FindElement(By.ClassName("primary-menu")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);

            // Test 21
            // Clicking the Update Session button
            // driver.FindElement(By.LinkText("Update Session")).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Update Session"))).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Update Session button");
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();

            // Test 22
            // Clicking the continue button
            driver.FindElement(By.Name("command")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Continue button");
            test.Log(Status.Pass, "Test 22 Passed");
            extent.Flush();


            // Test 23
            // Clicking the Cancel Session Button
            // driver.FindElement(By.LinkText("Cancel Session")).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Cancel Session"))).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Cancel Session button");
            test.Log(Status.Pass, "Test 23 Passed");
            extent.Flush();

            // Test 24
            // Clicking the continue button
            driver.FindElement(By.Name("command")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 24 Passed");
            extent.Flush();


            // Test 25
            // Clicking the View Attendees button
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("View Attendees"))).Click();

            // driver.FindElement(By.LinkText("View Attendees")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the View Attendees button");
            test.Log(Status.Pass, "Test 25 Passed");
            extent.Flush();

            // Test 26
            // Clicking the back button
            driver.FindElement(By.LinkText("Back")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the back button");
            test.Log(Status.Pass, "Test 26 Passed");
            extent.Flush();

            // Test 27
            // Clicking the View Reserve Unit button
            driver.FindElement(By.LinkText("View Reserve Unit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the View Reserve Unit button");
            test.Log(Status.Pass, "Test 27 Passed");
            extent.Flush();


            // Test 28
            // Clicking the back button
            // wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Back"))).Click();

            driver.FindElement(By.LinkText("Back")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the back button");
            test.Log(Status.Pass, "Test 28 Passed");
            extent.Flush();

            // Test 29
            // Clicking the back button
            // wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Back"))).Click();

            driver.FindElement(By.LinkText("Back")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the back button");
            test.Log(Status.Pass, "Test 28 Passed");
            extent.Flush();

            
            // Test 30
            // Clicking the home button
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Home"))).Click();

            // driver.FindElement(By.LinkText("Home")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the home button");
            test.Log(Status.Pass, "Test 30 Passed");
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
