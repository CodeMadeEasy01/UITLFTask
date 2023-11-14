using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UITLFTASK;

namespace UITLFTask
{
  
    public class Tests
    {
        //gobalisation
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        { 
            //NUnit Framework
            //Add  selenium, selenuim webdriver, chromeDrivers, NUnit3adaptor, NUnit Packages
            //Decides on the browswer : chrome,firfox,Edge,opera
            var options = new ChromeOptions();
            options.AddArguments("start-maximized", "incognito");
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(Environments.Tlf_Url);
           
        }
        
        [Test]
        public void VerifyValidInputWidgetPageTest()
        {
            // Accept All cookie 
            IWebElement CookiePopButton = driver.FindElement(By.XPath("//strong[text()='Accept all cookies']"));
            CookiePopButton.Click();
            //Action creating an object
            Thread.Sleep(100);
            IWebElement FrominputTxtBox = driver.FindElement(By.XPath("//input[@id='InputFrom']"));
            //Actor
            FrominputTxtBox.Clear();
            FrominputTxtBox.SendKeys("london");
            //Action creating an object
            IWebElement ToInputTxtBox = driver.FindElement(By.XPath("//input[@id='InputTo']"));
            ToInputTxtBox.Clear();
            ToInputTxtBox.SendKeys("Bolton");
            IWebElement payMyJourneyButton = driver.FindElement(By.XPath("//input[@id='plan-journey-button']"));
            Thread.Sleep(100);
            payMyJourneyButton.Click();
            //Action creating an object
             IWebElement JourneyResultsHeaderTxt = driver.FindElement(By.XPath("//span[@class='jp-results-headline']"));
             //Assertion
            Assert.True(driver.Url.Contains("tfl"));
            Console.WriteLine(driver.Url.Contains("tfl"));
            Console.WriteLine(JourneyResultsHeaderTxt.Text.ToString());
        }

        [Test]
        public void VerifyInvalidInputWidget()
        {
            // Accept All cookie 
            IWebElement CookiePopButton = driver.FindElement(By.XPath("//strong[text()='Accept all cookies']"));
            CookiePopButton.Click();
            //Action creating an object
            Thread.Sleep(100);
            IWebElement FrominputTxtBox = driver.FindElement(By.XPath("//input[@id='InputFrom']"));
            //Actor
            FrominputTxtBox.Clear();
            FrominputTxtBox.SendKeys("121A");
            //Action creating an object
            IWebElement ToInputTxtBox = driver.FindElement(By.XPath("//input[@id='InputTo']"));
            ToInputTxtBox.Clear();
            ToInputTxtBox.SendKeys("431W");
            IWebElement payMyJourneyButton = driver.FindElement(By.XPath("(//input[@type='submit'])[1]"));
            payMyJourneyButton.Click();
            //Action creating an object
            Thread.Sleep(100);
            IWebElement ErrorText = driver.FindElement(By.
             XPath("//ul[@class='field-validation-errors']"));
            //Assertion
           Assert.That(ErrorText.ToString(), Is.EqualTo("Sorry,we can't find a journey matching your criteria"));
            Console.WriteLine(driver.Url.Contains("tfl"));
            Console.WriteLine(ErrorText.Text.ToString());
        }


        [Test]
        public void VerifyNolocationInputWidget()
        {
            // Accept All cookie 
            IWebElement CookiePopButton = driver.FindElement(By.XPath("//strong[text()='Accept all cookies']"));
            CookiePopButton.Click();
            //Action creating an object
            Thread.Sleep(100);
            IWebElement FrominputTxtBox = driver.FindElement(By.XPath("//input[@id='InputFrom']"));
            //Actor
            FrominputTxtBox.Clear();
            FrominputTxtBox.SendKeys("");
            //Action creating an object
            IWebElement ToInputTxtBox = driver.FindElement(By.XPath("//input[@id='InputTo']"));
            ToInputTxtBox.Clear();
            ToInputTxtBox.SendKeys("");
            IWebElement payMyJourneyButton = driver.FindElement(By.XPath("(//input[@type='submit'])[1]"));
            payMyJourneyButton.Click();
            //Action creating an object
            Thread.Sleep(100);
            IWebElement ErrorText = driver.FindElement(By.
             XPath("//span[@id='InputFrom-error']"));
            //Assertion
            Assert.That(ErrorText.ToString(), Is.EqualTo("The From field is required"));
            Console.WriteLine(driver.Url.Contains("tfl"));
            Console.WriteLine(ErrorText.Text.ToString());
        }


