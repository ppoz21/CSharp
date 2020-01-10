class BinaryConverter
{
    static void Main()
    {
        const int size = 64;
        ulong value;
        char bit;

        System.Console.Write("Wprowadź liczbę całkowitą: ");
        value = (ulong)long.Parse(System.Console.ReadLine());

        ulong mask = 1UL << size - 1;
        for(int count = 0; count < size; count++)
        {
            bit = ((mask & value) != 0) ? '1' : '0';
            System.Console.Write(bit);
            mask >>= 1;
        }
        System.Console.WriteLine();
    }
}