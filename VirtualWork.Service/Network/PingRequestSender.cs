using System;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using LanguageService;
using MessageBoxes;

namespace VirtualWork.Service.Network
{
	public class PingRequestSender
	{
		/// <summary>
		/// Send a ping request to a host.
		/// </summary>
		/// <param name="ipAddress">The IP address of the tested device.</param>
		/// <param name="data">Data to send with the ping request.</param>
		/// <param name="timeout">Timeout to send a request.</param>
		/// <returns>The error message if the ping failed, otherwise an empty string.</returns>
		public string Send(string ipAddress, string data = "ping", int timeout = 120)
		{
			if (String.IsNullOrEmpty(ipAddress))
			{
				throw new ArgumentException("The IP address must be filled.", nameof(ipAddress));
			}

			var pingSender = new Ping();
			var options = new PingOptions();
			var buffer = Encoding.ASCII.GetBytes(data);

			var reply = pingSender.Send(ipAddress, timeout, buffer, options);
			if (reply.Address.AddressFamily == AddressFamily.InterNetwork)
			{
				if (reply.Status == IPStatus.DestinationProtocolUnreachable)
				{
					return "The ICMP echo request failed because the destination computer that is specified in an ICMP echo message is not reachable,\nbecause it does not support the packet's protocol.";
				}
			}
			else if (reply.Address.AddressFamily == AddressFamily.InterNetworkV6)
			{
				if (reply.Status == IPStatus.DestinationProhibited)
				{
					return "The ICMP echo request failed because contact with the destination computer is administratively prohibited.";
				}
			}

			switch (reply.Status)
			{
				case IPStatus.Success:
					return String.Empty;

				case IPStatus.DestinationNetworkUnreachable:
					return "The ICMP echo request failed because the network that contains the destination computer is not reachable.";

				case IPStatus.DestinationHostUnreachable:
					return "The ICMP echo request failed because the destination computer is not reachable.";

				case IPStatus.DestinationPortUnreachable:
					return "The ICMP echo request failed because the port on the destination computer is not available.";

				case IPStatus.NoResources:
					return "The ICMP echo request failed because of insufficient network resources.";

				case IPStatus.BadOption:
					return "The ICMP echo request failed because it contains an invalid option.";

				case IPStatus.HardwareError:
					return "The ICMP echo request failed because of a hardware error.";

				case IPStatus.PacketTooBig:
					return "The ICMP echo request failed because the packet containing the request is larger than the maximum transmission unit (MTU) of\na node (router or gateway) located between the source and destination.\nThe MTU defines the maximum size of a transmittable packet.";

				case IPStatus.TimedOut:
					return "The ICMP echo Reply was not received within the allotted time. The default time allowed for replies is 5 seconds.\nYou can change this value using the Send or SendAsync methods that take a timeout parameter.";

				case IPStatus.BadRoute:
					return "The ICMP echo request failed because there is no valid route between the source and destination computers.";

				case IPStatus.TtlExpired:
					return "The ICMP echo request failed because its Time to Live (TTL) value reached zero, causing the forwarding node (router or gateway) to discard the packet.";

				case IPStatus.TtlReassemblyTimeExceeded:
					return "The ICMP echo request failed because the packet was divided into fragments for transmission and all of the fragments were not\nreceived within the time allotted for reassembly. RFC 2460 (available at www.ietf.org)\nspecifies 60 seconds as the time limit within which all packet fragments must be received.";

				case IPStatus.ParameterProblem:
					return "The ICMP echo request failed because a node (router or gateway) encountered problems while processing the packet header.\nThis is the status if, for example, the header contains invalid field data or an unrecognized option.";

				case IPStatus.SourceQuench:
					return "The ICMP echo request failed because the packet was discarded. This occurs when the source computer's output queue has insufficient storage space,\nor when packets arrive at the destination too quickly to be processed.";

				case IPStatus.BadDestination:
					return "The ICMP echo request failed because the destination IP address cannot receive ICMP echo requests\nor should never appear in the destination address field of any IP datagram.\nFor example, calling Send and specifying IP address \"000.0.0.0\" returns this status.";

				case IPStatus.DestinationUnreachable:
					return "The ICMP echo request failed because the destination computer that is specified in an ICMP echo message is not reachable;\nthe exact cause of problem is unknown.";

				case IPStatus.TimeExceeded:
					return "The ICMP echo request failed because its Time to Live (TTL) value reached zero, causing the forwarding node\n(router or gateway) to discard the packet.";

				case IPStatus.BadHeader:
					return "The ICMP echo request failed because the header is invalid.";

				case IPStatus.UnrecognizedNextHeader:
					return "The ICMP echo request failed because the Next Header field does not contain a recognized value.\nThe Next Header field indicates the extension header type (if present) or the protocol above the IP layer, for example, TCP or UDP.";

				case IPStatus.IcmpError:
					return "The ICMP echo request failed because of an ICMP protocol error.";

				case IPStatus.DestinationScopeMismatch:
					return "The ICMP echo request failed because the source address and destination address\nthat are specified in an ICMP echo message are not in the same scope.\nThis is typically caused by a router forwarding a packet using an interface\nthat is outside the scope of the source address. Address scopes (link-local, site-local, and global scope) determine where on the network an address is valid.";

				case IPStatus.Unknown:
				default:
					return "The ICMP echo request failed for an unknown reason.";
			}
		}

		public void SendAndShowResult(string ipAddress)
		{
			var pingError = Send(ipAddress);
			if (String.IsNullOrEmpty(pingError))
			{
				InfoBox.Show(Lng.Elem("Ping successful"), Lng.Elem("The ping request found the host."));
			}
			else
			{
				ErrorBox.Show(Lng.Elem("Ping failed"), $"{Lng.Elem("The ping request could not find the target host.")}{Environment.NewLine}{Lng.Elem(pingError)}");
			}
		}
	}
}
