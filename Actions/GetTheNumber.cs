using System;
using System.Collections.Generic;
using CSF.Screenplay.Actors;
using CSF.Screenplay.Performables;
using Screenplay.Abilities;

namespace Screenplay.Actions
{
    public class GetTheNumber : Question<int>
    {
        protected override int PerformAs(IPerformer actor)
        {
            var ability = actor.GetAbility<AddNumbers>();
            return ability.GetTotal();
        }

        protected override string GetReport(INamed actor) => $"{actor.Name} reads the current number";
    }

    public partial class Get
    {
        public static IQuestion<int> TheNumber()
        {
            return new GetTheNumber();
        }
    }
}
