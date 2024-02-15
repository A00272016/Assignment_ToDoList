using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoList.Models;

namespace TodoList.Models
{
    [TestClass]
    public class ToDoItem
    {
        public DateTime CompletedDate { get; private set; }
        public int Id { get; private set; }
        public DateTime DueDate { get; private set; }
        public string? Description { get; private set; }

        [TestMethod]
        public void ToDoItem_DefaultConstructor_SetsPropertiesToDefaultValues()
        {
            var toDoItem = new ToDoItem();

            Assert.AreEqual(default(int), toDoItem.Id);
            Assert.AreEqual(default(DateTime), toDoItem.DueDate);
            Assert.AreEqual(default(DateTime), toDoItem.CompletedDate);
            Assert.AreEqual(default(string), toDoItem.Description);
        }

        // Write more unit tests to cover various aspects of the ToDoItem class
    }
}
