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
        /// Returns true if the port is active / Always returns true.
        /// </summary>
        public virtual bool SetPortSpeed(Dictionary<DataStructureFwRegister, int> OurDictionary)
        { 
            
            return true;
        }

        /// <summary>
		/// A method that sets the quantity of ports. 
        /// Returns true if the port is active / Always returns true.
		/// </summary>
        public virtual bool SetQuantityOfPorts(Dictionary<DataStructureFwRegister, int> OurDictionary.Count)
        {
            
            return true;
        }
        #endregion
    }
}
