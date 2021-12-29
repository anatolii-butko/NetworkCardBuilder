using System.Collections.Generic;

namespace NetworkCardBuilder
{
    /// <summary>
    /// The class which used as template for testing .
    /// </summary>
    public class NetworkCardTestTemplate
    {
        public IEnumerable<KeyValuePair<DataStructureFwRegister, int>> Portsspeeds { get; private set; }
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
		/// A new method that verifies that port speeds meet compliance requirements. 
		/// Returns true if the port speed value is {0; 10; 25; 50; 100} and port number not null.
		/// </summary>

        protected bool SendAdminCommandSetPort(DataStructureFwRegister key, int value)
        {
            bool retVal = true;
            retVal &= key != null && ((value == 0) || (value == 10) || (value == 25) || (value == 50) || (value == 100));
            ///Other method realization
            /// retVal &= (key == null) ? false : (value == 10) ? true : (value == 25) ? true : (value == 50) ? true : (value == 100) ? true : false;
            return retVal;
        }

        /// <summary>
		/// A old unsed method that verifies that port speeds meet compliance requirements. 
		/// Returns true if the port speed value is {0; 10; 25; 50; 100}.
		/// </summary>
        protected bool SendAdminCommandSetPort_Old(DataStructureFwRegister key, int value)
        {
            bool retVal = true;
            if (key == null)
            {
                retVal &= false;
            }
            switch (value)
            {
                case 0:
                    retVal &= true;
                    break;
                case 10:
                    retVal &= true;
                    break;
                case 25:
                    retVal &= true;
                    break;
                case 50:
                    retVal &= true;
                    break;
                case 100:
                    retVal &= true;
                    break;
                default:
                    retVal &= true;
                    break;
            }
            return retVal;

        }

        
        #endregion
    }
}
