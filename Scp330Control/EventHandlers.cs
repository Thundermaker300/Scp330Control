using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scp330Control
{
    public class EventHandlers
    {
        public static Random rng = new Random();
        public void OnPickingUpScp330(PickingUpScp330EventArgs ev)
        {
            if (!Scp330Control.Singleton.Config.AllowedCandies.Contains(ev.ItemId))
            {
                int index = rng.Next(0, Scp330Control.Singleton.Config.AllowedCandies.Count - 1);
                ev.ItemId = Scp330Control.Singleton.Config.AllowedCandies.ElementAt(index);
            }
        }
    }
}
