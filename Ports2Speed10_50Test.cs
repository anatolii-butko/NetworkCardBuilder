using System.Collections.Generic;

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
        /// A dictionary that will contain pairs {key and value} where the key is 
        /// the port number and the value is its speed. 
        /// Overrides the dictionary to access it in class NetworkCardTestTemplate.
        /// </summary>
        protected override Dictionary<DataStructureFwRegister, int> Portsspeeds => new Dictionary<DataStructureFwRegister, int>()
            {
                {DataStructureFwRegister.Port00Speed, 10},
                {DataStructureFwRegister.Port01Speed, 50}
            };
        #endregion

    }

}
