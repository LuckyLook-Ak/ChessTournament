using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.Models
{
    class Games
    {
        private double _time;

        public double Time
        {
            get { return _time; }
            set { _time = value; }
        }
        public void GameTime()
        {
            this.Time = 10;
        }
        public void GmTime()
        {
            this.Time = 9.45;
        }

    }
}
