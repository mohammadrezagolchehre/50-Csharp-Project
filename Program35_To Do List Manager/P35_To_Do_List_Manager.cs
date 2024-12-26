using System;
using System.Collections.Generic;

class Program
{
    static List<string> todoList = new List<string>();

    static void Main()
    {
        Console.WriteLine("Welcome to the To-Do List Manager!");
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. Remove a task");
            Console.WriteLine("4. Mark task as completed");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    RemoveTask();
                    break;
                case "4":
                    MarkTaskCompleted();
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.WriteLine("Enter a new task:");
        string task = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(task))
        {
            todoList.Add(task);
            Console.WriteLine("Task added successfully!");
        }
        else
        {
            Console.WriteLine("Task cannot be empty.");
        }
    }

    static void ViewTasks()
    {
        if (todoList.Count == 0)
        {
            Console.WriteLine("No tasks available.");
        }
        else
        {
            Console.WriteLine("Your tasks:");
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }
        }
    }

    static void RemoveTask()
    {
        ViewTasks();

        if (todoList.Count > 0)
        {
            Console.WriteLine("Enter the task number to remove:");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= todoList.Count)
            {
                Console.WriteLine($"Task '{todoList[taskNumber - 1]}' removed.");
                todoList.RemoveAt(taskNumber - 1);
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }

    static void MarkTaskCompleted()
    {
        ViewTasks();

        if (todoList.Count > 0)
        {
            Console.WriteLine("Enter the task number to mark as completed:");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= todoList.Count)
            {
                string completedTask = todoList[taskNumber - 1] + " (Completed)";
                todoList[taskNumber - 1] = completedTask;
                Console.WriteLine($"Task '{completedTask}' marked as completed.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }
}
