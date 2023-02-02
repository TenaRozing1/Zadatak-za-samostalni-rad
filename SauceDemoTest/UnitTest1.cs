using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Xml.Linq;

namespace TestProject1
{
    public class Tests
    {
        IWebDriver driver = new EdgeDriver();
        [SetUp]
        public void Initialize()
        {
            driver.Url = ("https://www.saucedemo.com/");
        }

        [Test]
        public void LoginFailed()
        {
            IWebElement element2 = driver.FindElement(By.Id("login-button"));
     
            IWebElement usernameInput = driver.FindElement(By.Name("user-name"));

            usernameInput.SendKeys(" ");
            element2.Click();
            IWebElement element3 = driver.FindElement(By.ClassName("error-message-container"));
            IWebElement passInput = driver.FindElement(By.Id("password"));
            passInput.SendKeys("secret_sauce");
            element2.Click();


        }

        [Test]

        public void OnlyPasswordUsed()
        {

            IWebElement element2 = driver.FindElement(By.Id("login-button"));
            IWebElement passInput = driver.FindElement(By.Id("password"));
            IWebElement element3 = driver.FindElement(By.ClassName("error-message-container"));
            passInput.SendKeys("secret_sauce");
            element2.Click();

        }

        [Test]

        public void OnlyUsernameUsed()
        {

            IWebElement element2 = driver.FindElement(By.Id("login-button"));
            IWebElement usernameInput = driver.FindElement(By.Id("user-name"));
            IWebElement element3 = driver.FindElement(By.ClassName("error-message-container"));
            usernameInput.SendKeys("standard_user");
            element2.Click();

        }
        [Test]

        public void WrongPass()
        {

            IWebElement element2 = driver.FindElement(By.Id("login-button"));
            IWebElement passInput = driver.FindElement(By.Id("password"));
            IWebElement usernameInput = driver.FindElement(By.Id("user-name"));
            IWebElement element3 = driver.FindElement(By.ClassName("error-message-container"));
            usernameInput.SendKeys("standard_user");
            passInput.SendKeys("wrongpass");
            element2.Click();

        }

        [Test]
        public void WrongUsername()
        {

            IWebElement element2 = driver.FindElement(By.Id("login-button"));
            IWebElement passInput = driver.FindElement(By.Id("password"));
            IWebElement usernameInput = driver.FindElement(By.Id("user-name"));
            IWebElement element3 = driver.FindElement(By.ClassName("error-message-container"));
            usernameInput.SendKeys("wrongusername");
            passInput.SendKeys("secret_sauce");
            element2.Click();

        }


        [Test]
        public void BothWrong()
        {

            IWebElement element2 = driver.FindElement(By.Id("login-button"));
            IWebElement passInput = driver.FindElement(By.Id("password"));
            IWebElement usernameInput = driver.FindElement(By.Id("user-name"));
            IWebElement element3 = driver.FindElement(By.ClassName("error-message-container"));
            usernameInput.SendKeys("wrongusername");
            passInput.SendKeys("wrongpass");
            element2.Click();

        }


        [Test]
        public void BothSuccess()
        {

            IWebElement element2 = driver.FindElement(By.Id("login-button"));
            IWebElement passInput = driver.FindElement(By.Id("password"));
            IWebElement usernameInput = driver.FindElement(By.Id("user-name"));
            IWebElement element3 = driver.FindElement(By.ClassName("error-message-container"));
            usernameInput.SendKeys("performance_glitch_user");
            passInput.SendKeys("secret_sauce");
            element2.Click();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/inventory.html");

        }


        [TearDown]
        public void CleanUp()
        {
            driver.Close();

        }
    }
}