using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    

    internal class Resize_array
    {
        public static int[] id = new int[2];
        public static string[] name = new string[2];
        public static int[] price = new int[2];
        //public static int[] tempid = id;
        //public static string[] tempname = name;
        //public static int[] tempprice = price;
        public static void Mainx(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter number to add = ");
            int add = int.Parse(Console.ReadLine());

            int[] temp = arr;

            arr = new int[arr.Length + add];

            for (int i = temp.Length; i < arr.Length; i++)
            {
                Console.Write($"Enter arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            //do
            //{
            //    menuInit();
            //    int choice = int.Parse(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 0:
            //            break;
            //        case 1:
            //            input();
            //            break;
            //        case 2:
            //            output();
            //            break;
            //        case 3:
            //            addmore();
            //            break;
            //        default:
            //            break;
            //    }

            //} while (true);
            Loan_money();
        }

        public static void input()
        {
            for(int i = 0; i < id.Length; i++)
            {
                Console.Write("Enter ID = ");
                id[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter Name = ");
                name[i] = Console.ReadLine();
                Console.Write("Enter Price = ");
                price[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void menuInit()
        {
            Console.WriteLine("The System Set The Size Of Product is = " + id.Length);
            Console.WriteLine("1. Input ");
            Console.WriteLine("2. Output");
            Console.WriteLine("3. Add More Product");
            Console.WriteLine("0. Exit");
        }
        public static void output()
        {
            Console.WriteLine("ID\tName\tPrice");
            for (int i = 0; i < id.Length;i++)
            {
                
                Console.WriteLine(id[i] + "\t" + name[i] + "\t" + price[i]);
            }
        }
        public static void Loan_money()
        {

            double loan, interestRate;
            int month;
            Console.Write("Enter Loan          =$");
            loan = double.Parse(Console.ReadLine());
            Console.Write("Enter Interest Rate =%");
            interestRate = double.Parse(Console.ReadLine());
            Console.Write("Enter Month         =");
            month = int.Parse(Console.ReadLine());
            DateTime date = DateTime.Now;
            Console.WriteLine($"Date Receive    = {date:dd-MMM-yyyy}");
            interestRate /= 100;
            double installment, principal, interest, debt = loan;
            installment = (loan * interestRate) / (1 - Math.Pow((1 + interestRate), -month));

            Console.WriteLine();
            Console.WriteLine("Month".PadRight(15) +
                              "Installment".PadRight(23) +
                              "Principal".PadRight(20) +
                              "Interest".PadRight(20) +
                              "Debt Balance"
                );
            double totalInstallment = 0;
            totalInstallment = installment * month;
            for (int i = 1; i <= month; i++)
            {
                interest = debt * interestRate;
                principal = installment - interest;
                debt -= principal;

                if (i == month)
                {

                    installment = totalInstallment - (Math.Round(installment, 2) * (month - 1));
                    interest = Math.Round(installment, 2) - Math.Round(principal, 2);
                }

                Console.WriteLine(
                    $"{date.AddMonths(i):dd-MMM-yyyy}".PadRight(15, '-') +
                    $"{installment:c2}".PadRight(23, '-') +
                    $"{principal:c2}".PadRight(20, '-') +
                    $"{interest:c2}".PadRight(20, '-') +
                    $"{debt:c2}"
                    );

            }
            double totalInterest = totalInstallment - loan;
            Console.WriteLine("=================================");
            Console.WriteLine($"Total Installment = {totalInstallment:c2}");
            Console.WriteLine($"Total Interest    = {totalInterest:c2}");
            Console.ReadKey();
            
        
        }
        public static void exit()
        {
            for(int i = 0; i < id.Length; i++)
            {
                break;
            }
        }
        public static void addmore()
        {
            int[] tempid = id;
            string[] tempname = name;
            int[] tempprice = price;
            Console.Write("Enter Number to Add more Product = ");
            int add = int.Parse(Console.ReadLine());
            id = new int[id.Length + add];
            name = new string[name.Length + add];
            price = new int[price.Length + add];
            for (int i = 0; i < tempid.Length; i++)
            {
                id[i] = tempid[i];
                name[i] = tempname[i];
                price[i] = tempprice[i];
            }

            Console.WriteLine($"======================= Add {add} More Product =======================");
            for(int i = tempid.Length; i < id.Length; i++)
            {
                Console.Write("Enter ID = ");
                id[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter Name = ");
                name[i] = Console.ReadLine();
                Console.Write("Enter Price = ");
                price[i] = int.Parse(Console.ReadLine());
            }
            


        }

    }
}
