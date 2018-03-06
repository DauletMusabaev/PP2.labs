using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    public class Catalog
    {
        public static List<Brands> shop;
        string[] k;
        public Catalog()
        {
            shop = new List<Brands>();
            Console.WriteLine("Brands Valut Price Amount");
            shop.Add(new Brands("Nike $", 850, 20));
            shop.Add(new Brands("Adidas $", 800, 30));
            shop.Add(new Brands("Reebook $", 500, 30));
            shop.Add(new Brands("New Balance $", 450, 50));
            shop.Add(new Brands("Puma $", 450, 50));

            k = new string[2];
            k[0] = "Basket";
            k[1] = "Click Add Your Product";
        }

        public void Menu(int cursor, int right)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < shop.Count; i++)
            {
                if (cursor == i && right == 0)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.SetCursorPosition(0, i);
                Console.WriteLine("\n" + shop[i].name + " " + shop[i].cost + " " + shop[i].amount);
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < 2; i++)
            {
                if (cursor % 2 == i && right == 1)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.SetCursorPosition(30, i);
                Console.WriteLine(k[i]);
            }
        }

        public void Plus()
        {
            Console.BackgroundColor = ConsoleColor.Blue ;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter your product");
            string s = Console.ReadLine();
            string[] s1 = s.Split(' ');
            shop.Add(new Brands(s1[0], double.Parse(s1[1]), int.Parse(s1[2])));
            Console.Clear();
        }

        public void AddBasket(int cursor)
        {
            bool b = true;
            for (int i = 0; i < Basket.basket.Count; i++)
            {
                if (Basket.basket[i].name == shop[cursor].name)
                {
                    Basket.basket[i].amount++;
                    b = false;
                    break;
                }
            }
            if (b) Basket.basket.Add(new Brands(shop[cursor].name, shop[cursor].cost, 1));
            shop[cursor].amount--;
            if (shop[cursor].amount == 0)
            {
                shop.RemoveAt(cursor);
                cursor--;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
            }
        }
    }
}