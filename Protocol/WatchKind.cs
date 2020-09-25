using System;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    [Flags]
    public enum WatchKind
    {
        /**
         * Interested in create events.
         */
        Create = 1,

        /**
         * Interested in change events
         */
        Change = 2,

        /**
         * Interested in delete events
         */
        Delete = 4
    }
}
