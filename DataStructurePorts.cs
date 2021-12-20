using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkCardBuilder
{
    /// <summary>
    /// Enum DataStructurePort consists of different states that are responsible for network cards with different number of ports
    /// </summary>
    public enum DataStructurePort
    {
        /// <summary>
        /// FW register which returns quantity of ports for the network card with 1 Port
        /// </summary>
        Port1 = 1,

        /// <summary>
        /// FW register which returns quantity of ports for the network card with 2 Ports
        /// </summary>
        Ports2 = 2,

        /// <summary>
        /// FW register which returns quantity of ports for the network card with 4 Ports
        /// </summary>
        Ports4 = 4,

        /// <summary>
        /// FW register which returns quantity of ports for the network card with 8 Ports
        /// </summary>
        Ports8 = 8
    }
}
