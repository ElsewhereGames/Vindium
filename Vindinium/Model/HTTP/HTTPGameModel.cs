

namespace Elsewhere.Vindinium.Model.HTTP
{

    /// <summary>
    /// Represents a game model with the extra data elements presented when
    /// playing a game over a web server.
    /// </summary>
    public sealed class HTTPGameModel : GameModel
    {

        #region Properties

        #region Game URL

        public string GameURL
        {
            get;
            internal set;
        }

        #endregion Game URL

        #region View URL

        public string ViewURL
        {
            get;
            internal set;
        }

        #endregion View URL
        
        #endregion Properties

    }
}
