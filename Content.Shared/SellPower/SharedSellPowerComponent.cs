using Robust.Shared.Serialization;

namespace Content.Shared.SellPower
{
    [Virtual]
    public partial class SharedSellPowerComponenet : component
    {

    }

    [Serializable, NetSerializable]
    public sealed class SellPowerInterfaceState : BoundUserInterfaceState
    {

    }
    [Serializable, NetSerializable]
    public enum CommunicationsConsoleUiKey
    {
        Key
    }
}
