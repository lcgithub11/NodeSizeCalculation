namespace NodeSizeCalculationTest
{
    [TestClass]
    public class UnitTestForNodeSizeCalculation
    {
        [TestMethod]
        public void TestNodeSizeCalculation_ExampleCase()
        {
            // Arrange: Prepare the input data
            int[] input = { 5, -1, 1, 2, 4, 3 };

            // Act: Call the method under test
            int result = Calculation.CalculateNodeSize(input);

            // Assert: Check if the result is as expected
            Assert.AreEqual(4, result); // Expected result for the example case
        }

        [TestMethod]
        public void TestNodeSizeCalculation_IndexOutOfBondsCase()
        {
            // Arrange: Prepare the input data
            int[] input = { 10, 20, -1 };

            // Act: Call the method under test
            int result = Calculation.CalculateNodeSize(input);

            // Assert: Check if the result is as expected
            Assert.AreEqual(0, result); // Expected result for the IndexOutOfBondsCase case
        }

        [TestMethod]
        public void TestNodeSizeCalculation_FourNodes()
        {
            // Arrange: Prepare the input data
            int[] input = { 2, 3, 1, -1 };

            // Act: Call the method under test
            int result = Calculation.CalculateNodeSize(input);

            // Assert: Check if the result is as expected
            Assert.AreEqual(3, result); // Expected result for a list with 4 nodes
        }

        [TestMethod]
        public void TestNodeSizeCalculation_SingleNode()
        {
            // Arrange: Prepare the input data
            int[] input = { -1 };

            // Act: Call the method under test
            try
            {
                int result = Calculation.CalculateNodeSize(input);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            // Assert: This line should not be reached
            Assert.Fail("The code should have thrown an ArgumentException exception.");
        }

        [TestMethod]
        public void TestNodeSizeCalculation_EmptyList()
        {
            // Arrange: Prepare the input data
            int[] input = { };

            // Act: Call the method under test
            try
            {
                int result = Calculation.CalculateNodeSize(input);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            // Assert: This line should not be reached
            Assert.Fail("The code should have thrown an ArgumentException exception.");
        }

        [TestMethod]
        public void TestNodeSizeCalculation_ListWithLoop()
        {
            // Arrange: Prepare the input data
            int[] input = { 1, 2, 0, -1 };

            // Act: Call the method under test
            try
            {
                int result = Calculation.CalculateNodeSize(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            // Assert: Check if the result is as expected
            Assert.Fail("The code should have thrown an ArgumentException exception.");
        }
    }

}