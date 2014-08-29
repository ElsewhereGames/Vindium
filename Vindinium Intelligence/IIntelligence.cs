
#region Using

using Elsewhere.Vindinium.Model;

#endregion Using

namespace Elsewhere.Vindinium.Intelligence
{

    /// <summary>
    /// This interface defines the operations an intelligence must implement in
    /// order for an application to use it to pick a direction to move in at the 
    /// start of each turn.
    /// </summary>
    public interface IIntelligence
    {

        #region Operations

        /// <summary>
        /// Decide on which direction the specified hero should move. Note that
        /// this operation cannot change either the hero or the board directly
        /// (there are no modifiers visible to do so), and that the direction 
        /// is applied by a component different than this intelligence.
        /// </summary>
        /// <param name="hero">The hero to move.</param>
        /// <param name="board">The board the hero is on.</param>
        /// <returns>A direction for the hero to move in.</returns>
        Direction DecideDirection(HeroModel hero, BoardModel board);

        #endregion Operations

    }
}
