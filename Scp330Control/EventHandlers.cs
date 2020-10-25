using Exiled.Events.EventArgs;
using MEC;
using Exiled.API.Features;

using System;
using System.Linq;

namespace Scp330Control
{
    public class EventHandlers
    {
        public static Random rng = new Random();
        public bool doorLocked = false;

        public void OnRoundStarted()
        {
            if (Scp330Control.Singleton.Config.Scp330LockdownLength > 0)
            {
                doorLocked = true;
                Timing.CallDelayed(Scp330Control.Singleton.Config.Scp330LockdownLength, () =>
                {
                    doorLocked = false;
                });
            }
        }
        public void OnInteractingDoor(InteractingDoorEventArgs ev)
        {
            if (ev.Door.DoorName == "012" && doorLocked == true)
            {
                if (Scp330Control.Singleton.Config.Scp330LockdownMessage.ToLower() != "none")
                {
                    ev.Player.ShowHint(Scp330Control.Singleton.Config.Scp330LockdownMessage, 3);
                }
                ev.IsAllowed = false;
            }
        }
        public void OnPickingUpScp330(PickingUpScp330EventArgs ev)
        {
            if (Scp330Control.Singleton.Config.AllowedCandies.Count == 0)
            {
                ev.IsAllowed = false;
                return;
            }
            if (!Scp330Control.Singleton.Config.AllowedCandies.Contains(ev.ItemId))
            {
                int index = rng.Next(0, Scp330Control.Singleton.Config.AllowedCandies.Count - 1);
                ev.ItemId = Scp330Control.Singleton.Config.AllowedCandies.ElementAt(index);
            }
        }
    }
}
