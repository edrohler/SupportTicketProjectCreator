using CliFx;
using CliFx.Attributes;
using System.Threading.Tasks;

namespace STPC
{
    [Command]
    public class MainCommand : ICommand
    {
        [CommandParameter(0, Description = "Ticket Id")]
        public int TicketId { get; set; }

        [CommandParameter(1, Description = "Name of Ticket Repository")]
        public string Repository { get; set; }

        [CommandOption("new", 'n', Description = "New Ticket")]
        public bool IsNew { get; set; } = false;

        public async ValueTask ExecuteAsync(IConsole console)
        {
            /****
            ----- Execution -----
                1. If IsNew Then
                    1. cd to repository tickets folder
                    2. mkdir for Ticket Id
                    3. cd ticket id
                    4. dotnet new sln
                    5. mkdir ref src kb kb\img
                    6. git add -A
                    7. git commit -m init
                    8. explorer .
                2. Else
                    1. cd to repository tickets folder
                    2. cd ticket id
                    3. explorer .
            ***/

            await console.Output.WriteLineAsync($"Create New={IsNew} {Repository} Ticket with ID {TicketId}!");
        }
    }
}