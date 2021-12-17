using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkCardBuilder
{
    /// <summary>
    /// The description.
    /// </summary>
    class Ports2Speed10_50Test
	{
        #region Fields and Constants
        /// <summary>
        /// The description.
        /// </summary>
        private new const string TestDescription = "Main Procedure: \n 1. Set PortCount=2" + "\n 2. Set Port00Speed=10" + "\n 3. Set Port01Speed=50" + "\n 4. Perform Reset" + "\n 5. Check PortCount" + "\n 6. Check FW register Port00Speed" + "\n 7. Check FW register Port01Speed" + "\n 8. Check FW register TotalNetworkCardOutcomeSpeed";

        /// <summary>
        /// TotalNetworkCardOutcomeSpeed
        /// </summary>
        private new const string TestName = "Ports2Speed10_50Test";
        #endregion

        #region Constructors and Destructors

        /// <summary>
		/// Initializes a new instance of the <see cref="Ports2Speed10_50Test" /> class.
		/// </summary>
		public Ports2Speed10_50Test() //: base(TestName, TestDescription)
        {

        }

        #endregion

        #region Properties and Indexers

        public int PortCount { get; set; }
        public int Port00Speed = DataStructurePorts.PortCount;
        public int Port01Speed;
        #endregion
    }
    
}
