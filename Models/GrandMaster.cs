using ChessTournament.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.Models
{
    class GrandMaster: IPlayer
    {
        private float _gmtime;

        public float GmTime
        {
            get { return _gmtime; }
            set { _gmtime = value; }
        }

        public void Play()
        {
            Console.WriteLine("Grand Master makes his move");
        }
        public void TimeToPlay()
        {
            this.GmTime = 9.45f;

        }
        public void ToString()
        {
            Console.WriteLine("Grand Master Time " + GmTime);
        }
    }
}
