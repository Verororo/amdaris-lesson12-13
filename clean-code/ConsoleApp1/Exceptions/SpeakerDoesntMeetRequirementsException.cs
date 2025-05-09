﻿namespace BusinessLayer.Exceptions
{
    public class SpeakerDoesntMeetRequirementsException : ArgumentException
    {
        public SpeakerDoesntMeetRequirementsException(string message) : base(message) { }

        public SpeakerDoesntMeetRequirementsException(string format, params object[] args) : base(string.Format(format, args)) { }
    }
}