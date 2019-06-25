using System;
using System.IO;
using CSF.Screenplay;
using CSF.Screenplay.ReportFormatting;
using CSF.Screenplay.Reporting;
using CSF.Screenplay.Selenium;
using CSF.Screenplay.Selenium.Abilities;
using CSF.Screenplay.Selenium.Reporting;
using OpenQA.Selenium.Chrome;

[assembly: CSF.Screenplay.NUnit.ScreenplayAssembly(typeof(Screenplay.ScreenplayIntegrationConfig))]
namespace Screenplay
{ 
    public class ScreenplayIntegrationConfig : CSF.Screenplay.Integration.IIntegrationConfig
    {
        public void Configure(CSF.Screenplay.Integration.IIntegrationConfigBuilder builder)
        {
            // builder.UseWebDriver(services => new ChromeDriver());
            //// builder.UseWebBrowser();
            // builder.UseBrowserFlags();
            // builder.UseSharedUriTransformer(new RootUriPrependingTransformer("https://github.com/"));

            builder.UseSharedUriTransformer(new RootUriPrependingTransformer("https://github.com/"));
            //builder.UseWebDriverFromConfiguration();
            //
            builder.UseWebDriver(driver => GetDriver());
            builder.UseWebBrowser();
            builder.UseBrowserFlags();
            builder.SaveScreenshotsInDirectoryPerScenario(GetScreenshotRoot());
        }

        string GetScreenshotRoot() => Path.Combine(Environment.CurrentDirectory, "saved-screenshots");

        private ChromeDriver GetDriver()
        {
           
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");

            return new ChromeDriver(chromeOptions);

        }
    }
    
}
