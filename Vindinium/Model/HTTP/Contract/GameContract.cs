
#region Using

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion Using

namespace Elsewhere.Vindinium.Model.HTTP.Contract
{

    /// <summary>
    /// Contains the data contract for the game.
    /// </summary>
    [DataContract]
    internal sealed class Game
    {

        [DataMember]
        internal string id = string.Empty;

        [DataMember]
        internal int turn = 0;

        [DataMember]
        internal int maxTurns = 0;

        [DataMember]
        internal List<Hero> heroes = null; 

        [DataMember]
        internal Board board = null;

        [DataMember]
        internal bool finished = false;

    }
}
