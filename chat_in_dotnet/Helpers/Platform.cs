using System.Runtime.InteropServices;

namespace chat_in_dotnet.Helpers;

public class Platform
{
    public static string GetCurrentPlatform()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) 
            return "windows";
        
        
        return "linux";
    }
}