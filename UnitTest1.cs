using OpenQA.Selenium.Chrome;
using Selenium_Learn.Pages;
namespace Selenium_Learn
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.google.com.vn/");
            webDriver.Manage().Window.Maximize();
            IWebElement webElement = webDriver.FindElement(By.Name("q"));
            webElement.SendKeys("Selenium");
            webElement.SendKeys(Keys.Return);
          
        }
        //[Test]
        //public void EAWebsiteTest()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("http://eaapp.somee.com/");

        //    driver.FindElement(By.LinkText("Login")).Click();

        //    SeleniumCustomMethods.EnterText(driver, By.Name("USerName"), "admin");
        //    SeleniumCustomMethods.EnterText(driver, By.Id("Password"), "password");
        //    driver.FindElement(By.CssSelector(".btn")).Submit();
        //}
        [Test]
        public void TestWithPOM()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            // pom initalization
            LoginPage loginPage = new LoginPage(driver);

            loginPage.ClickLogin();

            loginPage.Login("admin", "password");

        }
        [Test]
        public void EAWebsiteTestReductSize()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.FindElement(By.Id("loginLink")).Click();
            driver.FindElement(By.Name("UserName")).SendKeys("admin");
            driver.FindElement(By.Id("Password")).SendKeys("password");
            driver.FindElement(By.CssSelector(".btn")).Submit();
        }
        //[Test]
        //public void WorkingWithAdvanceControls()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("file:///C:/Users/Laptop/Downloads/-%20My%20ASP.NET%20Application.html");

        //    SeleniumCustomMethods.SelectDropdownByText(driver, By.Id("dropdown"), "Option 2");

        //    SeleniumCustomMethods.MultiSelectElements(driver, By.Id("multiselect"), ["multi1", "multi2"]);

        //    var getSelectedOptions = SeleniumCustomMethods.GetAllSelectedList(driver, By.Id("multiselect"));
        //   getSelectedOptions.ForEach(Console.WriteLine);

        //}

    }
}