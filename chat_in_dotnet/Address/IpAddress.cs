namespace chat_in_dotnet.Address;

public class IpAddress
{
    public static String GetIpAddress()
    {
        HttpClient cleint = new HttpClient();
        var ipaddress = cleint.GetStringAsync("https://api.ipify.org/");
        return ipaddress.Result;
    }
}