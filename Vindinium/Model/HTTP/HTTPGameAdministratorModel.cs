
#region Using

#region System

using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

#endregion System

#region Elsewhere

using Elsewhere.Vindinium.Model.HTTP.Contract;

#endregion Elsewhere

#endregion Using

namespace Elsewhere.Vindinium.Model.HTTP
{

    public class HTTPGameAdministratorModel : GameAdministratorModel<HTTPGameModel>
    {

        #region Constants

        private static readonly string TRAINING_DIRECTORY = "/api/training";
        private static readonly string ARENA_DIRECTORY = "/api/arena";

        private static readonly string HTTP_CONTENT_TYPE = "application/x-www-form-urlencoded";

        #endregion Constants

        #region Life-Cycle

        /// <summary>
        /// Creates a new instance of this HTTP-based game administrator model.
        /// </summary>
        /// <param name="address">The server address where the administrator resides.</param>
        /// <param name="key">The key to identify this client with.</param>
        public HTTPGameAdministratorModel(string address, string key)
        {
            this.address = address;
            this.key = key;
        }

        #endregion Life-Cycle

        #region Properties

        #region Address

        private string address;

        public string Address
        {
            get { return this.address; }
        }

        #endregion Address

        #region Key

        private string key;

        public string Key
        {
            get { return this.key; }
        }

        #endregion Key
        
        #endregion Properties

        #region Operations

        #region Game Creation

        public HTTPGameModel StartNewGame()
        {
            string uri = this.address + HTTPGameAdministratorModel.ARENA_DIRECTORY;
            return this.StartGame(uri);
        }

        public HTTPGameModel StartNewPracticeGame()
        {
            string uri = this.address + HTTPGameAdministratorModel.TRAINING_DIRECTORY;
            return this.StartGame(uri);
        }

        private HTTPGameModel StartGame(string uri)
        {
            string parameters = "key=" + this.key;
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = HTTPGameAdministratorModel.HTTP_CONTENT_TYPE;
                    string json = client.UploadString(uri, parameters);
                    return this.ProcessResponse(json);
                }
            }

            catch (WebException webException)
            {
                throw new InvalidOperationException("Unable to start a new game: " + webException.Message);
            }
        }

        #endregion Game Creation

        #region Game Movement

        public HTTPGameModel MoveHero(HTTPGameModel game, Direction direction)
        {
            string parameters = "key=" + this.key + "&dir=" + direction.ToString();
            
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = HTTPGameAdministratorModel.HTTP_CONTENT_TYPE;
                    string json = client.UploadString(game.GameURL, parameters);
                    return this.ProcessResponse(json);
                }
            }

            catch (WebException webException)
            {
                throw new InvalidOperationException("Unable to make a move: " + webException.Message);
            }
        }

        #endregion Game Movement

        #region Server Interaction

        private HTTPGameModel ProcessResponse(string json)
        {
            byte[] jsonBytes = Encoding.UTF8.GetBytes(json);
            MemoryStream jsonStream = new MemoryStream(jsonBytes);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Contract.GameResponse));
            Contract.GameResponse response = serializer.ReadObject(jsonStream) as Contract.GameResponse;

            HTTPGameModel model = response.game.ToModel();
            model.GameURL = response.playUrl;
            model.ViewURL = response.viewUrl;

            return model;
        }

        #endregion Server Interaction
        
        #endregion Operations

    }
}
