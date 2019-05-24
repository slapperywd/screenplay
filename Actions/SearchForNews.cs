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
    public class SearchForNews : Performable
    {
        public string _query;

        public SearchForNews(string query)
        {
            _query = query;

        }

        protected override void PerformAs(IPerformer actor)
        {
            var ability = actor.GetAbility<SearchTheNews>();
            ability.SearchNews(_query);
        }
    }

    public class Search
    {
        public static IPerformable ForNews(string query)
        {
            return new SearchForNews(query);
        }
    }
}
