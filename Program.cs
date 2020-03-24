using System;
using System.Runtime;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task1, string> TaskSolver = task =>
            {
                // Your solution goes here
                // You can get all needed inputs from task.[Property]
                // Good luck!
                float sickPeople = float.Parse(task.City.Population) * float.Parse(task.City.SickPercentage);
                float deadPeople = sickPeople * float.Parse(task.Virus.KillProbability);

                return ($"There are {Math.Truncate(sickPeople)} people sick with {task.Virus.Name} in the city of {task.City.Name}, {Math.Truncate(deadPeople)} of which died");
            };

            Task1.CheckSolver(TaskSolver);
        }
    }
}
