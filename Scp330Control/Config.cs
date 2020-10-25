using Exiled.API.Interfaces;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scp330Control
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("Remove candies from the list if you do not want players to be able to pick them up.")]
        public List<ItemType> AllowedCandies { get; set; } = new List<ItemType> { ItemType.RedCandy, ItemType.YellowCandy, ItemType.BlueCandy, ItemType.GreenCandy, ItemType.PurpleCandy, ItemType.PinkCandy };
    }
}
