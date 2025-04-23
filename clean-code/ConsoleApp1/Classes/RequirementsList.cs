using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
    public static class RequirementsList
    {
        public static List<string> ReputableEmployers = new List<string> { "Microsoft", "Google", "Fog Creek Software", "37Signals" };
        public static List<string> UnreputableDomains = new List<string>() { "aol.com", "hotmail.com", "prodigy.com", "CompuServe.com" };
        public static List<string> OldTechnologies = new List<string>() { "Cobol", "Punch Cards", "Commodore", "VBScript" };
    }
}
