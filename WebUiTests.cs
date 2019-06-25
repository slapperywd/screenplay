using CSF.Screenplay;
using CSF.Screenplay.NUnit;
using CSF.Screenplay.Selenium.Abilities;
using CSF.Screenplay.Selenium.Builders;
using NUnit.Framework;
using Screenplay.Pages;
using static CSF.Screenplay.StepComposer;

namespace Screenplay
{
    [TestFixture]
    public class WebUiTests
    {
        [Test, Screenplay]
        public void A_new_item_can_be_added_to_an_empty_list(ICast cast, BrowseTheWeb browseTheWeb)
        {
            var joe = cast.Get("Joe");
            joe.IsAbleTo(browseTheWeb);

            Given(joe).WasAbleTo(OpenTheirBrowserOn.ThePage<HomePage>());
            When(joe).AttemptsTo(Enter.TheText("blabla@email.bla").Into(HomePage.EmalInput));

            // The rest of the test is unchanged
        }


    }
}
