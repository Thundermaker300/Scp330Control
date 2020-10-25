using Exiled.API.Enums;
using Exiled.API.Features;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Events = Exiled.Events.Handlers;

namespace Scp330Control
{
    public class Scp330Control : Plugin<Config>
    {
        public override string Name { get; } = "Scp330Control";
        public override string Author { get; } = "Thunder";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 1, 9);
        public override PluginPriority Priority { get; } = PluginPriority.High;

        public static Scp330Control Singleton;
        private EventHandlers Handler;

        public override void OnEnabled()
        {
            Singleton = this;
            Handler = new EventHandlers();

            Events.Player.PickingUpScp330 += Handler.OnPickingUpScp330;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Events.Player.PickingUpScp330 -= Handler.OnPickingUpScp330;

            Singleton = null;
            Handler = null;

            base.OnDisabled();
        }
    }
}
