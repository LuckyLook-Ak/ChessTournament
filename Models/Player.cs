using ChessTournament.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.Models
{
    class Player : IPlayer
    {
        private float _time;

        public float Time
        {
            get { return _time; }
            set { _time = value; }
        }
        public void TimeToPlay()
        {
            this.Time = 10;
        }
        public void Play()
        {
            Console.WriteLine("Player makes his move");
        }
        public  void ToString()
        {
            Console.WriteLine("Normal player Time " + Time);
        }



    }
}
