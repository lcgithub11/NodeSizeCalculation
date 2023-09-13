public class Calculation
{
    public static int CalculateNodeSize(int[] numbers)
    {

        if (numbers.Length <= 1)
            throw new ArgumentException("The list has to have at least two elements");

        int nodeSize = 0; // Starting from 0 as we are not counting the first node
        int currentNodeIndex = numbers[0]; // Start from the node pointed by the first element
        HashSet<int> visitedIndices = new HashSet<int>();

        while (currentNodeIndex != -1 && currentNodeIndex < numbers.Length)
        {
            if (visitedIndices.Contains(currentNodeIndex))
            {
                throw new ArgumentException("This list causing infinite loop.");
            }

            visitedIndices.Add(currentNodeIndex);
            nodeSize++;
            currentNodeIndex = numbers[currentNodeIndex];
        }

        return nodeSize;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter your numbers separated by commas (e.g., 5,2,7,9,-1,3):");
        string userInput = Console.ReadLine();

        try
        {
            int[] userNumbers = userInput.Split(',').Select(int.Parse).ToArray();
            int result = Calculation.CalculateNodeSize(userNumbers);
            Console.WriteLine($"Total node size: {result}");
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch
        {
            Console.WriteLine("Invalid input format. Please enter numbers separated by commas.");
        }
    }
}
