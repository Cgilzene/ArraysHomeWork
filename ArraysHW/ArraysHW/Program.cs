using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays x = new Arrays();
            x.Array();
            Console.WriteLine(x.Array());
            Console.ReadLine();
        }
    }

    class Arrays
    {

        public int Array()
        {

            int[,,] threeD = new int[10,10,10];
            List<int> arraynumbers = new List<int>();
            for (int l = 0; l < 10; l++)
            {

                for (int m = 0; m < 10; m++)
                {
                    
                    for (int n = 0; n <10; n++)
                    {
                       
                        threeD[l, m, n] = l * m * n;
                        arraynumbers.Add(l);
                        arraynumbers.Add(m);
                        arraynumbers.Add(n);
                        arraynumbers.Add(threeD[l, m, n]);
                        // Console.WriteLine(arraynumbers[3]);
                        //Console.WriteLine(threeD[l,m,n]);
                    }

                    //var value1 = threeD[l,m,n];
                }
            }

            return threeD[2,3,7];

            //List<int> arraynumbers = new List<int>();

        }
    }
}