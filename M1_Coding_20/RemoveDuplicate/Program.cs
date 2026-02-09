using System;

class RemoveDuplicates
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        int[] unique = new int[n];
        int size = 0;

        for (int i = 0; i < n; i++)
        {
            bool found = false;
            for (int j = 0; j < size; j++)
            {
                if (arr[i] == unique[j])
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                unique[size] = arr[i];
                size++;
            }
        }

        for (int i = 0; i < size; i++)
            Console.Write(unique[i] + " ");
    }
}