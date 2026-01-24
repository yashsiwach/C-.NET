using System;
using System.ComponentModel;

namespace Game
{
    #region Employee Class

    /// <summary>
    /// Represents an employee with work and activity details.
    /// </summary>
    public class Employee
    {
        #region Properties

        /// <summary>
        /// Employee unique identifier.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Employee name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Indicates whether the employee is currently playing.
        /// </summary>
        public bool isPlaying { get; set; }

        /// <summary>
        /// Number of projects completed by the employee.
        /// </summary>
        public int projectsDone { get; set; }

        /// <summary>
        /// Time taken to complete projects.
        /// </summary>
        public int timeTaken { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new Employee object
        /// with all required details.
        /// </summary>
        /// <param name="id">Employee ID</param>
        /// <param name="name">Employee name</param>
        /// <param name="isPlaying">Playing status</param>
        /// <param name="projectsDone">Projects completed</param>
        /// <param name="timeTaken">Time taken</param>
        public Employee(int id, string name, bool isPlaying, int projectsDone, int timeTaken)
        {
            this.id = id;
            this.name = name;
            this.isPlaying = isPlaying;
            this.projectsDone = projectsDone;
            this.timeTaken = ti
