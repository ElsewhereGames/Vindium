
#region Using

using System;

using Elsewhere.Vindinium.Model;

#endregion Using

namespace Elsewhere.Vindinium.Intelligence.Random
{

    /// <summary>
    /// Moves the hero in a random direction, without regard for winning the 
    /// game or obstacles even.
    /// </summary>
    public class RandomIntelligence : IIntelligence
    {

        #region Components

        private System.Random random;

        #endregion Components

        #region Life-Cycle

        /// <summary>
        /// Creates a new default instance of this random intelligence.
        /// </summary>
        public RandomIntelligence()
        {
            this.random = new System.Random();
        }

        #endregion Life-Cycle

        #region Intelligence

        public Direction DecideDirection(HeroModel hero, BoardModel board)
        {
            Array values = Enum.GetValues(typeof(Direction));
            return (Direction)values.GetValue(random.Next(values.Length));
        }

        #endregion Intelligence

    }
}
