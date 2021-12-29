using System.Collections.Generic;

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
        
		/// <summary>
		/// A dictionary that will contain pairs of {key and value} 
		/// where the key is the port number and the value is its speed.
		/// </summary>
		protected virtual Dictionary<DataStructureFwRegister, int> Portsspeeds => new Dictionary<DataStructureFwRegister, int>();
		
		#endregion


		#region Public Methods

		#endregion
        /// <summary>
		/// A method that prepares a network card for testing by determining the 
		/// number of ports and input speeds.
		/// </summary>        
		protected bool Prepare()  
		{
			bool retVal = true;
			retVal &= this.SetQuantityOfPorts(this.Portsspeeds.Count);
			retVal &= this.SetPortSpeed(this.Portsspeeds);
			
			return retVal;
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
