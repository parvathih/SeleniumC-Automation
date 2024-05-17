using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the WebDriver for ChromeDriver
        //IWebDriver driver = new ChromeDriver();
        // Use a using statement to ensure the driver is properly disposed
        using (IWebDriver driver = new ChromeDriver())
        {
            try
            {
                // Create an instance of the LoginPage
                LoginPage loginPage = new LoginPage(driver);

                // Perform the login
                loginPage.QaLogin("student", "Password123");
            }

            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the browser
                driver.Quit();
            }
        }
    }
}
