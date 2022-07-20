using System;


namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of Employees.");
            int i = int.Parse(Console.ReadLine());
            string[,] employees = new string[2,i];
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($"Please enter the name of employee number {j+1}.");
                employees[0,j] = Console.ReadLine();
                Console.WriteLine($"Please enter {employees[0, j]}'s salary.");
                employees[1, j] = Console.ReadLine();

            }
            int arrayLength = employees.GetLength(0);
            bool exit = false;
            do
            {
                Console.WriteLine("What would you like to do next?");
                Console.WriteLine("Please press 1 to list all data, press 2 to search an employee, press 3 to hire a new employee, or press 4 to quit");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    for (int k = 0; k < arrayLength; k++)
                    {
                        Console.WriteLine($"{employees[0, k]} receives a salary of {employees[1, k]}.");
                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Please enter an employees's name");
                    string userName = Console.ReadLine();
                    bool found = false;
                    for (int l = 0; l < i; l++)
                    {
                        if (employees[0, l] == userName)
                        {
                            Console.WriteLine($"{userName} is an employee at our company and their salary is {employees[1, l]}");
                            found = true;
                            break;
                        }
                    }
                    if (found == false)
                        Console.WriteLine("We do not have an employee of this name, please enter a valid employee.");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Please enter the new employee's name");
                    string newName = Console.ReadLine();
                    Console.WriteLine($"Please enter {newName}'s salary");
                    string newSalary = Console.ReadLine();
                    string[,] newEmployees = new string[2, arrayLength + 1];
                    for (int x = 0; x < arrayLength; x++)
                    {
                        newEmployees[0,x] = employees[0,x];
                        newEmployees[1, x] = employees[1,x];
                    }
                    newEmployees[0, arrayLength] = newName;
                    newEmployees[1, arrayLength] = newSalary;
                    employees = newEmployees;
                    arrayLength++;
                    Console.WriteLine($"{newName} has been successfully added");
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Thank you for using this service");
                    exit = true;
                    
                }

                else
                    Console.WriteLine("Invalid action, please choose an input from 1-4");
            }
            while (exit == false);
        }
    }
}
