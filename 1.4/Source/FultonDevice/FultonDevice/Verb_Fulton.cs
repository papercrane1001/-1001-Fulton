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
    public class Verb_Fulton : Verb
    {
        protected override bool TryCastShot()
        {
            //throw new NotImplementedException();
            return true;
        }

        protected override float EffectiveRange
        {
            get
            {
                return 1.2f;
            }
        }



    }
}
