namespace Elsewhere.Vindinium.Model
{

    /// <summary>
    /// 
    /// <para>
    /// The interface for the class which administers games. It is in charge of
    /// creating new games and maintaining the state of the game.
    /// </para>
    /// 
    /// <para>
    /// For simplicity, implementing classes could implement this interface with
    /// only one active game at a time, although this interface does also leave
    /// room for multiple concurrent games.
    /// </para>
    /// 
    /// </summary>
    public interface GameAdministratorModel<GameModelType> 
        where GameModelType : GameModel
    {

        #region Game Creation

        /// <summary>
        /// Called to start a new official game.
        /// </summary>
        /// <returns>The newly started game.</returns>
        GameModelType StartNewGame();

        /// <summary>
        /// Called to start a new pratice game.
        /// </summary>
        /// <returns>The newly started pratice game.</returns>
        GameModelType StartNewPracticeGame();

        #endregion Game Creation

        #region Game Movement

        /// <summary>
        /// Move the hero of the specified game in the specified direction.
        /// </summary>
        /// <param name="game">The game for which to move the hero in the specified direction.</param>
        /// <param name="direction">The direction to move the hero into.</param>
        /// <returns></returns>
        GameModelType MoveHero(GameModelType game, Direction direction);

        #endregion Game Movement

    }
}
