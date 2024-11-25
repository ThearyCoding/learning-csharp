using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArrayOptions
    {
        static void Mainx(string[] args)
        {

            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            int[] id = new int[n];
            string[] name = new string[n];
            int[] barcode = new int[n];
            double[] unity = new double[n];
            double[] sellprice = new double[n];
            int[] qtyinstock = new int[n];
            int option;
            do
            {
                Console.WriteLine("1. Input Product");
                Console.WriteLine("2. Show Product");
                Console.WriteLine("3. Exit The Product");
                Console.Write("Enter Options = ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Enter ID = ");
                            id[i] = int.Parse(Console.ReadLine());
                            Console.Write("Enter Name = ");
                            string tempname = Console.ReadLine();
                            bool isfound = false;
                            for (int j = 0; j < i; j++)
                            {
                                if (tempname.Equals(name[j]))
                                {
                                    isfound = true;
                                    break;
                                }
                            }
                            if (isfound)
                            {
                                i--;
                                continue;
                            }
                            name[i] = tempname;
                            Console.Write("Enter Barcode = ");
                            int tempbarcode = int.Parse(Console.ReadLine());
                            bool isfoundbarcode = false;
                            for (int j = 0; j < i; j++)
                            {
                                if (barcode[j] == tempbarcode)
                                {
                                    isfoundbarcode = true;
                                    break;
                                }
                            }
                            if (isfoundbarcode)
                            {
                                i--;
                                continue;
                            }
                            barcode[i] = tempbarcode;
                            Console.Write("Ënter Unity = ");
                            unity[i] = int.Parse(Console.ReadLine());
                            Console.Write("Enter Sell Price = ");
                            sellprice[i] = int.Parse(Console.ReadLine());
                            Console.Write("Enter QtyInstock = ");
                            qtyinstock[i] = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 2:
                        Console.WriteLine("ID\tName\tBarcode\tUnity\tSellPrice\tQty");
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine(id[i] + "\t" + name[i] + "\t" + barcode[i] + "\t" + unity[i] + "\t" + sellprice[i] + "\t" + qtyinstock[i]);
                        }
                        break;
                }
            } while (option != 3);
            Console.ReadLine();
        }
    }
}