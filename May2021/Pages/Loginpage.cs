using May2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace May2021.Pages
{
    class Loginpage
    {
        public void Login(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            // enter url
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            try
            {
                Wait.WaitForElementToBePresent(driver, "Id", "UserName", 2);
                // identify and input username
                IWebElement Username = driver.FindElement(By.Id("UserName"));
                Username.SendKeys("hari");

                // identify and input password
                IWebElement Password = driver.FindElement(By.Id("Password"));
                Password.SendKeys("123123");

                // click login button
                IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                LoginButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Test Failed login page", ex.Message);
            }
        }
    }
}
