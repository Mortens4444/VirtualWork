using System;
using System.Collections.Generic;
using System.Net;

namespace VirtualWork.Service.Network
{
	public class HostnameProvider
	{
		private delegate IPHostEntry GetHostNameCallback(string hostname);
		
		#pragma warning disable 1062
		private readonly IEnumerable<GetHostNameCallback> GetHostNameCallbacks = new List<GetHostNameCallback> { Dns.GetHostEntry, Dns.GetHostByAddress };
		#pragma warning restore 1062

		public string GetHostName(string ipAddress)
		{
			if (!String.IsNullOrEmpty(ipAddress))
			{
				foreach (var GetHostName in GetHostNameCallbacks)
				{
					try
					{
						return GetHostName(ipAddress).HostName;
					}
					catch
					{
					}
				}
			}
			return ipAddress;
		}
	}
}