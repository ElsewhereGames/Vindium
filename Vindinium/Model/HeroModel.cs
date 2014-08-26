namespace Elsewhere.Vindinium.Model
{

    /// <summary>
    /// The data model for the AI driven character on the playing board.
    /// </summary>
    public class HeroModel
    {

        #region Properties

        #region Identifiers

        #region Id

        public int Id
        {
            get;
            internal set;
        }

        #endregion Id

        #region Name

        public string Name
        {
            get;
            internal set;
        }

        #endregion Name

        #endregion Identifiers

        #region Performance

        #region Rating

        public int Rating
        {
            get;
            internal set;
        }

        #endregion Rating

        #region Life

        public int Life
        {
            get;
            internal set;
        }

        #endregion Life

        #region Gold

        public int Gold
        {
            get;
            internal set;
        }

        #endregion Gold

        #region Mine Count

        public int MineCount
        {
            get;
            internal set;
        }

        #endregion Mine Count

        #region Crashed

        public bool Crashed
        {
            get;
            internal set;
        }

        #endregion Crashed

        #endregion Performance

        #region Locations

        #region Starting Location

        public LocationModel StartLocation
        {
            get;
            internal set;
        }

        #endregion Starting Location

        #region Current Location

        public LocationModel CurrentLocation
        {
            get;
            internal set;
        }
                
        #endregion Current Location

        #endregion Locations

        #endregion Properties

    }
}
