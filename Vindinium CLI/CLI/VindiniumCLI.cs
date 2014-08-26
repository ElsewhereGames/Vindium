
#region Using

using System;
using System.Threading;

using Elsewhere.Vindinium.Model;
using Elsewhere.Vindinium.Model.HTTP;

#endregion Using

namespace Elsewhere.Vindinium.CLI
{

    /// <summary>
    /// The entry point for the Vinidium command line interface.
    /// </summary>
    public class VindiniumCLI
    {

        public static int Main(string[] arguments)
        {
            HTTPGameAdministratorModel administrator = new HTTPGameAdministratorModel("http://vindinium.org", "1ejm4403");
            HTTPGameModel game = administrator.StartNewPracticeGame();

            new Thread
            (
                delegate()
                {
                    System.Diagnostics.Process.Start(game.ViewURL);
                }
            ).Start();
            
            Array values = Enum.GetValues(typeof(Direction));
            Random random = new Random();

            while (!game.Finished)
            {
                Direction randomDirection = (Direction)values.GetValue(random.Next(values.Length));
                game = administrator.MoveHero(game, randomDirection);
            }
            
            return 0;
        }

    }
}
