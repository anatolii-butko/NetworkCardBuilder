using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkCardBuilder
{
    /// <summary>
    /// The class which contains test steps .
    /// </summary>
    class NetworkCardFlowBuilder : NetworkCardTestTemplate
    {
        #region Fields and Constants

        #endregion

        #region Constructors and Destructors

        #endregion

        #region Properties and Indexers
        
        
        #endregion


        #region Public Methods

        #endregion
        /// <summary>
        /// A method that prepares a network card for testing by determining the number of ports and input speeds.
        /// </summary>        
        protected bool Prepare(DataStructureFwRegister PortCount)  
        {   
            return true; 
        }
            
            
       
        /// <summary>
        /// A method that clears register buffer data.
        /// </summary>
        protected void Clean()
        {
        
        }

        /// <summary>
        /// A method that performs the test case.
        /// </summary>
        protected void Run()
        {
        
        }

    }
}
