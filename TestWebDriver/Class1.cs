using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestWebDriver
{
    public class Class1
    {

        ChromeDriver driver;


        [SetUp]
        public void startBrowser()
        {

            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

        }


        [Test, Order(1)]
        public void Test1()
        {

            driver.Url = "https://aspnetcoremaster.com";

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/header/div/a[2]")).Click();

            string menuText = driver.FindElement(By.Id("menu-bar")).Text;

            Thread.Sleep(1000);

            Assert.AreEqual("El pequeño libro de ASP.NET Core", menuText);

            Console.WriteLine("Test 1 Passed");

            Thread.Sleep(1000);
        }


        [Test, Order(2)]
        public void Test2()
        {
            driver.Url = "https://www.lambdatest.com";

            Thread.Sleep(4000);

            string bigText = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/section[1]/div/div[1]/h1")).Text;

            Assert.AreEqual("Cross Browser Testing Cloud", bigText);

            Console.WriteLine("Test 2 Passed");

            Thread.Sleep(1000);


        }



        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }

    }
}