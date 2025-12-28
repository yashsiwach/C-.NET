using System;

namespace Game
{
    /// <summary>
    /// Represents a competition participant derived from employee performance metrics.
    /// Maps employee data to player attributes for game-based competition.
    /// </summary>
    public class Competition
    {
        /// <summary>
        /// Gets or sets the unique identifier for the player.
        /// Corresponds to the employee's ID. 
        /// </summary>
        public int playerID { get; set; }

        /// <summary>
        /// Gets or sets the name of the player.
        /// Corresponds to the employee's name. 
        /// </summary>
        public string playerName { get; set; }

        /// <summary>
        /// Gets or sets the number of matches won by the player.
        /// Calculated based on employee's productivity (projects completed per time unit).
        /// </summary>
        public int matchWon { get; set; }

        /// <summary>
        /// Initializes a new instance of the Competition class.
        /// Transforms employee performance data into competition player metrics.
        /// </summary>
        /// <param name="obj">The Employee object containing source data for the player.</param>
        public Competition(Employee obj)
        {
            // Map employee ID to player ID
            playerID = obj.id;
            
            // Map employee name to player name
            playerName = obj.name;
            
            // Calculate matches won based on productivity ratio
            // (number of projects completed divided by time taken)
            matchWon = obj.projectsDone / obj.timeTaken;
        }
    }
}