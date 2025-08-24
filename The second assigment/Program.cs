List<int> numbers = new List<int>();
Console.WriteLine("===================================================================");
while (true) {
    Console.WriteLine("P - Print numbers\nA - Add a number\nM - Display mean of the numbers\nS - Display the smallest number\nL - Display the largest number\nF - Find number in list\nC - Clear the list\nR - Reverse the list\nQ - Quit");
    Console.WriteLine("===================================================================");
    Console.WriteLine("Enter your choice");
    string choice = Console.ReadLine().ToUpper();
    if (choice == "P")
    {
        if (numbers.Count == 0)
        {
            Console.WriteLine("[] - the list is empty");
        }
        else
        {
            Console.Write("[ ");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.Write("]");
        }
    }
    else if (choice == "A")
    {
        Console.WriteLine("Add number to list");
        int num = Convert.ToInt32(Console.ReadLine());
        bool exist = false;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == num)
            {
                exist = true;
                break;
            }
            
        }
        if (exist)
        {
            Console.WriteLine($"{num} already exists - not added");
        }
        else
        {
            numbers.Add(num);
            Console.WriteLine($"{num} added");
        }
    }
    else if (choice == "M")
    {
        if (numbers.Count == 0)
        {
            Console.WriteLine("Unable to calculate the mean - no data");
        }
        else
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            double mean = (double)sum / numbers.Count;
            Console.WriteLine($"The mean is {mean}");
        }
    }
    else if (choice == "S")
    {
        if (numbers.Count == 0)
        {
            Console.WriteLine("Unable to determine the smallest number - list is empty");
        }
        else
        {
            int smallest = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }
            Console.WriteLine($"The smallest number is {smallest}");
        }
    }
    else if (choice == "L")
    {
        if (numbers.Count == 0)
        {
            Console.WriteLine("Unable to determine the largest number - list is empty");
        }
        else
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine($"The largest number is {largest}");
        }
    }
    else if (choice == "F")
    {
        if (numbers.Count == 0)
        {
            Console.WriteLine("Unable to search - list is empty");
        }
        else
        {
            Console.WriteLine("Enter the number to find it in list");
            int target = Convert.ToInt32(Console.ReadLine());
            bool founded = false;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == target)
                {
                    founded = true;
                    break;
                }
            }
            if (founded)
            {
                Console.WriteLine($"The {target} is in list");
            }
            else
            {
                Console.WriteLine($"The {target} is not in list");
            }
        }
    }
    else if (choice == "C")
    {
        if (numbers.Count == 0)
        {
            Console.WriteLine("The list is already empty");
        }
        else
        {
            numbers.Clear();
            Console.WriteLine("List cleared successfully");
        }
    }
    else if (choice == "R")
    {
        if (numbers.Count == 0)
        {
            Console.WriteLine("Unable to reverse - list is empty");
        }
        else
        {
            List<int> reversed = new List<int>();
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                reversed.Add(numbers[i]);
            }
            numbers = reversed;
            Console.WriteLine("List reversed successfully");
        }
    }
    else if (choice == "Q")
    {
        Console.WriteLine("Goodbye");
        break;
    }
    else {
        Console.WriteLine("Unknown choice , please try again");
    }
}
