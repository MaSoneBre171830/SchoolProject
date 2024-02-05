class Program
{
    static void Main()
    {
        List<int> list = new List<int>();
        Console.WriteLine("How many numbers do you wanna input?");
        int nums = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input numbers(one by one): ");

        do
        {
            int numbers = Convert.ToInt32(Console.ReadLine());
            list.Add(numbers);
                  
            nums--;
        } while (nums > 0);


        Console.Clear();
        SortList(list);

        Console.WriteLine("Sorted list: ");   



        foreach (int num in list)
            Console.Write(num + ", ");
    }

    static List<int> SortList(List<int> list)
    {
        int ListLength = list.Count; // initializes a variable to make the code cleaner
        int iritations = 0;

        for(int i = 0; i < ListLength - 1 ; i++) 
        {
            for(int j = 0; j < ListLength - i - 1;   j++)
            {
                if (list[j] < list[j + 1]) // compares the number at index (j) with number at index j + 1
                {
                    // swaps the elements
                    int temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                                
                    iritations++; // counts how many steps it takes to sort list
                }
            }
        }

        Console.WriteLine($"Iritations: {iritations}");
        // returns the list
        return list;
    }
}