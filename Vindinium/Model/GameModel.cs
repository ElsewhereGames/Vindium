
#region Using

using System.Collections.Generic;

#endregion Using

namespace Elsewhere.Vindinium.Model
{

    /// <summary>
    /// Encapsulates the data contained in a game. This class is abstract since
    /// each type of game administrator must select its own implementation of 
    /// this class, in case special fields need to be added.
    /// </summary>
    public abstract class GameModel
    {

        #region Life-Cycle

        /// <summary>
        /// Creates a new instance of this game model.
        /// </summary>
        internal GameModel()
        {
            this.heroes = new List<HeroModel>();
        }

        #endregion Life-Cycle

        #region Properties

        #region Id

        public string Id
        {
            get;
            internal set;
        }
        
        #endregion Id

        #region Game State

        #region Total Turns

        public int TotalTurns
        {
            get;
            internal set;
        }

        #endregion Total Turns

        #region Turn

        public int Turn
        {
            get;
            internal set;
        }
        
        #endregion Turn

        #region Heroes

        private List<HeroModel> heroes;

        public IReadOnlyList<HeroModel> Heroes
        {
            get { return this.heroes; }
        }

        internal void AddHero(HeroModel hero)
        {
            this.heroes.Add(hero);
        }

        #endregion Heroes

        #region Finished

        public bool Finished
        {
            get;
            internal set;
        }

        #endregion Finished

        #region Board

        public BoardModel Board
        {
            get;
            internal set;
        }

        #endregion Board

        #endregion Game State

        #endregion Properties

    }
}
