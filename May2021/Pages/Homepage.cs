using May2021.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace May2021.Pages
{
    class Homepage
    {
    public void Navigatetimepage(IWebDriver driver)
        {
            Wait.WaitForElementToBePresent(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/a", 5);
            // click admin 
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            Thread.Sleep(1500);

            // click time and material 
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            Thread.Sleep(3000);
        }
    }
}
