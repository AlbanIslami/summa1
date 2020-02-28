using System;
using System.IO;

namespace summa.txt
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int fem = 0;
            try
            {
                using (BinaryReader br = new BinaryReader(new FileStream("talfil.tf", FileMode.OpenOrCreate, FileAccess.Read)))
                {
                    
                    for (int i = 0; i < 1000000; i++) 
                    {
                        int tal = br.ReadInt32();
                        
                        sum = sum + tal;
                        if(tal == 5)
                        {
                            fem++;
                        }
                        else
                        {

                        }                        
                    }

                    br.Close();

                }
            }
            catch
            {
                Console.WriteLine("fel");
            }

            Console.WriteLine(sum);
            Console.WriteLine(fem);

            StreamWriter sw = new StreamWriter("summa.txt");


            
            
        }
    }
}
