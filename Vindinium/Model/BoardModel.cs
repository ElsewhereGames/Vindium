namespace Elsewhere.Vindinium.Model
{

    /// <summary>
    /// Encapsulates the data of a game's board.
    /// </summary>
    public class BoardModel
    {

        #region Properties

        #region Tiles

        public string Tiles
        {
            get;
            internal set;
        }

        #endregion Tiles

        #region Size

        public int Size
        {
            get;
            internal set;
        }

        #endregion Size

        #endregion Properties

    }
}
