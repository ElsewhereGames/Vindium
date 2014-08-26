
#region Using

using System.Runtime.Serialization;

#endregion Using

namespace Elsewhere.Vindinium.Model.HTTP.Contract
{

    /// <summary>
    /// Contains the data contract for the game response.
    /// </summary>
    [DataContract]
    internal sealed class GameResponse
    {

        [DataMember]
        internal Game game = null;

        [DataMember]
        internal Hero hero = null;

        [DataMember]
        internal string token = string.Empty;

        [DataMember]
        internal string viewUrl = string.Empty;

        [DataMember]
        internal string playUrl = string.Empty;

    }
}
