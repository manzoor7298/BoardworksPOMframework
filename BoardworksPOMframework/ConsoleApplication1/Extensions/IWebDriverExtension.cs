using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace BoardworksFW.Selenium
{
    public static class IWebDriverExtension
    {

        public static void FindSelectElement(this IWebDriver driver, By bylocator, string text)
        {
            //Finds a select element and then selects 
            // The option element using the visible text

            IWebElement selectElement = driver.FindElement(bylocator);
            selectElement.FindElement(By.XPath("//option[contains(text(), '" + text + "')]")).Click();
        }
        public static bool WaitForAjax(this IWebDriver driver)
        {
            try
            {
                while (true)
                {
                    var ajaxisComplete = (bool)(driver as IJavaScriptExecutor).ExecuteScript("return jquery.active == 0");
                    if (ajaxisComplete)
                        break;
                    Thread.Sleep(100);
                }
            }
            catch (TimeoutException e)
            {
                Console.Error.WriteLine(e.Message + "Error waiting for ajax");
            }
            return true;
        }
    }
}

