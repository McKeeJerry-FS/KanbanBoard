using KanbanBoard.Models.Enums;

namespace KanbanBoard.Models
{
    public class TaskItem
    {
        public string TaskName { get; set; } = string.Empty;
        public TaskPriority Priority { get; set; }
    }
}
