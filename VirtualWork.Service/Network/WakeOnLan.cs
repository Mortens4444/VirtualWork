using System;
using System.Net;
using System.Net.Sockets;

namespace VirtualWork.Service.Network
{
	public class WakeOnLan
	{
		private readonly MacAddressConverter macAddressConverter;
		private readonly MagicPacketForger magicPacketForger;
		
		public WakeOnLan(MacAddressConverter macAddressConverter,
			MagicPacketForger magicPacketForger)
		{
			this.macAddressConverter = macAddressConverter;
			this.magicPacketForger = magicPacketForger;
		}

		public void SendMagicPacket(string macAddress, ushort port = 7)
		{
			if (String.IsNullOrWhiteSpace(macAddress))
			{
				return;
			}
			var endPoint = new IPEndPoint(IPAddress.Broadcast, port);
			using (var clientSocket = new Socket(endPoint.AddressFamily, SocketType.Dgram, ProtocolType.Udp))
			{
				clientSocket.Connect(endPoint);
				var macByteArray = macAddressConverter.StringToByteArray(macAddress);
				var magicPacket = magicPacketForger.Forge(macByteArray);
				clientSocket.Send(magicPacket, 0, magicPacket.Length, SocketFlags.None);
			}
		}
	}
}
