using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            //Материал, палка и пустая ячейка
            Crafting Material = new Crafting();
            Crafting Stick = new Crafting();
            Crafting Empty1 = new Crafting();

            Material.SetName("Material");
            Stick.SetName("Stick");
            Empty1.SetName("Empty");

            Crafting[] Items = new Crafting[9];

            string[] ch=new string[9];


            //"Обнуляем"
            for (int i = 0; i < 9; i++)
            {
                ch[i] = " ";
            }

                Console.WriteLine("1-Материал,2-Палка,3-пустота");
            for(int i = 0; i < 9; i++)
            {
                ch[i]=Console.ReadLine();
                //1,2,3
                Console.WriteLine("╔═╦═╦═╗\n║"+ch[0]+ "║" + ch[1] + "║" + ch[2] + "║\n╠═╬═╬═╣\n║" + ch[3] + "║" + ch[4] + "║" + ch[5] + "║\n╠═╬═╬═╣\n║" + ch[6] + "║" + ch[7] + "║" + ch[8] + "║\n╚═╩═╩═╝");
            }
            for (int i = 0; i < 9; i++) {
                if (ch[i] == "1") {
                    Items[i]=Material;
                }
                else if (ch[i] == "2") {
                    Items[i]=Stick;
                }
                else if (ch[i] == "3")
                {
                    Items[i]=Empty1;
                }   
            }

            //Выводим, что получилось

            Crafting NewObject = new Crafting();
            //NewObject = Material + Material + Empty + Material + Stick + Empty + Empty + Stick + Empty;

            NewObject = Items[0]+ Items[1]+ Items[2]+ Items[3]+ Items[4]+ Items[5]+ Items[6]+ Items[7]+ Items[8];
            Console.WriteLine(NewObject.GetName());

            //NewObject = Material + Material + Material + Empty + Stick + Empty + Empty + Stick + Empty;
            
            
            Console.ReadLine();
        }
    }
}
