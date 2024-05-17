using OpenQA.Selenium;

public class LoginPage : BasePage
{
    private readonly string URL = "https://practicetestautomation.com/practice-test-login/";

    private readonly By USERNAME_FIELD = By.Id("username");
    private readonly By PASSWORD_FIELD = By.Id("password");
    private readonly By LOGIN_BUTTON = By.Id("submit");

    public LoginPage(IWebDriver driver) : base(driver)
    {
    }

    public void QaLogin(string username, string password)
    {
        driver.Navigate().GoToUrl(URL);
        EnterText(USERNAME_FIELD, username);
        EnterText(PASSWORD_FIELD, password);
        Click(LOGIN_BUTTON);
    }
}
