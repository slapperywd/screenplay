using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSF.Screenplay.Actors;
using CSF.Screenplay.Performables;
using Screenplay.Abilities;

namespace Screenplay.Actions
{
    public class GetTheNews : Question<int>
    {
        public string GetReport(INamed actor)
        {
            throw new NotImplementedException();
        }

        protected override int PerformAs(IPerformer actor)
        {
            var searchNews = actor.GetAbility<SearchTheNews>();
            return searchNews.GetNewsCount();
        }
    }

    public partial class Get
    {
        public static IQuestion<int> GetNewsCount()
        {
            return new GetTheNews();
        }
    }
}
