using System.Net.Sockets;
using System.Text;

namespace chat_in_dotnet.Socket;

public class GetSocket
{
    public static void CreateUdpScocket(string IpToConnect)
    {
        try
        {
            using (UdpClient udpClient = new UdpClient(11000))
            {
                udpClient.Connect(IpToConnect, 11000);
            
                // Sends a message to the host to which you have connected.
                Byte[] sendBytes = Encoding.UTF8.GetBytes("Is anybody there?");

                udpClient.Send(sendBytes, sendBytes.Length);
            }
            
        }catch(SocketException e)
        {
            Console.WriteLine($"error in creating socket: {e.Message}");
        }
    }
}