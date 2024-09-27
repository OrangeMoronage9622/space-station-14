using Content.Shared.Access.Components;
using Content.Shared.Access.Systems;
using Content.Shared.CCVar;
using Content.Shared.Chat;
using Content.Shared.Communications;
using Content.Shared.Database;
using Content.Shared.DeviceNetwork;
using Content.Shared.Emag.Components;
using Content.Shared.IdentityManagement;
using Content.Shared.Popups;
using Robust.Shared.Configuration;
// I know absolutely most of these aren't needed but I don't care. I'm stealing communicationconsole code for this.
namespace Content.Server.SellPower
{
    public sealed class SellPowerSystem : EntitySystem
    {
        [Dependency] private readonly IConfigurationManager _cfg = default!;
    }
}
