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
    public static class SearchApplicationsTest
    {
        private static double maxWaitSeconds;
        private static object byLocatorType;
        private static IWebElement element;

        public static void SearchApplications(IWebDriver driver, ExtentReports extent)
        {
            var test = extent.CreateTest("Royal Navy - Search Applications Test").Info("Test Started");

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
            // Clicking on the Search Applications button
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            // wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("li:nth-child(6) span"))).Click();

            driver.FindElement(By.CssSelector("li:nth-child(6) span")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(6000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Search Applications button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Selecting the Application Enquiry Status Id
            var dropdown = driver.FindElement(By.Id("ApplicationEnquiryStatusId"));

            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("ApplicationEnquiryStatusId"))).Click();


            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("ApplicationOnHold");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Application Enquiry Status Id");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Clicking the Filter button
            driver.FindElement(By.CssSelector(".isValid:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Filter button");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Selecting the ApplicationEnquiryStatusId
            dropdown = driver.FindElement(By.Id("ApplicationEnquiryStatusId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("ApplicationEnquiryExpired");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the ApplicationEnquiryStatusId");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Clicking the filter button
            driver.FindElement(By.CssSelector(".isValid:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Filter button");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Clicking the details button
            driver.FindElement(By.LinkText("Details")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the details button");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Clicking on the ESC key on the keyboard to go off the details page
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Escape).Perform();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the ESC key on the keyboard to go off the details page");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            /*
            // Test 9
            // Clicking the home button
            // driver.FindElement(By.LinkText("Home")).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Home"))).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the home button");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();
            */

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
