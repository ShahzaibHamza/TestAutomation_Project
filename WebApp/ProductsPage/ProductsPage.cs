﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTestingProject_AutomationFramework.WebApp.ProductsPage
{
    public class ProductsPage : CorePage
    {
        By clickOnItem = By.ClassName("inventory_item_name");

        public void ClickOnItem()
        {

            driver.FindElement(clickOnItem).Click();
        }
    }
}
