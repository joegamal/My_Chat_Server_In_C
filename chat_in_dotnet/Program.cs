
using chat_in_dotnet.Address;

namespace chat_in_dotnet;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello, World!");
        //get the ip of the 
        string MyIpAddress = IpAddress.GetIpAddress();
        Console.WriteLine(MyIpAddress);
    }
}
