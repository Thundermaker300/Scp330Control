using Exiled.API.Interfaces;

using System.Collections.Generic;
using System.ComponentModel;

namespace Scp330Control
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("Remove candies from the list if you do not want players to be able to pick them up.")]
        public List<ItemType> AllowedCandies { get; set; } = new List<ItemType> { ItemType.RedCandy, ItemType.YellowCandy, ItemType.BlueCandy, ItemType.GreenCandy, ItemType.PurpleCandy, ItemType.PinkCandy };
        [Description("Lock the door to SCP-330 at the start at the round and unlock it after the given amount of seconds. Set to 0 to disable.")]
        public int Scp330LockdownLength { get; set; } = 0;
        [Description("The message to show if a player tries to open the door during the lockdown. Set to none to disable.")]
        public string Scp330LockdownMessage { get; set; } = "SCP-330 is currently under lockdown.";
    }
}
