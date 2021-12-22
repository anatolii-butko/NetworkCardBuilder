using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkCardBuilder
{
    /// <summary>
    /// The class which used as template for testing .
    /// </summary>
    public class NetworkCardTestTemplate
    {
        #region Fields and Constants

        #endregion

        #region Constructors and Destructors

        #endregion

        #region Properties and Indexers
        /// <summary>
		/// Reads the value of the register, which is responsible for port 1 speed 
		/// Overrides the property to access it in class NetworkCardFlowBuilder 
        /// </summary>
        protected virtual DataStructureFwRegister PortCount => DataStructureFwRegister.PortCount;

        /// <summary>
		/// Reads the value of the register, which is responsible for port 1 speed 
		/// Overrides the property to access it in class NetworkCardFlowBuilder 
        /// </summary>
        protected virtual DataStructureFwRegister Port00Speed => DataStructureFwRegister.Port00Speed;

        /// <summary>
		/// Reads the value of the register, which is responsible for port 1 speed 
		/// Overrides the property to access it in class NetworkCardFlowBuilder 
        /// </summary>
        protected virtual DataStructureFwRegister Port01Speed => DataStructureFwRegister.Port01Speed;
        
        #endregion

        #region Public Methods
        /// <summary>
        /// A method that sets the ports speed. Returns true if the port is active / Always returns true.
        /// </summary>
        public bool SetPortSpeed(DataStructureFwRegister Port00Speed, DataStructureFwRegister Port01Speed)
        { 
            return true;
        }

        /// <summary>
		/// A method that sets the quantity of ports. Returns true if the port is active / Always returns true.
		/// </summary>
        public bool SetQuantityOfPorts( DataStructureFwRegister PortCount)
        {
            return true;
        }
        #endregion
    }
}
