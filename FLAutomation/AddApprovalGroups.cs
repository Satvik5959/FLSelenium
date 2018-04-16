using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using System.Threading;

namespace FLAutomation
{
    [TestFixture]
    class AddApprovalGroups : AutomationBase
    {
        public static string AddNewGroupCode = ConfigurationManager.AppSettings["addNewGroupCode"].ToString();

        [Test]
        public void InsertApprover()
        {
            driver.Navigate().GoToUrl(AddNewGroupCode);
            driver.FindElement(By.Name("txtAuthGroupCode")).Clear();
            driver.FindElement(By.Name("txtAuthGroupCode")).SendKeys("105-Z999");
            driver.FindElement(By.Name("txtDescription")).Clear();
            driver.FindElement(By.Name("txtDescription")).SendKeys("Balance Sheet");
            driver.FindElement(By.Name("txtAdministrator")).Clear();
            driver.FindElement(By.Name("txtAdministrator")).SendKeys("MANAGER");
            driver.FindElement(By.Name("butSubmit")).Click();
        }
    }
}
