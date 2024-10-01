using Robust.Shared.Serialization;

namespace Content.Shared.SellPower
{
    [Virtual]
    public partial class SharedSellPowerComponent : Component
    {

    }

    [Serializable, NetSerializable]
    public sealed class SellPowerInterfaceState : BoundUserInterfaceState
    {

    }

    [Serializable, NetSerializable]
    public enum SellPowerUiKey
    {
        Key
    }
}
