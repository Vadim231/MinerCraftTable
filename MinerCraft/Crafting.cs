using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerCraft
{
    class Crafting
    {
        private string name;
        //private int weight;
        //private int hardness;


        public string GetName()
        {
            return name;
        }
        public void SetName(string str)
        {
            name = str;
        }
      
        public static Crafting operator+(Crafting firstOper, Crafting secondOper)
        {
            //Кирка
            if (firstOper.name == "Material" && secondOper.name == "Material")
            {
                Crafting striing = new Crafting();
                striing.SetName("XX");
                return striing;
            }
            else if (firstOper.name == "XX" && secondOper.name == "Material")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXX");
                return striing;
            }
            else if (firstOper.name == "XXX" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXXO");
                return striing;
            }
            else if (firstOper.name == "XXXO" && secondOper.name == "Stick")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXXOI");
                return striing;
            }
            else if (firstOper.name == "XXXOI" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXXOIO");
                return striing;
            }
            else if (firstOper.name == "XXXOIO" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXXOIOO");
                return striing;
            }
            else if (firstOper.name == "XXXOIOO" && secondOper.name == "Stick")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXXOIOOI");
                return striing;
            }
            else if (firstOper.name == "XXXOIOOI" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("Кирка(pick)");
                return striing;
            }

            //лопата <-

            else if (firstOper.name == "Empty" && secondOper.name == "Material")
            {
                Crafting striing = new Crafting();
                striing.SetName("OX");
                return striing;
            }
            else if (firstOper.name == "OX" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("OXO");
                return striing;
            }
            else if (firstOper.name == "OXO" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("OXOO");
                return striing;
            }
            else if (firstOper.name == "OXOO" && secondOper.name == "Stick")
            {
                Crafting striing = new Crafting();
                striing.SetName("OXOOI");
                return striing;
            }
            else if (firstOper.name == "OXOOI" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("OXOOIO");
                return striing;
            }
            else if (firstOper.name == "OXOOIO" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("OXOOIOO");
                return striing;
            }
            else if (firstOper.name == "OXOOIOO" && secondOper.name == "Stick")
            {
                Crafting striing = new Crafting();
                striing.SetName("OXOOIOOI");
                return striing;
            }
            else if (firstOper.name == "OXOOIOOI" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("Лопата(shovel)");
                return striing;
            }

            //Топор <-
            else if (firstOper.name == "XX" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXO");
                return striing;
            }
            else if (firstOper.name == "XXO" && secondOper.name == "Material")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXOX");
                return striing;
            }
            else if (firstOper.name == "XXOX" && secondOper.name == "Stick")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXOXI");
                return striing;
            }
            else if (firstOper.name == "XXOXI" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXOXIO");
                return striing;
            }
            else if (firstOper.name == "XXOXIO" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXOXIOO");
                return striing;
            }
            else if (firstOper.name == "XXOXIOO" && secondOper.name == "Stick")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXOXIOOI");
                return striing;
            }
            else if (firstOper.name == "XXOXIOOI" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("Топор(Axe)");
                return striing;
            }

            //меч
            else if (firstOper.name == "OXOO" && secondOper.name == "Material")
            {
                Crafting striing = new Crafting();
                striing.SetName("OXOOX");
                return striing;
            }
            else if (firstOper.name == "OXOOX" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("OXOOXO");
                return striing;
            }
            else if (firstOper.name == "OXOOXO" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("OXOOXOO");
                return striing;
            }
            else if (firstOper.name == "OXOOXOO" && secondOper.name == "Stick")
            {
                Crafting striing = new Crafting();
                striing.SetName("OXOOXOOI");
                return striing;
            }
            else if (firstOper.name == "OXOOXOOI" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("Меч(Sword)");
                return striing;
            }

            //матыга
            
            else if (firstOper.name == "XXO" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXOO");
                return striing;
            }
            else if (firstOper.name == "XXOO" && secondOper.name == "Stick")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXOOI");
                return striing;
            }
            else if (firstOper.name == "XXOOI" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXOOIO");
                return striing;
            }
            else if (firstOper.name == "XXOOIO" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXOOIOO");
                return striing;
            }
            else if (firstOper.name == "XXOOIOO" && secondOper.name == "Stick")
            {
                Crafting striing = new Crafting();
                striing.SetName("XXOOIOOI");
                return striing;
            }
            else if (firstOper.name == "XXOOIOOI" && secondOper.name == "Empty")
            {
                Crafting striing = new Crafting();
                striing.SetName("Матыга(Hoe)");
                return striing;
            }
            else { return null; }
        }


    }
}
