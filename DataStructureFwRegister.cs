using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkCardBuilder
{
    /// <summary>
    /// Enum DataStructureFwRegister consists of different registers for detecting current number of ports and their speeds
    /// </summary>
    public enum DataStructureFwRegister
    {
        /// <summary>
        /// FW register which returns quantity of ports for the network card
        /// </summary>
        PortCount,

        /// <summary>
        /// FW register which returns current speed for port 1
        /// </summary>
        Port00Speed,

        /// <summary>
        /// FW register which returns current speed for port 2
        /// </summary>
        Port01Speed,

        /// <summary>
        /// FW register which returns current speed for port 3
        /// </summary>
        Port02Speed,

        /// <summary>
        /// FW register which returns current speed for port 4
        /// </summary>
        Port03Speed,

        /// <summary>
        /// FW register which returns current speed for port 5
        /// </summary>
        Port04Speed,

        /// <summary>
        /// FW register which returns current speed for port 6
        /// </summary>
        Port05Speed,

        /// <summary>
        /// FW register which returns current speed for port 7
        /// </summary>
        Port06Speed,

        /// <summary>
        /// FW register which returns current speed for port 8
        /// </summary>
        Port07Speed,

    }
}
