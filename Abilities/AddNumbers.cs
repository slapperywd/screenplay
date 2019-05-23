using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSF.Screenplay.Abilities;

namespace Screenplay.Abilities
{
    public class AddNumbers : Ability
    {
        int current = 0;

        public void Add(int number)
        {
            current += number;
        }

        public void Set(int number)
        {
            current = number;
        }

        public int GetTotal() => current;
    }
}
