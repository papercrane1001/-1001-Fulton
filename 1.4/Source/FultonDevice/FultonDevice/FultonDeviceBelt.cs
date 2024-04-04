using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RimWorld;
using System.Collections.Generic;
using Verse;

namespace FultonDevice
{
    public class FultonDeviceBelt : Apparel
    {

        public override IEnumerable<Gizmo> GetWornGizmos()
        {
            IEnumerable<Gizmo> gizmos = base.GetWornGizmos();
            FultonAbility fa = new FultonAbility();
            if(this.Wearer != null) { fa.pawn = this.Wearer; }
            gizmos.Append(new Command_Ability(fa)
            {
                defaultLabel = "defaultLabel",
                defaultDesc = "defaultDesc"
            }) ;
            return gizmos;
        }
    }
}
