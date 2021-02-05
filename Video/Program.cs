using System;
using System.Linq;

namespace Video
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine();
            var timeToBeRemoved = time
              .Replace(';', '/')
              .Replace('-', ';')
              .Replace('/', '-')
              .Split(';')
              .ToList();
            if (timeToBeRemoved.First() == "0:00:00")
                timeToBeRemoved.Remove("0:00:00");
            else
                timeToBeRemoved[0] = "0:00:00-" + timeToBeRemoved[0];
            if (timeToBeRemoved.Last() == "2:00:00")
                timeToBeRemoved.Remove("2:00:00");
            else
                timeToBeRemoved[timeToBeRemoved.Count - 1] = timeToBeRemoved.Last() + "-2:00:00";
            var finalTime = String.Join(";", timeToBeRemoved);
            if(finalTime[0].ToString() == "0:00:00" && finalTime[1].ToString() == "2:00:00") 
                Console.WriteLine("empty");
        }
    }
}


