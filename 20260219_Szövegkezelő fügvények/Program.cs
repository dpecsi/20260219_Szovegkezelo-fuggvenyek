namespace _20260219_Szövegkezelő_fügvények
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            x++;
            ++x;
            x += 1;
            x = x + 1;

            int[] tömb1 = new int[10];
            int[] tömb2 = new int[] { 3, 4, 6, 87, 12, 3, 1, 2, 2 };
            int[] tömb3 = { 3, 4, 6, 87, 12, 3, 1, 2, 2 };
            tömb1[0] = 3;
            tömb1[9] = 5;
            //tömb1[10] = 7; // Ez hibát fog okozni, a tömb mérete 10, indexelés 0-tól kezdődik
            Array.Resize(ref tömb1, 20); // Tömb méretének megváltoztatása, memória intenzív
                        
            List<int> lista1 = new List<int>();
            lista1.Add(10);
            lista1.Add(20);
            lista1.Add(1);

            List<int> lista2 = [10, 20, 1];
            List<int> lista3 = new List<int>() { 10, 20, 1 };
            List<int> lista4 = new List<int>([10, 20, 1]);

            Console.WriteLine(x);
        }
    }
}
