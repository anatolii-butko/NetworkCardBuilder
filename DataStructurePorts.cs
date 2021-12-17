using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkCardBuilder
{
	class DataStructurePorts
	{
        /// <summary>
        /// Enum PortCount consists of different states that are responsible for network cards with different number of ports
        /// </summary>
        public enum PortCount
        {
            Port1 = 1,
            Ports2 = 2,
            Ports4 = 4,
            Ports8 = 8
        }
        
    }
}
