using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTestingProject_AutomationFramework.WebApp.ProductsPage
{
    public class AddToCart : CorePage
    {
        By addToCart = By.Id("add-to-cart");

        public void addItemToCart()
        {

            driver.FindElement(addToCart).Click();
        }
    }
}
