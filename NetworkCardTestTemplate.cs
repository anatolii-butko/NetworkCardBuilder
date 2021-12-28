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
        /// A dictionary that will contain pairs of {key and value} 
        /// where the key is the port number and the value is its speed.
        /// </summary>
        protected virtual Dictionary<DataStructureFwRegister, int> Portsspeeds => new Dictionary<DataStructureFwRegister, int>();

        /// <summary>
        /// A method that sets the ports speed. 
        /// Returns true if the port is active / Always returns true.
        /// </summary>
        public virtual bool SetPortSpeed(Dictionary<DataStructureFwRegister, int> portsspeeds)
        {
            bool retVal = true;
            foreach (KeyValuePair<DataStructureFwRegister, int> item in this.Portsspeeds)
            {
                
                retVal &= SendAdminCommandSetPort(item.Key, item.Value);
                

            }
            return retVal;
        }

        /// <summary>
		/// A method that sets the quantity of ports. 
        /// Returns true if the port is active / Always returns true.
		/// </summary>
        public virtual bool SetQuantityOfPorts(int portCount)
        {
            
            return true;
        }

        /// <summary>
		/// A method that verifies that port speeds meet compliance requirements. 
		/// Returns true if the port speed value is {0; 10; 25; 50; 100}.
		/// </summary>
        protected bool SendAdminCommandSetPort(DataStructureFwRegister key, int value)
        {
            bool retVal = true;
            bool result1, result2;
            if (key != null)
            {
                result1 = true;
            }
            else
            {
                result1 = false;
            }
            retVal &= result1;

            switch (value)
            {
                case 0:
                    result2 = true;
                    break;
                case 10:
                    result2 = true;
                    break;
                case 25:
                    result2 = true;
                    break;
                case 50:
                    result2 = true;
                    break;
                case 100:
                    result2 = true;
                    break;
                default:
                    result2 = false;
                    break;
            }
            retVal &= result2;

            return retVal;

        }

        /// <summary>
        /// A method that clears register buffer data.
        /// </summary>
        #endregion
    }
}
