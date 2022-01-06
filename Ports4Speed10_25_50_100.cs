using System.Collections.Generic;

namespace NetworkCardBuilder
{
    /// <summary>
    /// The TestCase claass with input data: Port1 speed 10, Port2 speed 25, Port3 speed 50, Port4 speed 100.
    /// </summary>
    class Ports4Speed10_25_50_100Test : NetworkCardFlowBuilder
    {
        #region Fields and Constants
        /// <summary>
        /// The description.
        /// </summary>
        private new const string TestDescription = "Main Procedure: \n 1. Set PortCount, Set Port##Speed" + "\n 2. Perform Reset" + "\n 3. Check PortCount, Check FW registers Port##Speed";

        /// <summary>
        /// Name.
        /// </summary>
        private new const string TestName = "Ports4Speed10_25_50_100Test";


        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Ports4Speed10_25_50_100Test" /> class.
        /// </summary>
        public Ports4Speed10_25_50_100Test() //: base(TestName, TestDescription)
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
                {DataStructureFwRegister.Port01Speed, 25},
                {DataStructureFwRegister.Port02Speed, 50},
                {DataStructureFwRegister.Port03Speed, 100}
            };
        #endregion

    }

}
