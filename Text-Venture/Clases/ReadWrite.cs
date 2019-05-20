using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Text_Venture.Clases.ResourcesClases;
using System.Drawing;

namespace Text_Venture.Clases
{
    class ReadWrite : ICommands
    {
        public static TextBox input;
        public static RichTextBox output;
        public ReadWrite(ref RichTextBox text, ref TextBox command)
        {
            input = command;
            output = text;
        }
        
        public static void ImprimirMenu()
        {
            string[] file = File.ReadAllLines(@"..\..\Recursos\StartMenu.txt");
            List<string> toOut = new List<string>();
            foreach(string s in file)
            {
                if (s.StartsWith("start:"))
                {
                    toOut.Add(s);
                }
            }
            int displacement = 0;

            for(int i = 0; i < toOut.Capacity; i++)
            {
                displacement += (i == toOut.Capacity - 1)?0:toOut[i].Length + 1;
                output.AppendText((i == toOut.Capacity - 1)?toOut[i]:toOut[i] + '\n');
                if (i == toOut.Capacity - 1)
                {
                    output.Select(displacement - 1, displacement + 1);
                    output.SelectionFont = new Font("00 Starmap Truetype", 8);
                    output.Select(output.Text.Length - 3, output.Text.Length - 2);
                    output.SelectionFont = new Font("00 Starmap Truetype", 8);
                }


            }

            output.SelectAll();
            output.SelectionAlignment = HorizontalAlignment.Center;
        }

        public void interpretarInput()
        {
            string[] command = input.Text.Split(new char[] { ' ', '\n', '\t' });
            switch (command[0])
            {
                case "help":
                    DisplayHelp();
                    break;
            }
        }

        public void examine<T>(T item, ref RichTextBox consola)
        {
            throw new NotImplementedException();
        }

        public void GoTo(string PlaceName)
        {
            throw new NotImplementedException();
        }

        public void take(Item item)
        {
            throw new NotImplementedException();
        }

        public void eat(Food food)
        {
            throw new NotImplementedException();
        }

        public void drink(Drink drink)
        {
            throw new NotImplementedException();
        }

        public void heal(Medkit med)
        {
            throw new NotImplementedException();
        }

        public void scavenge()
        {
            throw new NotImplementedException();
        }

        private static void DisplayHelp()
        {
            string[] str = File.ReadAllLines(@"..\..\Resources\StartMenu.txt");
            List<string> toOut = new List<string>();
            foreach(string s in str)
            {
                if (s.StartsWith("help:"))
                {
                    toOut.Add(s);
                }
            }


            //output.AppendText()
        }
    }
}

//obo
