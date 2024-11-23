public interface IClientAuthChallenge
{
    string GetPublicIdentity();

    // data is the serialized challenge from the server
    // the returned byte[] will be sent back to the server for verification
    byte[] RespondToChallenge(byte[] data);
}