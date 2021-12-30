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

        #endregion

        #region Public Methods

        /// <summary>
        /// A method that sets the ports speed. 
        /// Returns true if all specified ports are active and their speeds are set and meet. 
        /// Always returns true if everything goes according to plan.
        /// </summary>
        /// <param>
        /// paramname:Dictionary<DataStructureFwRegister, int> portsspeeds, 
        /// which accepts the dictionary of pairs: port number; speed.
        /// </param>
        /// <returns>
        /// Simics response return(bool) true if all ports speeds set, 
        /// false if at least one port speed is not set.
        /// </returns>
        public virtual bool SetPortSpeed(Dictionary<DataStructureFwRegister, int> portsspeeds)
        {
            bool retVal = true;
            foreach (KeyValuePair<DataStructureFwRegister, int> item in portsspeeds)
            {
                retVal &= SendAdminCommandSetPort(item.Key, item.Value);
            }
            return retVal;
        }

        /// <summary>
		/// A method that sets the quantity of ports. 
        /// Returns true if the port is active / Always returns true.
		/// </summary>
        /// <param>
		/// paramname: int portCount, number of ports to be set.
		/// </param>
		/// <returns>
		/// Simics response return(bool) true if port count set, 
        /// false if port count is not set.
		/// </returns>
        public virtual bool SetQuantityOfPorts(int portCount)
        {
            bool retVal = true;
            for (int portnum = 1; portnum <= portCount; portnum++)
            { 
                retVal &= SetPortsToActive(portCount, portnum, out int countOfActivePorts);
            }

            return retVal;
            
        }

        /// <summary>
		/// A new method that verifies that port speeds meet compliance requirements. 
		/// Returns true if the port speed value is {0; 10; 25; 50; 100} and port number not null.
		/// </summary>
        /// <param>
		/// paramname: DataStructureFwRegister key, paramname: int value, 
        /// key is the port number and value is the port speed respectively 
		/// </param>
		/// <returns>
		/// Simics response return(bool) true if port count set and all ports speeds meet
        /// requirements {0; 10; 25; 50; 100}; false if at least one port speed do not meet requirements or
        /// port count null.
		/// </returns>
        protected bool SendAdminCommandSetPort(DataStructureFwRegister key, int value)
        {
            return key != null && ((value == 0) || (value == 10) || (value == 25) || (value == 50) || (value == 100));
        }

        /// <summary>
		/// A new method that verifies that ports counts meet compliance requirements. 
		/// Returns true if the ports count is {1; 2; 4; 8} and ports counts not null.
		/// </summary>
        /// <param>
		/// Method without parametrs.
		/// </param>
		/// <returns>
		/// Simics response return(bool).
		/// </returns>
        protected bool SetPortsToActive(int count, int portnum, out int countOfActivePorts)
        {

            if (count != null && ((count == 1) || (count == 2) || (count == 4) || (count == 8)))
            {
                countOfActivePorts = count;
                return true;
                
            }
            else
            {
                countOfActivePorts = 0;
                return false;
                
            }
         
           
        }

        #endregion
    }
}
