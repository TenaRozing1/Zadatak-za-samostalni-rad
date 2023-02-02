using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace TestProject1
{
    public class Tests
    {
        IWebDriver driver = new EdgeDriver();
        [SetUp]
        public void Initialize()
        {
            driver.Url = ("https://www.google.com/");
        }

        [Test]
        public void ExecuteTest()
        {

            IWebElement prihvatiSve = driver.FindElement(By.XPath("//div[text()='Prihvati sve']"));
            prihvatiSve.Click();

            Thread.Sleep(5000);

            IWebElement ele = driver.FindElement(By.Name("q"));

            ele.SendKeys("javatpoint tutorials");
            ele.Click();
            Thread.Sleep(2000);
    
            IWebElement ele1 = driver.FindElement(By.Name("btnK"));
       
            ele1.Click();
            Thread.Sleep(3000);
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
          
        }
    }
}