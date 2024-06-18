using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V123.FedCm;
using OpenQA.Selenium.Firefox;
using SoftwareTestingProject_AutomationFramework.WebApp.Cart;
using SoftwareTestingProject_AutomationFramework.WebApp.Checkout_Page;
using SoftwareTestingProject_AutomationFramework.WebApp.loginPage;
using SoftwareTestingProject_AutomationFramework.WebApp.OrderCompletion;
using SoftwareTestingProject_AutomationFramework.WebApp.ProductsPage;

namespace SoftwareTestingProject_AutomationFramework
{
    [TestClass]
    public class TestExecution
    {

        LoginPage loginpage = new LoginPage();
        ProductsPage productpage = new ProductsPage();
        AddToCart addToCart = new AddToCart();
        Checkout checkout = new Checkout();
        UserInfoForm userinfo = new UserInfoForm();
        OrderCompletionPage ordercomplete = new OrderCompletionPage();


        [TestMethod]
        public void LoginWithValidUserValidPassword_TC001()
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            CorePage.driver.Close();
        }

        [TestMethod]
       
        public void SelectProduct_TC002() 
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            productpage.ClickOnItem();
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            CorePage.driver.Close();
        }


        [TestMethod]
        public void addItemToCart_TC003() 
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            productpage.ClickOnItem();
            addToCart.addItemToCart();
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            CorePage.driver.Close();
        }

        [TestMethod]
        public void Checkout_TC004()
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            productpage.ClickOnItem();
            addToCart.addItemToCart();
            checkout.clickCheckout();
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            CorePage.driver.Close();
        }

        [TestMethod]
        public void Checkoutpage_TC005()
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            productpage.ClickOnItem();
            addToCart.addItemToCart();
            checkout.clickCheckout();
            userinfo.userinfofill("Shahzaib", "Hamza", "7740-Korangi");
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            CorePage.driver.Close();
        }

        [TestMethod]
        public void OrderCompletion_TC006()
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            productpage.ClickOnItem();
            addToCart.addItemToCart();
            checkout.clickCheckout();
            userinfo.userinfofill("Shahzaib", "Hamza", "7740-Korangi");
            ordercomplete.clickFinish();
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            //CorePage.driver.Close();
        }
    }
}