using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
    public class WebBrowser
    {
        public int MajorVersion { get; set; }
        public BrowserName Name { get; set; }

        public enum BrowserName
        {
            InternetExplorer,
            Chrome,
            Firefox
        }
    }
}
