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
    public static class StartScriptTest
    {
        private static double maxWaitSeconds;
        private static object byLocatorType;
        private static IWebElement element;

        public static void StartScript(IWebDriver driver, ExtentReports extent)
        {
            var test = extent.CreateTest("Royal Navy - Start Script Test").Info("Test Started");

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
            // Clicking on the start script button
            driver.FindElement(By.CssSelector("li:nth-child(1) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the start script button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Selecting the SelectedCareerService_ID
            var dropdown = driver.FindElement(By.Id("SelectedCareerService_ID"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Royal Marines");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedCareerService_ID");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Entering the Firstname
            driver.FindElement(By.Id("Firstname")).Click();
            driver.FindElement(By.Id("Firstname")).SendKeys("First");


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Firstname");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Entering the Lastname
            driver.FindElement(By.Id("Lastname")).SendKeys("Last");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Lastname");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Clicking the continue button
            // driver.FindElement(By.Id("ScriptStartSubmit")).Click();
            driver.FindElement(By.XPath("//input[@type='submit' and @value ='Continue']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Clicking the contact button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(2) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the contact button");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Entering the Postcode
            driver.FindElement(By.Id("Postcode")).Click();
            driver.FindElement(By.Id("Postcode")).SendKeys("BS1 3LG");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Postcode");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Entering the Email
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("dhanyaal.rashid@teleperformance.co.uk");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Email");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Entering the DateOfBirth
            driver.FindElement(By.Id("DateOfBirth")).Click();
            driver.FindElement(By.Id("DateOfBirth")).SendKeys("08/07/1980");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the DateOfBirth");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Clicking the search button
            driver.FindElement(By.CssSelector(".isValid:nth-child(1)")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Clicking the Create a new Contact button
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Create a new Contact"))).Click();


            // driver.FindElement(By.LinkText("Create a new Contact")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create a new Contact button");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Selecting the Gender ID
            dropdown = driver.FindElement(By.Id("Gender_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Male");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Gender ID");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Selecting the qualification ID
            dropdown = driver.FindElement(By.Id("Qualification_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("GCSE or Scottish or equivalent");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the qualification ID");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Selecting the EmploymentStatus_ID
            dropdown = driver.FindElement(By.Id("EmploymentStatus_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Employed");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Employment Status ID");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            // Selecting the Date Left Education
            driver.FindElement(By.Id("LeftEducation")).Click();
            driver.FindElement(By.CssSelector(".ui-datepicker-year")).Click();
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.CssSelector(".ui-datepicker-month")).Click();
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.LinkText("14")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Date Left Education");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();


            // Test 17
            // Selecting the Ethnicity_ID
            dropdown = driver.FindElement(By.Id("Ethnicity_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Asian Pakistan");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Ethnicity_ID");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Selecting the Nationality_ID
            dropdown = driver.FindElement(By.Id("Nationality_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("British");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Nationality_ID");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Entering the Mobile Telephone
            driver.FindElement(By.Id("ContactMethods_1__Value")).Click();
            driver.FindElement(By.Id("ContactMethods_1__Value")).SendKeys("07554402128");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Mobile Telephone");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // Test 20
            // Entering the Other Telephone
            driver.FindElement(By.Id("ContactMethods_2__Value")).Click();
            driver.FindElement(By.Id("ContactMethods_2__Value")).SendKeys("07554402128");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Other Telephone");
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            // Test 21
            // Clicking on Is Future Contact Disabled
            driver.FindElement(By.XPath("(//input[@id=\'IsFutureContactDisabled\'])[2]")).Click();
            driver.FindElement(By.XPath("(//input[@id=\'IsFutureContactDisabled\'])[2]")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on Is Future Contact Disabled");
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();

            // Test 22
            // Selecting the Preferred Contact Method ID
            dropdown = driver.FindElement(By.Id("PreferredContactMethodID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Mobile Telephone");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Preferred Contact Method ID");
            test.Log(Status.Pass, "Test 22 Passed");
            extent.Flush();

            // Test 23
            // Selecting the address type ID
            dropdown = driver.FindElement(By.Id("Addresses_0__Type_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Home");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the address type ID");
            test.Log(Status.Pass, "Test 23 Passed");
            extent.Flush();

            // Test 24
            // Clicking on the lookup button and waiting for the dropdown to appear and selecting the Address from the dropdown
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("lookup"))).Click();

            // Finding the element and address from the dopdown and clicking on the element. 
            dropdown = driver.FindElement(By.Id("Addresses_0__SelectedSearchResult"));

            System.Threading.Thread.Sleep(5000);


            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Teleperformance, Spectrum House, Bond Street, BRISTOL");

            System.Threading.Thread.Sleep(5000);


            // Selecting the address from the search result and double clicking on the element
            driver.FindElement(By.ClassName("use")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the lookup button and waiting for the dropdown to appear and selecting the Address from the dropdown");
            test.Log(Status.Pass, "Test 24 Passed");
            extent.Flush();

            // Test 25
            // Clicking the create contact button
            driver.FindElement(By.CssSelector("form > input:nth-child(9)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the create contact button");
            test.Log(Status.Pass, "Test 25 Passed");
            extent.Flush();

            // Test 26
            // Clicking the Application Enquiry button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(3) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Application Enquiry button");
            test.Log(Status.Pass, "Test 26 Passed");
            extent.Flush();

            // Test 27
            // Clicking the new New application enquiry button
            driver.FindElement(By.LinkText("New application enquiry")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Application Enquiry button");
            test.Log(Status.Pass, "Test 27 Passed");
            extent.Flush();

            // Test 28
            // Searchiung for Search Description
            driver.FindElement(By.Id("SearchText")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Searchiung for Search Description");
            test.Log(Status.Pass, "Test 28 Passed");
            extent.Flush();

            // Test 29
            // Clicking the view roles button 
            driver.FindElement(By.CssSelector("fieldset > div:nth-child(4) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the view roles button");
            test.Log(Status.Pass, "Test 29 Passed");
            extent.Flush();

            /*
            // Test 30
            // Clicking the link button
            driver.FindElement(By.LinkText("Link")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the view roles button");
            test.Log(Status.Pass, "Test 30 Passed");
            extent.Flush();
            */

            // Test 31
            // Clicking the reset button
            driver.FindElement(By.LinkText("Reset")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the reset button");
            test.Log(Status.Pass, "Test 31 Passed");
            extent.Flush();

            // Test 32
            // Searching the Description - Engineering Technician (Marine Engineering) and clicking the View Roles button
            driver.FindElement(By.Id("SearchText")).SendKeys("Engineering Technician (Marine Engineering)");
            driver.FindElement(By.CssSelector("fieldset > div:nth-child(4) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Searching the Description - Engineering Technician (Marine Engineering) and clicking the View Roles button");
            test.Log(Status.Pass, "Test 32 Passed");
            extent.Flush();

            
            // Test 33
            // Clicking on the Select button and clicking the save changes button
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("tr:nth-child(2) .career-select"))).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);


            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='submit' and @value='Save changes']")));


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Select button and clicking the save changes button");
            test.Log(Status.Pass, "Test 33 Passed");
            extent.Flush();


            // Test 34
            // Clicking the Reserve Session Booking button
            /// var findElement = driver.FindElement(By.CssSelector(".script-stage:nth-child(4) > .icon"));
            driver.FindElement(By.CssSelector(".script-stage:nth-child(4)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Reserve Session Booking button");
            test.Log(Status.Pass, "Test 34 Passed");
            extent.Flush();

            // test 35
            // Clicking the Field Office Locator button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(5) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Field Office Locator button");
            test.Log(Status.Pass, "Test 35 Passed");
            extent.Flush();

            // Test 36
            // Clicking the search button
            driver.FindElement(By.CssSelector(".isValid:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 36 Passed");
            extent.Flush();

            // Test 37
            // Clicking the Schedule Callback button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(6) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Schedule Callback button");
            test.Log(Status.Pass, "Test 37 Passed");
            extent.Flush();

            // Test 38
            // Selecting the task type ID - Callback
            dropdown = driver.FindElement(By.Id("TaskType_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Callback");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the task type ID - Callback");
            test.Log(Status.Pass, "Test 38 Passed");
            extent.Flush();

            // Test 39
            // Selecting the CallbackDate
            driver.FindElement(By.Id("CallbackDate")).Click();
            driver.FindElement(By.LinkText("21")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the CallbackDate");
            test.Log(Status.Pass, "Test 39 Passed");
            extent.Flush();

            // Test 40
            // Selecting the Task Slot ID
            dropdown = driver.FindElement(By.Id("TaskSlot_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Morning (From 8:00)");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Task Slot ID");
            test.Log(Status.Pass, "Test 40 Passed");
            extent.Flush();


            // Test 41
            // Entering the notes
            driver.FindElement(By.Id("Notes")).Click();
            driver.FindElement(By.Id("Notes")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the notes");
            test.Log(Status.Pass, "Test 41 Passed");
            extent.Flush();

            // Test 42
            // Clicking the save button
            driver.FindElement(By.Name("command")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the save button");
            test.Log(Status.Pass, "Test 42 Passed");
            extent.Flush();

            // Test 43
            // Clicking the Fulfilment button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(7) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Fulfilment button");
            test.Log(Status.Pass, "Test 43 Passed");
            extent.Flush();

            // Test 44
            // Clicking the send brochure button
            driver.FindElement(By.LinkText("Send Brochure")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the send brochure button");
            test.Log(Status.Pass, "Test 44 Passed");
            extent.Flush();

            // Test 45
            // Entering the Search Description - Air Engineering Technician
            driver.FindElement(By.Id("SearchText")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Search Description - Air Engineering Technician");
            test.Log(Status.Pass, "Test 45 Passed");
            extent.Flush();

            // Test 46
            // Clicking the View Roles button
            driver.FindElement(By.CssSelector("fieldset > div:nth-child(4) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the View Roles button");
            test.Log(Status.Pass, "Test 46 Passed");
            extent.Flush();

            // Test 47
            // Clicking the select button
            driver.FindElement(By.LinkText("Select")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the select button");
            test.Log(Status.Pass, "Test 47 Passed");
            extent.Flush();

            // Test 48
            // Clicking the Back
            driver.FindElement(By.LinkText("Back")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back");
            test.Log(Status.Pass, "Test 48 Passed");
            extent.Flush();

            // Test 49
            // Clicking the Send Bespoke Email button
            driver.FindElement(By.LinkText("Send Bespoke Email")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Send Bespoke Email button");
            test.Log(Status.Pass, "Test 49 Passed");
            extent.Flush();

            // Test 50
            // Entering the email subject
            driver.FindElement(By.Id("EmailSubject")).SendKeys("test");


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the email subject");
            test.Log(Status.Pass, "Test 50 Passed");
            extent.Flush();

            // Test 51
            // Entering the email text
            driver.FindElement(By.Id("EmailText")).Click();
            driver.FindElement(By.Id("EmailText")).SendKeys("this is a test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the email text");
            test.Log(Status.Pass, "Test 51 Passed");
            extent.Flush();

            // Test 52
            // Clicking the send button to send the email
            driver.FindElement(By.CssSelector("input:nth-child(4)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the send button to send the email");
            test.Log(Status.Pass, "Test 52 Passed");
            extent.Flush();

            // Test 53
            // Clicking the Promotion button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(8) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Promotion button");
            test.Log(Status.Pass, "Test 53 Passed");
            extent.Flush();

            // Test 54
            // Selecting a Application Enquiry and clicking the Save Changes button
            // Clicking on the Select button and clicking the save changes button
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("td:nth-child(2)"))).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting a Application Enquiry and clicking the Save Changes button");
            test.Log(Status.Pass, "Test 54 Passed");
            extent.Flush();

            // Test 55
            // Selecting the sub status ID
            dropdown = driver.FindElement(By.Id("SelectedSubStatus_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("IMRP feedback - Residency");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);

            driver.FindElement(By.CssSelector("form > input")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(8000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the sub status ID");
            test.Log(Status.Pass, "Test 55 Passed");
            extent.Flush();


            
            // Test 56
            // Clicking the New application enquiry button
            driver.FindElement(By.LinkText("New application enquiry")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the New application enquiry button");
            test.Log(Status.Pass, "Test 56 Passed");
            extent.Flush();

            
            // Test 57
            // Entering the Search Description - Aircraft Controller	
            driver.FindElement(By.Id("SearchText")).SendKeys("Aircraft Controller");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Search Description - Aircraft Controller");
            test.Log(Status.Pass, "Test 57 Passed");
            extent.Flush();

            // Test 58
            // Clicking the View Roles button
            driver.FindElement(By.CssSelector("fieldset > div:nth-child(4) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the View Roles button");
            test.Log(Status.Pass, "Test 58 Passed");
            extent.Flush();

            // Test 59
            // Clicking the Select button
            // driver.FindElement(By.LinkText("Select")).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Select"))).Click();

            // 5 seconds implicit wait (C# code)
            // System.Threading.Thread.Sleep(8000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Select button");
            test.Log(Status.Pass, "Test 59 Passed");
            extent.Flush();

            // Test 60
            // Clicking the save changes button
            // driver.FindElement(By.CssSelector("form > input")).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("form > input"))).Click();


            // 5 seconds implicit wait (C# code)
            // System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the save changes button");
            test.Log(Status.Pass, "Test 60 Passed");
            extent.Flush();

            // Test 61
            // Clicking the finish button
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".script-stage:nth-child(9) > .icon"))).Click();


            // 5 seconds implicit wait (C# code)
            // System.Threading.Thread.Sleep(8000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the finish button");
            test.Log(Status.Pass, "Test 61 Passed");
            extent.Flush();

            // Test 62
            // Selecting the Call Reasons
            driver.FindElement(By.Id("CallReasons_2__isSelected")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Call Reasons");
            test.Log(Status.Pass, "Test 62 Passed");
            extent.Flush();

            // Test 63
            // Selecting the Media ID - Website
            dropdown = driver.FindElement(By.Id("SelectedMedia_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Website");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Media ID - Website");
            test.Log(Status.Pass, "Test 63 Passed");
            extent.Flush();

            // Test 64
            // Selecting the Marketing Campaign ID
            dropdown = driver.FindElement(By.Id("SelectedMarketingCampaign_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Teleperformance");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Marketing Campaign ID");
            test.Log(Status.Pass, "Test 64 Passed");
            extent.Flush();

            // Test 65
            // Selecting the Outcome ID - Potential Applicant: Application enquiry
            dropdown = driver.FindElement(By.Id("SelectedOutcome_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Potential Applicant: Application enquiry");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Outcome ID - Potential Applicant: Application enquiry");
            test.Log(Status.Pass, "Test 65 Passed");
            extent.Flush();

            // Test 66
            // Entering the notes
            driver.FindElement(By.Id("Notes")).Click();
            driver.FindElement(By.Id("Notes")).SendKeys("This is a test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the notes");
            test.Log(Status.Pass, "Test 66 Passed");
            extent.Flush();

            // Test 67
            // Clicking the finish button
            driver.FindElement(By.CssSelector(".cti")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the finish button");
            test.Log(Status.Pass, "Test 67 Passed");
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
