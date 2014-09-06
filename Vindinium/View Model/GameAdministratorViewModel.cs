
#region Using

using Microsoft.Practices.Prism.Commands;

#endregion Using

namespace Elsewhere.Vindinium.ViewModel
{
    
    public class GameAdministratorViewModel
    {

        #region Life-Cycle

        /// <summary>
        /// Creates a new instance of the game administrator.
        /// </summary>
        public GameAdministratorViewModel()
        {
            this.RegisterCommands();
        }

        #endregion Life-Cycle

        #region Commands

        #region Command Registration

        // Creates all command objects and their delegate references.
        private void RegisterCommands()
        {
            this.StartGameCommand = new DelegateCommand(this.StartGame, this.CanStartGame);
            this.StartPracticeCommand = new DelegateCommand(this.StartPractice, this.CanStartPractice);
        }

        #endregion Command Registration

        #region Start New Game

        public DelegateCommand StartGameCommand
        {
            get;
            private set;
        }

        public bool CanStartGame()
        {
            return false;
        }

        public void StartGame()
        {

        }

        #endregion Start New Game

        #region Start New Practice

        public DelegateCommand StartPracticeCommand
        {
            get;
            private set;
        }

        public bool CanStartPractice()
        {
            return false;
        }

        public void StartPractice()
        {

        }

        #endregion Start New Practice
        
        #endregion Command

    }
}
