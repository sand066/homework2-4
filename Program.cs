class homework4
{
    static void Main(string[] args)
    {
        int waypoint = int.Parse(Console.ReadLine());
        int slot = int.Parse(Console.ReadLine());
        int[] way = new int[waypoint];
        Process(ref way);
        Console.WriteLine(Calculation(way, slot));

    }
    static int Bestnum(int i, int j)
    {
        {
            if (i > j)
            {
                return i;
            }
            return j;
        }
    }

    static void Process(ref int[] way)
    {
        for (int i = 0; i < way.Length; i++)
        {
            way[i] = int.Parse(Console.ReadLine());
        }
    }
    static int Calculation(int[] way, int slot)
    {
        int top = 0;
        int select = 0;
        for (int i = slot; i < (way.Length + 1) - (2 * slot); i++)
        {
            select = way[i];
            for (int j = 1; j <= slot; j++)
            {
                select = select + way[i - j] + way[i + j];
            }
            top = Bestnum(select, top);
        }
        return top;
    }


}
