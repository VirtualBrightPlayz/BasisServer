public abstract class ServerAuthChallenge
{
    // publicIdentity is a public identifier of the client
    public ServerAuthChallenge(string publicIdentity)
    {}

    // Serialize the challenge to be sent to the client
    public abstract byte[] Serialize();

    // Validate the response from the client, returns true when successful, false otherwise
    public abstract bool ValidateResponse(byte[] response);
}