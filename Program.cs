﻿using ChessTournament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            p1.Play();
            p1.TimeToPlay();
            p1.ToString();
           
        }
    }
}
