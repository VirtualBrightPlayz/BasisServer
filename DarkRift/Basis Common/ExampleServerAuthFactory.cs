using System.Text;

public class ExampleServerAuthFactory : IServerAuthChallengeFactory
{
    public class ExampleAuthChallenge : ServerAuthChallenge
    {
        public readonly string ID;
        public readonly byte[] EncodedID;

        public ExampleAuthChallenge(string publicIdentity) : base(publicIdentity)
        {
            ID = publicIdentity;
            EncodedID = Encoding.UTF8.GetBytes(ID);
        }

        public override byte[] Serialize()
        {
            return EncodedID;
        }

        public override bool ValidateResponse(byte[] response)
        {
            return response[0] == EncodedID[EncodedID.Length - 1];
        }
    }

    public ServerAuthChallenge CreateAuthChallenge(string publicIdentity)
    {
        return new ExampleAuthChallenge(publicIdentity);
    }
}