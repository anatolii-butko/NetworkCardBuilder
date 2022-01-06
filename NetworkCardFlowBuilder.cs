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

		#endregion


		#region Public Methods

		#endregion
		/// <summary>
		/// A method that prepares a network card for testing by determining the 
		/// number of ports and input speeds.
		/// </summary>
		/// <param>
		/// Method without parametrs.
		/// </param>
		/// <returns>
		/// Returns(bool) always returns true if everything goes according to plan.
		/// </returns>

		protected bool Prepare()  
		{
			bool retVal = true;
			retVal &= this.SetQuantityOfPorts();
			retVal &= this.SetPortSpeed();
			
			return retVal;
		}

		/// <summary>
		/// A method that clears register buffer data.
		/// </summary>
		/// <param>
		/// Method without parametrs.
		/// </param>
		/// <returns>
		/// Returns(bool) always returns true if everything goes according to plan.
		/// </returns>
		protected void Clean()
		{
		
		}

		/// <summary>
		/// A method that performs the test case.
		/// </summary>
		/// <param>
		/// Method without parametrs.
		/// </param>
		/// <returns>
		/// Returns(bool) always returns true if everything goes according to plan.
		/// </returns>
		protected bool Run()
		{
			bool retVal = true;
			retVal &= this.TotalPortsSpeed();
			
			return retVal;
		}
	
	}
}
