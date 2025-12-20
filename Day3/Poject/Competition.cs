using System;

namespace Game
{
    public class Competition
    {
        public int playerID { get; set; }
        public string playerName { get; set; }
        public int matchWon { get; set; }

        public Competition(Employee obj)
        {
            playerID = obj.id;
            playerName = obj.name;
            matchWon = obj.projectsDone / obj.timeTaken;
        }
    }
}
