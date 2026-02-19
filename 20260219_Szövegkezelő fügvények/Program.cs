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
            lista1.Add(6);
            lista1.Add(8);
            lista1.Add(4);
            lista1.Add(7);
            lista1.Add(3);

            List<int> lista2 = [10, 20, 1];
            List<int> lista3 = new List<int>() { 10, 20, 1 };
            List<int> lista4 = new List<int>([10, 20, 1]);
            List<int> lista5 = new List<int>(tömb1);
            List<int> lista6 = [.. tömb2];

            tömb1[5] = lista1[2];
            lista2[0] = tömb2[2];

            int összeg1 = lista1.Sum(); // A lista elemeinek összegét adja vissza
            int összeg2 = tömb1.Sum(); // A tömb elemeinek összegét adja vissza

            //tömb1[-1] = 5;    // Negatív indexelés nem lehetséges
            //tömb1[1:5] = 5;   // Szeletelés nem lehetséges
            lista2 = lista1.Slice(1, 2);

            int db1 = tömb1.Length;
            int db2 = tömb1.Count();
            int db3 = lista1.Count();

            int[,] mátrix = new int[10, 10]
            {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 4, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 0, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            };

            int szám = mátrix[2, 4]; // A mátrix 3. sorában és 5. oszlopában lévő értéket adja ki
            Console.WriteLine(x);
            Console.WriteLine(mátrix);
            Console.WriteLine(lista1);

            var szöveg1 = lista1;
            var szöveg2 = "lista1";
            foreach (int listaEleme in lista1)
            {
                Console.WriteLine(listaEleme);
            }

            for (int index = 0; index < lista2.Count(); index++)
            {
                int listaEleme2 = lista2[index];
                Console.WriteLine(listaEleme2);
            }

            lista3.ForEach(listaEleme3 => Console.WriteLine(listaEleme3));

            lista4.ForEach(listaEleme4 => {
                Console.WriteLine(listaEleme4);
            });
        }
    }
}
