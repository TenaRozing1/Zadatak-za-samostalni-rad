using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test1
{

    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
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

            //Thread.Sleep(5000);

            IWebElement ele = driver.FindElement(By.Name("q"));

            ele.SendKeys("javatpoint tutorials");
            ele.Click();
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}