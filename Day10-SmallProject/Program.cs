using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagement{
    class Program{
         // Main method: Entry point of the application
    public static async Task Main(string[] args){
        var repo = new TaskRepository(); // Instantiate the repository
        bool running = true;

        while (running){
            Console.WriteLine("\nTask Manager");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Update Task");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice){
                case "1":
                    await AddTask(repo);
                    break;
                case "2":
                    await ViewTasks(repo);
                    break;
                case "3":
                    await UpdateTask(repo);
                    break;
                case "4":
                    await DeleteTask(repo);
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
        //view Tasks
    static async Task ViewTasks(TaskRepository repo){
        var tasks = await repo.GetTasksAsync();
        if (tasks.Count == 0){
            Console.WriteLine("No tasks found");
        } else{
            Console.WriteLine("Your tasks: ");
            foreach (var task in tasks){
                string status = task.Completed ? "Completed" : "Active";
                Console.WriteLine($"ID: {task.id}, Title: {task.Title}, Description: {task.Description}, Status: {status}");

            }
        }
    }
        //add task
    static async Task AddTask(TaskRepository repo){
        Console.Write("Enter task title: ");
        string title = Console.ReadLine();

        Console.Write("Enter task description: ");
        string description = Console.ReadLine();

        await repo.addTaskAsync(new TaskItem{
            Title = title,
            Description = description,
        });

        Console.WriteLine("Task added successfully");
    }
        //update task
    static async Task UpdateTask(TaskRepository repo)
    {
        Console.Write("Enter the task ID to update: ");
        int id = int.Parse(Console.ReadLine());

        try
        {
            await repo.UpdateTaskAsync(id, task =>
            {
                Console.Write("Update title (leave empty to skip): ");
                string newTitle = Console.ReadLine();
                if (!string.IsNullOrEmpty(newTitle))
                {
                    task.Title = newTitle;
                }

                Console.Write("Mark as completed? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    task.Completed = true;
                }else {
                    task.Completed = false;
                }
            });

            Console.WriteLine("Task updated successfully!");
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine($"Task with ID {id} not found.");
        }
    }
    
        //delete task
    static async Task DeleteTask(TaskRepository repo)
    {
        Console.Write("Enter the task ID to delete: ");
        int id = int.Parse(Console.ReadLine());

        try
        {
            await repo.DeleteTaskAsync(id);
            Console.WriteLine("Task deleted successfully!");
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine($"Task with ID {id} not found.");
        }
    }
            //create class   
        public class TaskItem{
            public int id {get; set;}
            public string Title {get; set;}
            public string Description {get; set;} //generic collection
            public bool Completed {get; set;}
            public void display(){Console.Write("Hello World");}
        }
        //Repository for managing task data
        public class TaskRepository{
            private List<TaskItem> tasks = new List<TaskItem>();
            private int nextId = 1;
        
        //Adds a task
            public async Task addTaskAsync(TaskItem task){
                await Task.Run(() =>{
                    task.id = nextId ++;
                    tasks.Add(task);
                });
            }

            //Gets all tasks
            public async Task<List<TaskItem>> GetTasksAsync(){
                return await Task.Run(() => tasks.ToList());// prevents direct manipultation
            }
            //Gets a task from the id
            //                 vvvv this means it will return an object of type TaskItem
            public async Task<TaskItem> GetTaskByIdAsync(int id){
                return await Task.Run(() => tasks.FirstOrDefault(tasks => tasks.id == id));
            }

            //updates the task
            public async Task UpdateTaskAsync(int id, Action<TaskItem> updateAction){
                var task = await GetTaskByIdAsync(id);
                if (task == null) throw new KeyNotFoundException("Task not found.");

                await Task.Run(() => updateAction(task));
            }
            
            //deletes the task
            public async Task DeleteTaskAsync(int id){
            var task = await GetTaskByIdAsync(id);
            if (task == null) throw new KeyNotFoundException("Task not found.");
            await Task.Run(() => tasks.Remove(task));
    }

        }
    }
}