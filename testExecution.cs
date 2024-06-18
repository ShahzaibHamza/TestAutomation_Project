using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V123.FedCm;
using OpenQA.Selenium.Firefox;

namespace SoftwareTestingProject_AutomationFramework
{
    [TestClass]
    public class TestExecution
    {

        LoginPage loginpage = new LoginPage();

        [TestMethod]
        public void LoginWithValidUserValidPassword_TC001()
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://adactinhotelapp.com/", "shahzaibTester", "shahzaibTester");
            String actualText = CorePage.driver.FindElement(By.ClassName("welcome_menu")).Text;
            Assert.AreEqual("Welcome to Adactin Group of Hotels", actualText);
            CorePage.driver.Close();
        }

        [TestMethod]
        public void LoginwithInvalidUserInvalidPassword_TC002()
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://adactinhotelapp.com/", "shahzaib", "Tester");
            String actualText = CorePage.driver.FindElement(By.ClassName("auth_error")).Text;
            Assert.AreEqual("Invalid Login details or Your Password might have expired. Click here to reset your password", actualText);
            CorePage.driver.Close();
        }

       
    }
}