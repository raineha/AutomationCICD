
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.DevTools.V85.CSS;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace TestProject1
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver
             = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.flipkart.com/");

            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.XPath("//button[@class='_2KpZ6l _2doB4z']")).Click(); // Close the login popup

        }

        //[Test]
        //public void Test1()
        //{
        //    IWebElement SearchTextBox = driver.FindElement(By.XPath("//input[@name = 'q']"));
        //    SearchTextBox.SendKeys("Mobile");
        //    IWebElement SearchButton = driver.FindElement(By.XPath("//button[@class = '_2iLD__']"));
        //    SearchButton.Click();
        //    IWebElement MaxPrice = driver.FindElement(By.XPath("//div[@class='_1YAKP4']"));

        //    SelectElement drp = new SelectElement(MaxPrice);
        //    driver.Close();

        //    Assert.Pass();
            
        //}

        [Test]
        public void Test2()
        {
            IWebElement SearchTextBox = driver.FindElement(By.XPath("//input[@name = 'q']"));
            SearchTextBox.SendKeys("Mobile");
            IWebElement SearchButton = driver.FindElement(By.XPath("//button[@class = '_2iLD__']"));
            SearchButton.Click();
            //IWebElement MaxPrice = driver.FindElement(By.XPath("//div[@class='_1YAKP4']"));

            //SelectElement drp = new SelectElement(MaxPrice);
            driver.Close();

            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            Console.WriteLine("12357904");
        }
    }
}