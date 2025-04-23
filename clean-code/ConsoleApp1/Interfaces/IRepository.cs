using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Classes;

namespace BusinessLayer.Interfaces
{
    public interface IRepository
    {
        public int SaveSpeaker(Speaker speaker);
        public int SaveSpeaker(SpeakerRef speaker);
    }
}
