using System;

namespace ooad_t1_z3
{
    class Program
    {
        private static void bubbleSort(int[] niz)
        {
            for(int i=0; i<niz.Length; i++)
            {
                for(int j=0; j<niz.Length-i; j++)
                {
                    if(j+1<niz.Length && niz[j] > niz[j+1])
                    {
                        int temp = niz[j];
                        niz[j] = niz[j+1];
                        niz[j+1] = temp;
                    }
                }
            }
        }

        public static void ispisiNiz(int[] niz)
        {
            for (int i = 0; i < niz.Length; i++)
            {
                Console.Write("{0}", niz[i]);

                if (i != niz.Length - 1)
                    Console.Write(", ");
            }
        }

        public static void ispravanUnos(String unos, out int broj)
        {
            while(Int32.TryParse(Console.ReadLine(), out broj) == false)
                Console.WriteLine("neispravan unos, unesite ponovo");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Uneiste broj n koji oznacava velicinu niza: ");
            int velicinaNiza;
            int[] niz;

            ispravanUnos(string.Empty, out velicinaNiza);

            niz = new int[velicinaNiza];

            Console.WriteLine("Unesite niz od {0} clanova: ", velicinaNiza);
            for(int i=0; i<velicinaNiza; i++)
                ispravanUnos(String.Empty, out niz[i]);

            bubbleSort(niz);
            ispisiNiz(niz);

            Console.ReadLine();
        }
    }
}
