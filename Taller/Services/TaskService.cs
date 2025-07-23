using System.Text.Json;
using System.Threading.Tasks;
using Taller.Models;

namespace Taller.Services
{
    public class TaskService : ITaskService
    {
        private List<TaskItem> _tasks;

        public TaskService()
        {
            _tasks = new List<TaskItem>
            {
                new TaskItem { Id = 1, Name = "Comprar pan", Description = "Ir a la panadería y comprar pan" },
                new TaskItem { Id = 2, Name = "Hacer ejercicio", Description = "Correr 30 minutos en el parque" }
            };
        }

        public List<TaskItem> GetAll()
        {
            return _tasks.ToList();
        }

        public TaskItem Create(TaskItem task)
        {
            task.Id = _tasks.Any() ? _tasks.Max(t => t.Id) + 1 : 1;

            try
            {
                _tasks.Add(task);
                return task;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving task to Json: {ex.Message}.");
            }

        }
    }
}
