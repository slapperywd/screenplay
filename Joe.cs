using CSF.FlexDi;
using CSF.Screenplay;
using CSF.Screenplay.Actors;
using Screenplay.Abilities;

namespace Screenplay
{
    public class Joe : Persona
    {
        public override string Name => "Joe";

        public override void GrantAbilities(ICanReceiveAbilities actor, IResolvesServices resolver)
        {
            actor.IsAbleTo<AddNumbers>();
        }
    }
}