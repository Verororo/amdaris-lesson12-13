using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Exceptions;
using BusinessLayer.Interfaces;

namespace BusinessLayer.Classes
{
    public class SpeakerRef
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private int _registrationFee;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                else
                {
                    _firstName = value;
                }
            }
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                else
                {
                    _lastName = value;
                }
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                else
                {
                    _email = value;
                }
            }
        }
        public int? Exp { get; set; }
        public bool HasBlog { get; set; }
        public string BlogURL { get; set; }
        public WebBrowser Browser { get; set; }
        public List<string> Certifications { get; set; }
        public string Employer { get; set; }
        public int? RegistrationFee
        {
            get
            {
                switch (Exp)
                {
                    case null: return null;
                    case <= 1: return 500;
                    case >= 2 and <= 3: return 500;
                    case >= 4 and <= 5: return 250;
                    case >= 6 and <= 9: return 50;
                    default: return 0;
                }
            }
        }
        public List<Session>? Sessions { get; set; }

        public int? Register(IRepository repository)
        {
            int? speakerId = null;

            if (!meetsBasicRequirements() && !meetsAltRequirements())
            {
                throw new SpeakerDoesntMeetRequirementsException("Speaker doesn't meet our abitrary and capricious " +
                    "standards.");
            }

            if (!meetsSessionRequirements())
            {
                throw new NoSessionsApprovedException("No sessions approved.");
            }

            try
            {
                speakerId = repository.SaveSpeaker(this);
            }
            catch (Exception e)
            {
                //in case the db call fails 
            }

            return speakerId;
        }

        public bool meetsBasicRequirements()
        {
            return Exp > 10 || HasBlog || Certifications.Count() > 3 ||
                RequirementsList.ReputableEmployers.Contains(Employer);
        }

        public bool meetsAltRequirements()
        {
            string emailDomain = Email.Split('@').Last();

            return !RequirementsList.UnreputableDomains.Contains(emailDomain) &&
                !(Browser.Name == WebBrowser.BrowserName.InternetExplorer);
        }

        public bool meetsSessionRequirements()
        {
            if (Sessions.Count() == 0)
            {
                return false;
            }

            foreach (var session in Sessions)
            {
                foreach (var tech in RequirementsList.OldTechnologies)
                {
                    if (session.Title.Contains(tech) || session.Description.Contains(tech))
                    {
                        session.Approved = false;
                        return false;
                    }
                    else
                    {
                        session.Approved = true;
                    }
                }
            }

            return true;
        }
    }
}
