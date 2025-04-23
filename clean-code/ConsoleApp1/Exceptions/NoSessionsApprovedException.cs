namespace BusinessLayer.Exceptions
{
    public class NoSessionsApprovedException : SpeakerDoesntMeetRequirementsException
    {
        public NoSessionsApprovedException(string message) : base(message) { }
    }
}