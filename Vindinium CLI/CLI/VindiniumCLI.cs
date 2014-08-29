
#region Using

using System;
using System.Threading;

using Elsewhere.Vindinium.Intelligence.Random;
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


            RandomIntelligence intelligence = new RandomIntelligence();
            while (!game.Finished)
            {
                game = administrator.MoveHero(game, intelligence.DecideDirection(game.Heroes[0], game.Board));
            }
            
            return 0;
        }

    }
}
