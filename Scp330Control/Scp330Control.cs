using Exiled.API.Enums;
using Exiled.API.Features;

using System;

using Events = Exiled.Events.Handlers;

namespace Scp330Control
{
    public class Scp330Control : Plugin<Config>
    {
        public override string Name { get; } = "Scp330Control";
        public override string Author { get; } = "Thunder";
        public override Version Version { get; } = new Version(1, 0, 2);
        public override Version RequiredExiledVersion { get; } = new Version(2, 1, 9);
        public override PluginPriority Priority { get; } = PluginPriority.High;

        public static Scp330Control Singleton;
        private EventHandlers Handler;

        public override void OnEnabled()
        {
            Singleton = this;
            Handler = new EventHandlers();

            Events.Server.RoundStarted += Handler.OnRoundStarted;
            Events.Player.InteractingDoor += Handler.OnInteractingDoor;
            Events.Player.PickingUpScp330 += Handler.OnPickingUpScp330;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Events.Server.RoundStarted -= Handler.OnRoundStarted;
            Events.Player.InteractingDoor -= Handler.OnInteractingDoor;
            Events.Player.PickingUpScp330 -= Handler.OnPickingUpScp330;

            Singleton = null;
            Handler = null;

            base.OnDisabled();
        }
    }
}
