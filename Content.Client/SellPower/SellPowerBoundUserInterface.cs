using Content.Shared.CCVar;
using Content.Shared.Chat;
using Content.Shared.Communications;
using Robust.Client.UserInterface;
using Robust.Shared.Configuration;
using Robust.Shared.Timing;

namespace Content.Client.SellPower
{
    public sealed class SellPowerBoundInterface : BoundUserInterface
    {
        [Dependency] private readonly IConfigurationManager _cfg = default!;

        [ViewVariables]
        private SellPowerMenu? _menu;

        public SellPowerBoundInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
        {

        }

        protected override void Open()
        {
            base.Open();

            _menu = this.CreateWindow<SellPowerMenu>
        }
    }
}
