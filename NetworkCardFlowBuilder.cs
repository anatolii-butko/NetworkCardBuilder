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
		/// A method that prepares a network card for testing by determining the quantity of ports and all ports speeds.
		/// </summary>
		/// <param>
		/// Method without parametrs.
		/// </param>
		/// <returns>
		/// Returns(bool) always returns true if everything goes according to plan, false on the step which failed.
		/// </returns>

		protected bool Prepare()  
		{
			//variable retVal, which is assigned the initial value of true to determine which of the steps of the test will be false.
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
		/// Returns(bool) always returns true if everything goes according to plan, false on the step which failed
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
		/// Returns(bool) always returns true if everything goes according to plan, false on the step which failed
		/// </returns>
		protected bool Run()
		{
			//variable retVal, which is assigned the initial value of true to determine which of the steps of the test will be false.
			bool retVal = true;
			retVal &= this.TotalPortsSpeed();
			
			return retVal;
		}
	
	}
}
