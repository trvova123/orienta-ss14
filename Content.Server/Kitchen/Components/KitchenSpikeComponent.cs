using Content.Server.Kitchen.EntitySystems;
using Content.Shared.Kitchen.Components;

namespace Content.Server.Kitchen.Components
{
    [RegisterComponent, Access(typeof(KitchenSpikeSystem)), ComponentReference(typeof(SharedKitchenSpikeComponent))]
    public sealed class KitchenSpikeComponent : SharedKitchenSpikeComponent
    {
        public List<string?>? PrototypesToSpawn;

        // TODO: Spiking alive mobs? (Replace with uid) (deal damage to their limbs on spiking, kill on first butcher attempt?)
        public string MeatSource1p = "?";
        public string MeatSource0 = "?";
        public string Victim = "?";

        // Prevents simultaneous spiking of two bodies (could be replaced with CancellationToken, but I don't see any situation where Cancel could be called)
        public bool InUse;
    }
}
