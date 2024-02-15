using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Models
{
    public class DataContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }

    public class ToDoItem
    {
        public object? CompletedDate { get; internal set; }
    }
}
