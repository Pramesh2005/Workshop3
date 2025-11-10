    Console.Write("Enter a number N: ");
        int N = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= N; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Sum from 1 to {N} = {sum}\n");

        Console.WriteLine("Numbers from 1 to 20 (skip multiples of 4 and stop at 15):");
        int num = 1;
        while (num <= 20)
        {
            if (num % 4 == 0)
            {
                num++;
                continue; 
            }

            if (num == 15)
                break;

            Console.WriteLine(num);
            num++;
        }
        Console.WriteLine();

        int[] numbers = { 2, 4, 6, 8, 10 };
        int arraySum = 0;

        foreach (int n in numbers)
        {
            arraySum += n;
        }
        Console.WriteLine("Sum of array elements = " + arraySum);
    