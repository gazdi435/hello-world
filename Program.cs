namespace HELLO_WORLD_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam;
            do
            {
                szam = Convert.ToInt32(Console.ReadLine());
            } while (szam<2 || szam>20);

            Console.Clear();

            int hordHossz = szam + 2;
            int elHossz = szam + 1;
            int wHossz = szam * 2 + 1;

            string elsoSor    = $"{Szelsok(hordHossz)}.{Kitolt(elHossz)}.{BalSzelso(elHossz)}.{BalSzelso(elHossz)}.{Szelsok(hordHossz,false)}{Szokoz()}{Szelsok(wHossz)}.{Szelsok(hordHossz, false)}.{BalSzelso(hordHossz, false,true)}";
            string masodikSor = $"{Szelsok(hordHossz)}.{BalSzelso(elHossz)}.{BalSzelso(elHossz)}.{BalSzelso(elHossz)}.{Szelsok(hordHossz)}{Szokoz()}{Szelsok(wHossz)}.{Szelsok(hordHossz)}.{Szelsok(hordHossz)}";
            string kozepsoSor = $"{Kitolt(hordHossz)}.{Kitolt(elHossz)}.{BalSzelso(elHossz)}.{BalSzelso(elHossz)}.{Szelsok(hordHossz)}{Szokoz()}{Szelsok(wHossz)}.{Szelsok(hordHossz)}.{BalSzelso(hordHossz, false, true)}";
            string alsoSor    = $"{Szelsok(hordHossz)}.{Kitolt(elHossz)}.{Kitolt(elHossz)}.{Kitolt(elHossz)}.{Szelsok(hordHossz, false)}{Szokoz()}{kettes(wHossz)}.{Szelsok(hordHossz, false)}.";

            Console.WriteLine(elsoSor);
            Thread.Sleep(100);
            for (int i = 0; i < szam-3/2; i++)
            {
                Console.WriteLine(masodikSor);
                Thread.Sleep(100);
            }

            Console.WriteLine(kozepsoSor);
            Thread.Sleep(100);

            for (int i = szam - 3 / 2; i>0; i--)
            {
                string elottiSor = "";
                if (i== szam - 3 / 2)
                {
                    elottiSor = $"{Szelsok(hordHossz)}.{BalSzelso(elHossz)}.{BalSzelso(elHossz)}.{BalSzelso(elHossz)}.{Szelsok(hordHossz)}{Szokoz()}{Harmas(wHossz)}.{Szelsok(hordHossz)}.{/*Rlaba()*/"a"}";

                }
                else
                {
                    elottiSor = $"{Szelsok(hordHossz)}.{BalSzelso(elHossz)}.{BalSzelso(elHossz)}.{BalSzelso(elHossz)}.{Szelsok(hordHossz)}{Szokoz()}{Negyes(wHossz, (szam - 3 / 2) - i,i)}.{Szelsok(hordHossz)}.";
                }
                    Console.WriteLine(elottiSor);
                    Thread.Sleep(100);
            }

            Console.WriteLine(alsoSor);
            Thread.Sleep(100);

        }

        public static string Rlaba(int bal, int jobb)
        {
            return $"#{bal}#{jobb}";
        }

        public static string Negyes(int kitolto, int belso, int szelso)
        {
            if (belso!=1)
            {
                belso=belso*2-1;
            }

            return $"#{new string('.', szelso)}#{new string('.', belso)}#{new string('.', szelso)}#";
        }

        public static string Harmas(int kitolto, bool alap=true)
        {
            return $"#{new string('.', (kitolto - 3) / 2)}#{new string('.', (kitolto - 3) / 2)}#";
        }

        public static string kettes(int kitolto)
        {
            return $".#{new string('.', kitolto - 4)}#.";
        }

        public static string Kitolt(int kitolto)
        {
            return new string('#',kitolto);
        }

        public static string Szelsok(int kitolto, bool rendes = true)
        {
            if (rendes==true)
            {
                return $"#{new string('.', kitolto - 2)}#";
            }
            else
            {
                return $".{new string('#', kitolto - 2)}.";
            }
        }

        public static string BalSzelso(int kitolto, bool bal = true, bool forditott=false)
        {
            if (forditott==false)
            {
                if (bal==true)
                {
                    return $"#{new string('.', kitolto - 1)}";
                }
                else
                {
                    return $".{new string('#', kitolto - 1)}";
                }
            }
            else
            {
                if (bal == true)
                {
                    return $"{new string('.', kitolto - 1)}#";
                }
                else
                {
                    return $"{new string('#', kitolto - 1)}.";
                }
            }

        }

        public static string Koz()
        {
            return $".";
        }

        public static string Szokoz()
        {
            return $"...";
        }
    }
}