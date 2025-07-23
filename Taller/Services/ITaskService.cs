using Taller.Models;

namespace Taller.Services
{
    public interface ITaskService
    {
        List<TaskItem> GetAll();
        TaskItem Create(TaskItem task);

    }
}
