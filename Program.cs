using System;
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

                float sickPeople = task.City.Population * (task.City.SickPercentage * 100.f);
                float deadPeople = sickPeople * (task.City.KillProbability * 100.f);

                return ($"There are {sickPeople} people sick with {task.Virus.Name} in the city of {task.City.Name}, {deadPeople} of which died");
            };

            Task1.CheckSolver(TaskSolver);
        }
    }
}
