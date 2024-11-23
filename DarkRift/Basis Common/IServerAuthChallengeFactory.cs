public interface IServerAuthChallengeFactory
{
    ServerAuthChallenge CreateAuthChallenge(string publicIdentity);
}