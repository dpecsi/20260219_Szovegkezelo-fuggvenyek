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

            int[] tömb222 = lista2.ToArray();
            List<int> lista222 = tömb3.ToList();

            string szöveg3 = "Helló Világ!";
            char[] szöveg4 = new char[] {'H', 'e', 'l', 'l', 'ó', ' ', 'V', 'i', 'l', 'á', 'g'};
            char[] szöveg5 = {'H', 'e', 'l', 'l', 'ó', ' ', 'V', 'i', 'l', 'á', 'g'};
            char[] szöveg6 = "Helló világ".ToCharArray();
            char[] szöveg7 = szöveg3.ToCharArray();

            int karakterekSzáma1 = szöveg3.Count();
            int karakterekSzáma2 = szöveg3.Length;
            string szöveg8 = szöveg3.ToLower();
            szöveg8 = szöveg3.Replace('a', 'b');
            szöveg8 = szöveg3.Replace("a", "b");
            szöveg8 = szöveg3.Replace("a", "");
            szöveg8 = szöveg3.Replace("asdasd", "b");
            szöveg8 = szöveg3.Substring(6, 2);
            Console.WriteLine(szöveg8);
            szöveg8 = szöveg3[6..8];
            Console.WriteLine(szöveg8);
            szöveg8 = szöveg3[6..^2];
            Console.WriteLine(szöveg8);
            szöveg8 = szöveg3[6..];
            Console.WriteLine(szöveg8);
            return;
            string[] szövegek1 = szöveg3.Split(" ");
            List<string> szövegek2 = szöveg3.Split(" ").ToList();
            szöveg3 = string.Join(" ", szövegek1);

            Console.WriteLine(string.Join(", ", tömb3));

            if (szöveg3.Contains("Helló"))
            {
                Console.WriteLine("A szöveg tartalmazza a 'Helló' szót");
            }

            Console.Clear();
            int szám10 = 3;
            Console.WriteLine(szám10.ToString().PadLeft(10, '0'));

            string segéd = " s zö veg       ";
            Console.WriteLine("'"+segéd+"'");
            Console.WriteLine("'"+segéd.Trim()+"'");
            Console.WriteLine("'"+segéd.Trim(new char[] {' ', 's', 'g'})+"'");

        }
    }
}
