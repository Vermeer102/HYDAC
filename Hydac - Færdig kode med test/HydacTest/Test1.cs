using Hydac;
namespace HydacTest
{
    [TestClass]
    public sealed class WorkerTest
    {
        [TestMethod]
        public void RegisterArrival_WithGreenSmiley_WorkerRemembersSmiley()
        {
            // Arrange
            Worker worker = new Worker(1, "Anna");
            Arrival arrival = new Arrival(DateTime.Today, DateTime.Now);
            Smiley smiley = new Smiley("Green");

            // Act
            worker.RegisterArrival(arrival, smiley);

            // Assert
            Assert.AreEqual("Green", worker.Smiley.Color);
        }
    }
}
