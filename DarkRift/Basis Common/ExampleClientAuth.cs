using System;
using System.Linq;

public class ExampleClientAuth : IClientAuthChallenge
{
    public string GetPublicIdentity()
    {
        return Environment.MachineName;
    }

    public byte[] RespondToChallenge(byte[] data)
    {
        return data.Reverse().ToArray();
    }
}