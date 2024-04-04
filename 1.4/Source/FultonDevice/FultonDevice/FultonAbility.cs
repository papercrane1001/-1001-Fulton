using RimWorld;
using RimWorld.Planet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace FultonDevice
{
    public class FultonAbility : Ability
    {
        public override bool CanApplyOn(GlobalTargetInfo target)
        {
            try
            {
                Pawn pawn = null;
                if(target.Thing is Pawn p)
                {
                    pawn = (Pawn)target.Thing;
                }
                if (pawn != null && pawn.Downed)
                {
                    return true;
                }
            }
            catch { }
            return base.CanApplyOn(target);
        }
        public override bool Activate(GlobalTargetInfo target)
        {
            if(base.Activate(target) == true)
            {
                if(base.CanCast == true)
                {
                    return true;
                }
            }
            return false;
        }

        public FultonAbility() 
        { 

        }
    }
}
