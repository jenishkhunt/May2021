using May2021.Pages;
using May2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace May2021
{
    [TestFixture]
    class Program : CommonDriver
    {
        //static void Main(string[] args)
        //{
           
        //}


        [SetUp]
        public void LoginToTurnUp() 
        {
            Console.WriteLine("Hello World!");
          driver = new ChromeDriver(@"D:\Automation Program testing\May2021\May2021\");

            //login to the page
            Loginpage loginobj = new Loginpage();
            loginobj.Login(driver);
            //navigate to the time and management
            Homepage navigateobj = new Homepage();
            navigateobj.Navigatetimepage(driver);
        }

        [Test]
        public void CreateTMTest() 
        {
            // create form
            Timepage timeobj = new Timepage();
            timeobj.CreateTM(driver);

        }

        [Test]
        public void EditTMTest() 
        {
            // edit  form
            Timepage timeobj = new Timepage();
            timeobj.EditTM(driver);

        }

        [TearDown]
        public void TestCloser()
        {
            //closing down steps
            driver.Quit();
        }
    }
}
