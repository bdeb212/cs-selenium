using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium01
{
    class Program
    {

        // create browser
        //IWebDriver driver = new ChromeDriver();


        static void Main(string[] args)
        {



        }
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            // navigate to 

            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?username=&password=&Login=Login");
        }
        [Test]
        public void ExecuteTest()
        {
            // enter text
            //EnterText(element, value, type);
            SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);
            
            //init
            SeleniumSetMethods.EnterText("Initial", "Execauto", PropertyType.Name);


            Console.WriteLine(" title===========" + SeleniumGetMethods.GetTextDDL("TitleId", PropertyType.Id));
            Console.WriteLine(" name===========" + SeleniumGetMethods.GetText("Initial", PropertyType.Name));
            //click

            SeleniumSetMethods.Click( "Save", PropertyType.Name);

            // type keywork to search

            // IWebElement element = driver.FindElement(By.Name("q"));

            // performe op
            ////element.SendKeys("execute automation");
        }

        [TearDown]
        public void CleanUp()
        {
            // close
            PropertiesCollection.driver.Close();
            Console.WriteLine("close");
        }
    }
}
