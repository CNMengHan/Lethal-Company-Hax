using System.Threading;
using System.Threading.Tasks;
using Hax;

[Command("enter")]
class EnterCommand : ICommand {
    public async Task Execute(string[] args, CancellationToken cancellationToken) => Helper.LocalPlayer?.EntranceTeleport(false);
}
