
using chat_in_dotnet.Address;
using chat_in_dotnet.Helpers;

namespace chat_in_dotnet;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello, World!");
        //get the ip  
        string MyIpAddress = IpAddress.GetIpAddress();
        Console.WriteLine(MyIpAddress);

        //get the os 
        string MyPlatform = Platform.GetCurrentPlatform();
        Console.WriteLine($"Current platform is {MyPlatform}");
    }
}
