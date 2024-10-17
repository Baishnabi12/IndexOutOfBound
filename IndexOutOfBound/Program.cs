class Program {
    static void Main(String[] args)
    {
        int[] num = { 1, 2, 3, 4 };
        try
        {
            for (int i = 0; i > num.Length; i++)
            {
                Console.WriteLine(num[5]);
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Index Out Of Range");
        }
       
    }
}

