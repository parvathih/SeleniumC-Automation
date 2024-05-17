using OpenQA.Selenium;

public class BasePage
{
    protected IWebDriver driver;

    public BasePage(IWebDriver driver)
    {
        this.driver = driver;
    }

    protected void EnterText(By by, string text)
    {
        driver.FindElement(by).SendKeys(text);
    }

    protected void Click(By by)
    {
        driver.FindElement(by).Click();
    }
}
