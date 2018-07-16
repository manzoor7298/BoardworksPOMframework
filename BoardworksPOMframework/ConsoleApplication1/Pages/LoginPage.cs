using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardworksFW.Generators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BoardworksFW.Pages
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "")]
        private IWebElement emailField;
    }
}
