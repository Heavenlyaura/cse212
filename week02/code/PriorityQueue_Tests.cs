using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add an item (which contains both data and priority) to the back of the queue.
    // Expected Result: The queues length should match the number of items added
    // Defect(s) Found: No defects found in this scenario
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Registration Issue", 5);
        priorityQueue.Enqueue("Portal Issue", 2);
        priorityQueue.Enqueue("Portal Issue", 2);
        priorityQueue.Enqueue("DPA Issue", 1);
        Assert.AreEqual(4, priorityQueue.length);
    }

    [TestMethod]
    // Scenario: Remove the item with the highest priority and return its value, the the two items have equal priority the FIFO method is applied
    // Expected Result: The item "Registration Issue" should be dequeued. 
    // Defect(s) Found: This found no major defects
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Portal Issue", 2);
        priorityQueue.Enqueue("Registration Issue", 5);
        priorityQueue.Enqueue("Tuition Payment ", 5);
        priorityQueue.Enqueue("Portal Issue", 2);
        priorityQueue.Enqueue("DPA Issue", 1);

        string item = priorityQueue.Dequeue();

        Assert.AreEqual(item, "Registration Issue");
        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario:Check if the queue is empty
    // Expected Result: An error exception shall be thrown.
    // Defect(s) Found: This found no major defects
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            string item = priorityQueue.Dequeue();
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}