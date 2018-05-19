using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace selenium01
{
    class SeleniumGetMethods
    {


        public static string GetText( string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementType == PropertyType.Name)
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            return String.Empty;
        }


        public static string GetTextDDL(  string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementType == PropertyType.Name)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text; ;
            return String.Empty;
        }



    }
}
