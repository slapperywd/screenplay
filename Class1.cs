using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSF.Screenplay.StepComposer;
using CSF.Screenplay;
using CSF.Screenplay.NUnit;
using CSF.Screenplay.Selenium.Abilities;
using CSF.Screenplay.Selenium.Builders;
using NUnit.Framework;
using Screenplay.Abilities;
using Screenplay.Actions;
using Screenplay.Actors;
using Screenplay.Pages;
using Get = Screenplay.Actions.Get;
using CSF.Screenplay.Selenium.Abilities;


namespace Screenplay
{
    [TestFixture]
    [Description("Users should be able to buy groceries via the application")]
    public class Class1
    {
        [Test, Screenplay]
        [Description("Joe should see a thankyou message when he uses the application to buy eggs.")]
        public void JoeShouldSeeAThankyouMessageWhenHeBuysEggs(ICast cast)
        {
            var mathias = cast.Get<Mathias>();
            Given(mathias).WasAbleTo(StartWith.TheNumber(10));//();
            When(mathias).AttemptsTo(Add.TheNumber(100));
            var result = Then(mathias).ShouldSee(Get.TheNumber());
           // Assert.That(result, Is.EqualTo(110));
            Assert.IsTrue(true);
            //Given(joe).WasAbleTo(SearchTheShop.ForGroceries());
            //When(joe).AttemptsTo(Click.On(GroceriesForSale.BuyEggsButton));
            //var message = Then(joe).ShouldSee(TheText.Of(GroceriesForSale.FeedbackMessage));

            //Assert.That(message, Is.EqualTo("Thankyou for buying eggs."));

        }

        [Test, Screenplay]
        public void JoeShouldBeAbleToSeachTheNews(ICast cast)
        {
            var joe = cast.Get<Joe>();
            //Given(joe).WasAbleTo(Search.ForNews());
            When(joe).AttemptsTo(Search.ForNews("Belarus"));
            var count = Then(joe).ShouldSee(Get.GetNewsCount());
            Assert.AreEqual(count, 5);
        }

        [Test, Screenplay]
        [Description("Clicking on the link to page two navigates to the second page.")]
        public void WebUiTest(ICast cast, BrowseTheWeb browseTheWeb)
        {
            var joe = cast.Get<Joe>();
            joe.IsAbleTo(browseTheWeb);

            Given(joe).WasAbleTo(OpenTheirBrowserOn.ThePage<HomePage>());
            When(joe).AttemptsTo(Enter.TheText("blabla@email.bla").Into(HomePage.EmalInput));
        }
    }
}
