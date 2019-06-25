using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSF.Screenplay.Selenium.Models;

namespace Screenplay.Pages
{
    public class HomePage : Page
    {
        public override string GetName() => "the app home page";
        public override IUriProvider GetUriProvider() => new AppUri(string.Empty);
        public static ITarget UserNameInput => new CssSelector("input[id='user[login]']", "username input");
        public static ITarget EmalInput => new CssSelector("input[id='user[email]']", "email input");
    }
}
