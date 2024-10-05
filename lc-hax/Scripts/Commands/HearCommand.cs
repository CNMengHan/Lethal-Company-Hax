using System.Threading;
using System.Threading.Tasks;

[Command("hear")]
class HearCommand : ICommand {
    public async Task Execute(string[] args, CancellationToken cancellationToken) {
        Setting.EnableEavesdrop = !Setting.EnableEavesdrop;
        Chat.Print($"Hear: {(Setting.EnableEavesdrop ? "on" : "off")}");
    }
}
