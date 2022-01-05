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
        /// A method that sets the ports speed. 
        /// Returns true if all specified ports are active and their speeds are set and meet requirements. 
        /// </summary>
        /// <param>
        /// paramname:Dictionary<DataStructureFwRegister, int> portsspeeds, 
        /// which accepts the dictionary of pairs: port number; speed.
        /// </param>
        /// <returns>
        /// Returns(bool) true if all ports speeds set, false if at least one port speed is not set.
        /// </returns>
        public virtual bool SetPortSpeed()
        {
            bool retVal = true;
            foreach (KeyValuePair<DataStructureFwRegister, int> item in Portsspeeds)
            {
                retVal &= SendAdminCommandSetPort(item.Key, item.Value);
            }
            return retVal;
        }

        /// <summary>
		/// A method that sets the quantity of ports. 
        /// Returns true if the all port is active and meet requirements.
		/// </summary>
        /// <param>
		/// paramname: int portCount, number of ports to be set.
		/// </param>
		/// <returns>
		/// Returns(bool) true if port count set, and all ports activated, 
        /// false if port count is not set or at least one port not activated.
		/// </returns>
        public virtual bool SetQuantityOfPorts()
        {
            bool retVal = true;
            retVal &= Portsspeeds.Count != null && ((Portsspeeds.Count == 1) || (Portsspeeds.Count == 2) || (Portsspeeds.Count == 4) || (Portsspeeds.Count == 8)) ? retVal &= SetPortsToActive(Portsspeeds.Count, out int countOfActivePorts) : retVal &= false;
            return retVal;
            
        }

        /// <summary>
		/// A method that verifies that port speeds meet compliance requirements. 
		/// Returns true if the port speed value is {0; 10; 25; 50; 100} and port count not null.
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
		/// A method that verifies that ports counts meet compliance requirements and activate it. 
		/// Returns true if the ports count is {1; 2; 4; 8} and ports counts not null.
		/// </summary>
        /// <param>
		/// Method without parametrs.
		/// </param>
		/// <returns>
		/// Returns(bool) true if all ports meet requirements and activated, 
        /// false if at least one port not activated or not meet requirements;
        /// out(int)countOfActivePorts.
		/// </returns>
        protected bool SetPortsToActive(int count, out int countOfActivePorts)
        {
            countOfActivePorts = 0;
            bool retVal = true;
            foreach (var j in Portsspeeds.Values)
            {
                retVal &= j != null && (j == 10 || j == 25 || j == 50 || j == 100);
                countOfActivePorts += Convert.ToInt32(retVal);
            }
           
            return retVal;
            ICollection<string> = Portsspeeds.Values.ToString;
            string[] speeds;
            void CopyTo(speeds array, int 0);
            for (int j = 0; j < Portsspeeds.Count; j++)
            {
                retVal &= Convert.ToInt32(speeds[j]) != null && (Convert.ToInt32(speeds[j]) == 10 || Convert.ToInt32(speeds[j]) == 25 || Convert.ToInt32(speeds[j]) == 50 || Convert.ToInt32(speeds[j]) == 100);

            }
        }

        #endregion
    }
}
