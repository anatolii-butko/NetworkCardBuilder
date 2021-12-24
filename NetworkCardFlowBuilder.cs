using System.Collections.Generic;namespace NetworkCardBuilder{
	/// <summary>	/// The class which contains test steps .	/// </summary>    class NetworkCardFlowBuilder : NetworkCardTestTemplate	{
		#region Fields and Constants
		#endregion
		#region Constructors and Destructors
		#endregion
		#region Properties and Indexers        /// <summary>		/// Reads the value of the register, which is responsible for port 1 speed 		/// Overrides the property to access it in class NetworkCardFlowBuilder 		/// </summary>        protected virtual DataStructureFwRegister PortCount => DataStructureFwRegister.PortCount;

		/// <summary>		/// Reads the value of the register, which is responsible for port 1 speed  		/// </summary>        protected virtual DataStructureFwRegister Port00Speed => DataStructureFwRegister.Port00Speed;

		/// <summary>		/// Reads the value of the register, which is responsible for port 1 speed 		/// </summary>        protected virtual DataStructureFwRegister Port01Speed => DataStructureFwRegister.Port01Speed;

		/// <summary>		/// A dictionary that will contain pairs of {key and value} 		/// where the key is the port number and the value is its speed.		/// </summary>
		protected virtual Dictionary<DataStructureFwRegister, int> OurDictionary => new Dictionary<DataStructureFwRegister, int>();

		#endregion

		#region Public Methods
		#endregion        /// <summary>		/// A method that prepares a network card for testing by determining the 		/// number of ports and input speeds.		/// </summary>             protected bool Prepare()  		{			bool retVal = true;			retVal &= this.SetQuantityOfPorts(this.PortCount);			return retVal;			retVal &= this.SetPortSpeed(this.Port00Speed, this.Port01Speed);			return retVal;		}						/// <summary>		/// A method that clears register buffer data.		/// </summary>		protected void Clean()		{				}		/// <summary>		/// A method that performs the test case.		/// </summary>		protected void Run()		{				}	}}