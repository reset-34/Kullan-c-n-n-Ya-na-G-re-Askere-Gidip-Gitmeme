using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kullanıcının_Yaşına_Göre_Askere_Gidip_Gitmeme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yas = 22;
            
            if (yas>=20)
            {
                Console.WriteLine("Askere Gidebilirsin");
                }
            else
            {
                Console.WriteLine("Askere Gidemezsi");
                             }
            Console.ReadLine();


        }
    }
}
