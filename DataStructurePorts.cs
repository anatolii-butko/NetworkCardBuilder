using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkCardBuilder
{
	class DataStructurePorts
	{
        public enum Workmode
        {
            Port1,
            Ports2,
            Ports4,
            Ports8
        }
        public int RegisterPortsCount(Workmode wm)
            {
            switch (wm)
            {
                case Workmode.Port1:
                {
                    return 1;
                }
                case Workmode.Ports2:
                {
                    return 2;
                }
            
                case Workmode.Ports4:
                {
                    return 4;
                }
                case Workmode.Ports8:
                {
                    return 8;
                }
                default:
                    break;

            }
            }
    }
}
