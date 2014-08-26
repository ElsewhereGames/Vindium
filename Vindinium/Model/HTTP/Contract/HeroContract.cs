
#region Using

using System.Runtime.Serialization;

#endregion Using

namespace Elsewhere.Vindinium.Model.HTTP.Contract
{

    /// <summary>
    /// Contains the data contract for the hero object.
    /// </summary>
    [DataContract]
    internal sealed class Hero
    {

        [DataMember]
        internal int id = 0;

        [DataMember]
        internal string name = string.Empty; 

        [DataMember]
        internal int elo = 0;

        [DataMember]
        internal Pos pos = null;

        [DataMember]
        internal int life = 0;

        [DataMember]
        internal int gold = 0;

        [DataMember]
        internal int mineCount = 0;

        [DataMember]
        internal Pos spawnPos = null;

        [DataMember]
        internal bool crashed = false;

    }
}
