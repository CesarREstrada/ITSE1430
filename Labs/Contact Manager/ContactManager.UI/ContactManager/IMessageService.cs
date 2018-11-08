// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// ICMessageService.cs

using System.Collections.Generic;

namespace ContactManager
{
	/// <summary>Provides services for sending messages.</summary>
	public interface IMessageService
	{
		void Send (string emailAddress, string subject, string message);
	}
}
