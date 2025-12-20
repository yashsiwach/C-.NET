using System;
using System.Collections;

namespace Game
{
    public class Result
    {
        public void Playing(Employee[] arr, int size)
        {
            ArrayList part = new ArrayList();

            for (int i = 0; i < size; i++)
            {
                if (arr[i].isPlaying)
                {
                    Competition obj = new Competition(arr[i]);
                    part.Add(obj);
                }
            }

            part.Sort(new MatchWonComparer());
            foreach (object i in part)
            {
                Competition c = (Competition)i;
                Console.WriteLine(c.playerID + " " + c.playerName + " " + c.matchWon);
            }

        }
    }
}
