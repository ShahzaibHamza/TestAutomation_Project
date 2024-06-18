using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SoftwareTestingProject_AutomationFramework.WebApp.Cart;
using SoftwareTestingProject_AutomationFramework.WebApp.Checkout_Page;
using SoftwareTestingProject_AutomationFramework.WebApp.loginPage;
using SoftwareTestingProject_AutomationFramework.WebApp.OrderCompletion;
using SoftwareTestingProject_AutomationFramework.WebApp.ProductsPage;
namespace SoftwareTestingProject_AutomationFramework.WebApp
{
    [TestClass]
    public class testExecution2: CorePage
    {
        LoginPage loginpage = new LoginPage();
        AddToCart addToCart = new AddToCart();
        Checkout checkout = new Checkout();
        UserInfoForm userinfo = new UserInfoForm();
        OrderCompletionPage ordercomplete = new OrderCompletionPage();

        [TestMethod]
        public void LoginWithinValidUserinValidPassword_TC001()
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard", "sauce");
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            CorePage.driver.Close();
        }


    }
}
