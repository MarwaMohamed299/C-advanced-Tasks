using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class duration
    {
        public int hours { get; set; }

        public int minutes { get; set; }
        public int seconds { get; set; }
        //public int totalSeconds { get; private set; }

        public duration(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public override string ToString()
        {
            return $" {hours}:{minutes}:{seconds}";

        }
        public duration(int _x)
        {
            this.hours = _x / 3600;
            this.minutes = (_x - (hours * 3600)) / 60;
            this.seconds = (_x - (hours * 3600)) - (minutes * 60);
        }
        public static duration operator +(duration d1, duration d2)
        {
            int totalSeconds = d1.hours * 3600 + d1.minutes * 60 + d1.seconds
                             + d2.hours * 3600 + d2.minutes * 60 + d2.seconds;

            return new duration(totalSeconds);


        }

        //d2
        public static duration operator +(duration d2, int seconds)
        {
            int totalSeconds = d2.hours * 3600 + d2.minutes * 60 + d2.seconds + seconds;
            return new duration(totalSeconds);


        }


        /////d2--  XXXXXXXXXXXXXXXXXXX
        public static duration operator -- (duration d)
        {
            int totalSeconds = d.hours * 3600 + (d.minutes - 1) * 60 + d.seconds;
            return new duration ( totalSeconds);

        }

        //d1>d2
        public static bool operator >(duration d1, duration d2)
        {
            int d1Sec = d1.hours*3600 + d1.minutes*60 + d1.seconds;
            int d2Sec = d2.hours*3600 + d2.minutes*60 + d2.seconds;
            return d1Sec > d2Sec;
        }
        //d2<d1
        public static bool operator <(duration d1, duration d2)
        {
            int d1Sec = d1.hours * 3600 + d1.minutes * 60 + d1.seconds;
            int d2Sec = d2.hours * 3600 + d2.minutes * 60 + d2.seconds;
            return d1Sec < d2Sec;
        }





    }
    
}

