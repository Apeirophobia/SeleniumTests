using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTests
{
    public class FrontendTests1
    {
        [TestCaseOrderer("ViruVarvid_Testing.PriorityOrderer", "ViruVarvid.Testing")]
        public class FrontendTest1
        {
            [Fact, Order(1)]
            public void test()
            {
                IWebDriver driver = new FirefoxDriver();
                driver.Url = "http://localhost:5173/";
                Thread.Sleep(200);

                IWebElement navigateToServices = driver.FindElement(By.Id("RL_Services"));
                navigateToServices.Click();

                IWebElement navigateToCreateService = driver.FindElement(By.Id("createService"));
                navigateToCreateService.Click();

                IWebElement inputName = driver.FindElement(By.Id("serviceName"));
                inputName.SendKeys("Lehma pesemine");
                
                IWebElement inputPrice = driver.FindElement(By.Id("price"));
                inputPrice.SendKeys("10");
                
                IWebElement inputCategory = driver.FindElement(By.Id("category"));
                inputCategory.SendKeys("Loomad mitte inimesed");
                
                IWebElement inputDescription = driver.FindElement(By.Id("description"));
                inputDescription.SendKeys("Peseme lehmad puhtaks ja lõhnab hästi");

                IWebElement navigateToSaveButton = driver.FindElement(By.Id("saveService"));
                navigateToSaveButton.Click();


            }

        }
    }
}
