using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using UnityEngine;
using Verse;
using RimWorld;

namespace FultonDevice
{
    public class Verb_Fulton : Verb_CastAbilityTouch
    {
        public override bool ValidateTarget(LocalTargetInfo target, bool showMessages = true)
        {
            if( base.ValidateTarget(target, showMessages))
            {
                try
                {
                    Pawn pawn = null;
                    if (target.Thing is Pawn p)
                    {
                        pawn = (Pawn)target.Thing;
                    }
                    if (pawn != null && pawn.Downed)
                    {
                        return true;
                    }
                }
                catch { }
                return true;
            }

            return false;
        }



    }
}
