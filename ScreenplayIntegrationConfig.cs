using CSF.Screenplay.Selenium;
using OpenQA.Selenium.Chrome;

[assembly: CSF.Screenplay.NUnit.ScreenplayAssembly(typeof(Screenplay.ScreenplayIntegrationConfig))]
namespace Screenplay
{ 
    public class ScreenplayIntegrationConfig : CSF.Screenplay.Integration.IIntegrationConfig
    {
        public void Configure(CSF.Screenplay.Integration.IIntegrationConfigBuilder builder)
        {
            builder.UseWebDriver(services => new ChromeDriver());
            
               
        }
    }
}
