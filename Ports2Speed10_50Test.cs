using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkCardBuilder
{
    /// <summary>
    /// The TestCase claass with input data: Port1 speed 10, Port2 speed 50.
    /// </summary>
    class Ports2Speed10_50Test : NetworkCardFlowBuilder
	{
        #region Fields and Constants
        /// <summary>
        /// The description.
        /// </summary>
        private new const string TestDescription = "Main Procedure: \n 1. Set PortCount, Set Port##Speed" + "\n 2. Perform Reset" + "\n 3. Check PortCount, Check FW registers Port##Speed";

        /// <summary>
        /// Name.
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
        /// <summary>
		/// Reads the value of the register, which is responsible for the mode of operation of the network card
		/// </summary>
        protected DataStructureFwRegister PortCount = DataStructureFwRegister.PortCount;

        /// <summary>
		/// Reads the value of the register, which is responsible for port 1 speed 
		/// </summary>
        protected DataStructureFwRegister Port00Speed = DataStructureFwRegister.Port00Speed;

        /// <summary>
		/// Reads the value of the register, which is responsible for port 1 speed 
		/// </summary>
        protected DataStructureFwRegister Port01Speed = DataStructureFwRegister.Port01Speed;


        #endregion
    }
    
}
