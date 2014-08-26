
#region Using

using System.Runtime.Serialization;

#endregion Using

namespace Elsewhere.Vindinium.Model.HTTP.Contract
{

    /// <summary>
    /// Contains the data contract for location information.
    /// </summary>
    [DataContract]
    internal sealed class Pos
    {

        [DataMember]
        internal int x = 0;

        [DataMember]
        internal int y = 0;

    }
}
