using System;
using System.ComponentModel;
namespace Game
{
    public class Employee
    {
        public int id {get; set;}
        public string name {get; set;}
        public bool isPlaying {get; set;}
        public int projectsDone {get; set;}
        public int timeTaken {get; set;}
        
        public Employee( int id ,string name,bool isPlaying, int projectsDone,int timeTaken)
        {
            this.id=id;
            this.name=name;
            this.isPlaying=isPlaying;
            this.projectsDone=projectsDone;
            this.timeTaken=timeTaken;
        }
    }
}