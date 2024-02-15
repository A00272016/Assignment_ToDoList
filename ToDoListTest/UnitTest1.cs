namespace TodoList.Tests
{
    [TestClass]
    public class ToDoItemTests
    {
        public int Id { get; private set; }
        public string? Description { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime CompletedDate { get; private set; }

        [TestMethod]
        public void ToDoItem_DefaultConstructor_SetsPropertiesToDefaultValues()
        {
            // Arrange
            var toDoItem = new ToDoItemTests();

            // Act

            // Assert
            Assert.AreEqual(default(int), toDoItem.Id);
            Assert.AreEqual(default(DateTime), toDoItem.DueDate);
            Assert.AreEqual(default(DateTime), toDoItem.CompletedDate);
            Assert.AreEqual(default(string), toDoItem.Description);
        }

        [TestMethod]
        public void ToDoItem_SetProperties_SetsPropertiesCorrectly()
        {
            // Arrange
            var id = 1;
            var dueDate = new DateTime(2024, 2, 14);
            var completedDate = new DateTime(2024, 2, 15);
            var description = "Complete unit tests";

            // Act
            var toDoItem = new ToDoItemTests
            {
                Id = id,
                DueDate = dueDate,
                CompletedDate = completedDate,
                Description = description
            };

            // Assert
            Assert.AreEqual(id, toDoItem.Id);
            Assert.AreEqual(dueDate, toDoItem.DueDate);
            Assert.AreEqual(completedDate, toDoItem.CompletedDate);
            Assert.AreEqual(description, toDoItem.Description);
        }

        [TestMethod]
        public void ToDoItem_Equals_ReturnsTrueForEqualObjects()
        {
            // Arrange
            var toDoItem1 = new ToDoItemTests { Id = 1 };
            var toDoItem2 = new ToDoItemTests { Id = 1 };

            // Act

            // Assert
            Assert.AreEqual(toDoItem1, toDoItem2);
        }

        [TestMethod]
        public void ToDoItem_Equals_ReturnsFalseForDifferentObjects()
        {
            // Arrange
            var toDoItem1 = new ToDoItemTests { Id = 1 };
            var toDoItem2 = new ToDoItemTests { Id = 2 };

            // Act

            // Assert
            Assert.AreNotEqual(toDoItem1, toDoItem2);
        }
    }
}
