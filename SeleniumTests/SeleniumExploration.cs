using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTests
{
    public class SeleniumExploration
    {
        [Fact]
        public void Test1()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://techno.ee";
        }
    }
}
