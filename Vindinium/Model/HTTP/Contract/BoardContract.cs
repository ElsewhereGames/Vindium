
#region Using

using System.Runtime.Serialization;

#endregion Using

namespace Elsewhere.Vindinium.Model.HTTP.Contract
{

    /// <summary>
    /// Contains the data contract for the game board.
    /// </summary>
    [DataContract]
    internal sealed class Board
    {

        [DataMember]
        internal int size = 0;

        [DataMember]
        internal string tiles = string.Empty;

    }
}