        [Test]
        public void VerifyChangeLinkTimeInputWidget()
        {
            // Accept All cookie 
            IWebElement CookiePopButton = driver.FindElement(By.XPath("//strong[text()='Accept all cookies']"));
            CookiePopButton.Click();
            //Action creating an object
            Thread.Sleep(100);
            IWebElement FrominputTxtBox = driver.FindElement(By.XPath("//input[@id='InputFrom']"));
            //Actor
            FrominputTxtBox.Clear();
            FrominputTxtBox.SendKeys("London");
            //Action creating an object
            IWebElement ToInputTxtBox = driver.FindElement(By.XPath("//input[@id='InputTo']"));
            ToInputTxtBox.Clear();
            ToInputTxtBox.SendKeys("Bolton");
            IWebElement payMyJourneyButton = driver.FindElement(By.XPath("(//input[@type='submit'])[1]"));
            payMyJourneyButton.Click();
            //Action creating an object
            Thread.Sleep(100);
            IWebElement ChangeTimeLink = driver.FindElement(By.
             XPath("//a[text()='change time']"));
            ChangeTimeLink.Click();
            IWebElement selectdayTime = driver.FindElement(By.XPath("//select[@id='Date']"));
            selectdayTime.Click();
            IWebElement selectTime = driver.FindElement(By.XPath("//select[@id='Date']"));
            selectTime.Click();
            IWebElement HeaderText = driver.FindElement(By.XPath("(//span[text()='Journey results'])[2]"));
            //Assertion
            Assert.That(HeaderText.ToString(), Is.EqualTo("Journey results"));
            Console.WriteLine(driver.Url.Contains("tfl"));
            Console.WriteLine(HeaderText.Text.ToString());
        }

        [Test]
        public void VerifyEditTheInputWidget()
        {
            // Accept All cookie 
            IWebElement CookiePopButton = driver.FindElement(By.XPath("//strong[text()='Accept all cookies']"));
            CookiePopButton.Click();
            //Action creating an object
            Thread.Sleep(100);
            IWebElement FrominputTxtBox = driver.FindElement(By.XPath("//input[@id='InputFrom']"));
            //Actor
            FrominputTxtBox.Clear();
            FrominputTxtBox.SendKeys("London");
            //Action creating an object
            IWebElement ToInputTxtBox = driver.FindElement(By.XPath("//input[@id='InputTo']"));
            ToInputTxtBox.Clear();
            ToInputTxtBox.SendKeys("Bolton");
            IWebElement payMyJourneyButton = driver.FindElement(By.XPath("(//input[@type='submit'])[1]"));
            payMyJourneyButton.Click();
            //Action creating an object
            Thread.Sleep(100);
            IWebElement ChangeTimeLink = driver.FindElement(By.
             XPath("//a[text()='change time']"));
            ChangeTimeLink.Click();
            IWebElement HeaderText = driver.FindElement(By.XPath("(//span[text()='Journey results'])[2]"));

            //Edit Scenario 
            IWebElement EditJourneyPlan = driver.FindElement(By.XPath("//span[text()='Edit journey']"));
            EditJourneyPlan.Click();
            //Action creating an object
            Thread.Sleep(100);
            IWebElement FromInputEditTxtBox = driver.FindElement(By.XPath("//input[@id='InputFrom']"));
            //Actor
            FromInputEditTxtBox.Clear();
            FromInputEditTxtBox.SendKeys("London,UK");
            //Action creating an object
            IWebElement ToInputEditTxtBox = driver.FindElement(By.XPath("//input[@id='InputTo']"));
            ToInputEditTxtBox.Clear();
            ToInputEditTxtBox.SendKeys("Manchester,UK");
            IWebElement UpdateJorneyButton = driver.FindElement(By.XPath("//input[@id='plan-journey-button']"));
            UpdateJorneyButton.Click();
            //Assertion
            Assert.That(HeaderText.ToString(), Is.EqualTo("Journey results"));
            Console.WriteLine(driver.Url.Contains("tfl"));
            Console.WriteLine(HeaderText.Text.ToString());
        }



        [Test]


        public void VerifyRecentsTabWidget()
        {
            //// Accept All cookie 
            //IWebElement CookiePopButton = driver.FindElement(By.XPath("//strong[text()='Accept all cookies']"));
            //CookiePopButton.Click();
            ////Action creating an object
            //Thread.Sleep(100);
            //IWebElement FrominputTxtBox = driver.FindElement(By.XPath("//input[@id='InputFrom']"));
            ////Actor
            //FrominputTxtBox.Clear();
            //FrominputTxtBox.SendKeys("London");
            ////Action creating an object
            //IWebElement ToInputTxtBox = driver.FindElement(By.XPath("//input[@id='InputTo']"));
            //ToInputTxtBox.Clear();
            //ToInputTxtBox.SendKeys("Bolton");

            //IWebElement payMyJourneyButton = driver.FindElement(By.XPath("(//input[@type='submit'])[1]"));
            //payMyJourneyButton.Click();
            IWebElement RecentTabButton = driver.FindElement(By.XPath("(//li[@id='jp-recent-tab-jp'])[1]"));
             driver.PageSource.Contains("Recents");
            
        }




        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

    }

}


