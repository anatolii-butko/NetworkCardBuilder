using System;
using System.Collections.Generic;

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
		/// A dictionary that will contain pairs of {key and value} 
		/// where the key is the port number and the value is its speed.
		/// </summary>
		protected virtual Dictionary<DataStructureFwRegister, int> Portsspeeds => new Dictionary<DataStructureFwRegister, int>();

        #endregion

        #region Public Methods

        /// <summary>
        /// A method that sets the ports speeds if all specified ports are active and their speeds are set and meet requirements. 
        /// </summary>
        /// <param>
        /// Method without parametrs.
        /// </param>
        /// <returns>
        /// Returns(bool) true if all ports speeds set, false if at least one port speed is not set.
        /// </returns>
        public virtual bool SetPortSpeed()
        {
            bool retVal = true;
            foreach (KeyValuePair<DataStructureFwRegister, int> item in Portsspeeds)
            {
                retVal &= this.SendAdminCommandSetPort(item.Key, item.Value);
            }
            return retVal;
        }

        /// <summary>
		/// A method that sets the quantity of ports if the all port is active and meet requirements.
		/// </summary>
        /// <param>
		/// Method without parametrs.
		/// </param>
		/// <returns>
		/// Returns(bool) true if port count set, and all ports activated, 
        /// false if port count is not set or at least one port not activated.
		/// </returns>
        public virtual bool SetQuantityOfPorts()
        {
            bool retVal = true;
            // variable portCount requaired quantity of ports
            int portCount = this.Portsspeeds.Count;
            retVal &= portCount != 0 && ((portCount == 1) || (portCount == 2) || (portCount == 4) || (portCount == 8)) && this.SetPortsToActive( out int countOfActivePorts);
            return retVal;
            
        }

        /// <summary>
		/// A method that verifies that port speeds meet compliance requirements and port count not null.
		/// </summary>
        /// <param>
		/// paramname: DataStructureFwRegister key, paramname: int value, 
        /// key is the port number and value is the port speed respectively 
		/// </param>
		/// <returns>
		/// Returns(bool) true if port count set and all ports speeds meet requirements {0; 10; 25; 50; 100}; 
        /// false if at least one port speed do not meet requirements or port count null.
		/// </returns>
        protected bool SendAdminCommandSetPort(DataStructureFwRegister key, int value)
        {
            return key != null && ((value == 0) || (value == 10) || (value == 25) || (value == 50) || (value == 100));
        }

        /// <summary>
        /// A method that verifies that all ports speeds meet compliance requirements and activate it. 
        /// Returns true if the ports count is {1; 2; 4; 8} and ports counts not null.
        /// </summary>
        /// <param>
        /// Method without parametrs.
        /// </param>
        /// <returns>
        /// Returns(bool) true if all ports speeds meet requirements {10; 25; 50; 100}, 
        /// false if at least one port not activated; out(int)countOfActivePorts quantity of activated ports.
        /// </returns>
        protected bool SetPortsToActive( out int countOfActivePorts)
        {
            // variable countOfActivePorts is assigned an initial value of 0 for calculation
            // of the number of activated ports by summation in the cycle.
            countOfActivePorts = 0;
            bool retVal = true;
            foreach (int portSpeed in this.Portsspeeds.Values)
            {
                retVal &= (portSpeed == 10 || portSpeed == 25 || portSpeed == 50 || portSpeed == 100);
                countOfActivePorts += Convert.ToInt32(retVal);
            }
           
            return retVal;
        }

        /// <summary>
        /// A method that calculates total speed of all ports and verifies that meet compliance requirements. 
        /// </summary>
        /// <param>
        /// Method without parametrs.
        /// </param>
        /// <returns>
        /// Returns(bool) true if total speed of all ports is greater than 0 and less than or equal to 100.
        /// false if not.
        /// </returns>
        protected bool TotalPortsSpeed()
        {
            // variable totalSpeed is assigned an initial value of 0 for calculation by summation in the cycle.
            int totalSpeed = 0;
            foreach (int portSpeed in this.Portsspeeds.Values)
            {
                totalSpeed += portSpeed;
            }
            return (totalSpeed > 0) && (totalSpeed <= 100);
        }

        #endregion
    }
}
