using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace May2021.Pages
{
    class Timepage
    {
        public void  CreateTM(IWebDriver driver)
        {
            IWebElement HelloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (HelloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Test Passed, logged in successfully");
                IWebElement Admini = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/a"));
                Admini.Click();

                IWebElement Time = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3]"));

                Time.Click();

                IWebElement CreateForm = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
                CreateForm.Click();

                IWebElement Code = driver.FindElement(By.Id("Code"));
                Thread.Sleep(1000);
                Code.SendKeys("Auto");
                IWebElement Description = driver.FindElement(By.Id("Description"));
                Thread.Sleep(1000);
                Description.SendKeys("Description");
                IWebElement Unit = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
                Thread.Sleep(1000);
                Unit.SendKeys("50");
                Thread.Sleep(1000);
                IWebElement Save = driver.FindElement(By.Id("SaveButton"));
                Save.Click();
            }
            else
            {
                Console.WriteLine("Test Failed, login failed");
            }
            Thread.Sleep(100);

        }

        public void EditTM(IWebDriver driver)
        {
            //Test 2-- edit(update) the data successfully
            //click time and material
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]")).Click();
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            Thread.Sleep(1000);
            //go to the last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(1000);
            //click the data which you want a update
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();

            Thread.Sleep(1000);
            //update from material to time
            driver.FindElement(By.XPath(" //*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();



            Thread.Sleep(1000);
            //update code
            driver.FindElement(By.XPath("//*[@id='Code']")).Clear();
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("updatecode");
            Thread.Sleep(1000);
            //update desc
            driver.FindElement(By.XPath("//*[@id='Description']")).Clear();
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("good");
            Thread.Sleep(1000);
            //update price'
            //driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Clear();
            //driver.FindElement(By.XPath("//*[@id='Price']")).Clear();
            //driver.FindElement(By.XPath("//*[@id='Price']")).SendKeys("55");
            //driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("44");
            Thread.Sleep(1000);
            //upload doc
            driver.FindElement(By.XPath("//*[@id='files']")).SendKeys(@"C:\FirstAutomation\jenish.txt");
            Thread.Sleep(1000);
            // click save 
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            Thread.Sleep(1000);

            //validate if the record is successfully
            // go to the the last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            //identify the update record
            string actualcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text;
            //*[@id="tmsGrid"]/div[3]/table/tbody/tr[7]/td[1]
            //*[@id="tmsGrid"]/div[3]/table/tbody/tr[6]/td[1]
            Console.WriteLine(actualcode);
            
            //verify the update details

            //if (actualcode == "updatecode")
            //{
            //  //Console.WriteLine("data updated");
            //    Assert.Pass("data updated");
            //}
            //else
            //{
            //    //Console.WriteLine("data not updated");
            //    Assert.Fail("data not updated");
            //}

            Assert.That(actualcode, Is.EqualTo("updatecode"), "Test Failed");

            Thread.Sleep(5000);

        }
    }
}
