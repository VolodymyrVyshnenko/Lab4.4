using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    class ApplicationLicense
    {
        private string key;
        private string[] ProKeys = { "0000", "7777", "7878", "6669" };
        private string[] TrialKeys = { "1234", "2345", "3456", "9876" };
        public ApplicationLicense(string key)
        {
            this.key = key;
        }
        public void Method()
        {
            for (int i = 0; i < ProKeys.Length; i++)
            {
                if (key == ProKeys[i])
                {
                    AllowPro();
                    break;
                }
            }
            for (int i = 0; i < TrialKeys.Length; i++)
            {
                if (key == TrialKeys[i])
                {
                    AllowTrial();
                    break;
                }
            }
            if (key == "")
            {
                AllowCommon();
            }
        }
        private void AllowPro()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("          Congratulations!!!");
            Console.WriteLine("You have proffesional versin of App.");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        private void AllowTrial()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("        Congratulations");
            Console.WriteLine("You have trial versin of App.");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        private void AllowCommon()
        {
            Console.WriteLine("You have common versin of App.");

        }
    }
}