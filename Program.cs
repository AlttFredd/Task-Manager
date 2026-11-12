using System;
using System.Data;

namespace Task_Manager
{
    public class TaskItem
    {
        public required string Title { get; set; }
        public int Id { get; init; }
        public DateTime CreatedAt { get; init; } = DateTime.Now;
        public bool IsCompleted { get; set; }
    }

        public class TaskManager
        {
            List<TaskItem> = 
        }
