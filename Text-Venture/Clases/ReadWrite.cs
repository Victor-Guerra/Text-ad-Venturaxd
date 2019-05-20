using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Text_Venture.Clases.ResourcesClases;
using System.Drawing;
using Newtonsoft.Json;

namespace Text_Venture.Clases
{
    public class ReadWrite : ICommands
    {
        public static TextBox input;
        public static RichTextBox output;
        public List<string> Historial;
        public bool isStart;
        private static int initStep;
        private static string[] StartMenuTxt;
        public ReadWrite(ref RichTextBox text, ref TextBox command)
        {
            StartMenuTxt = File.ReadAllLines(@"..\..\Recursos\StartMenu.txt");
            input = command;
            output = text;
            Historial = new List<string>();
            initStep = 1;
            isStart = true;
        }
        
        public static void ImprimirMenu()
        {
            List<string> toOut = new List<string>();
            foreach(string s in StartMenuTxt)
            {
                if (s.StartsWith("start:"))
                {
                    toOut.Add(s.Remove(0, 6));
                }
            }
            int displacement = 0;

            for(int i = 0; i < toOut.Count; i++)
            {
                displacement += (i == toOut.Count - 1)?0:toOut[i].Length + 1;
                output.AppendText(toOut[i] + '\n');
                if (i == toOut.Count - 1)
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
        public void interpretarInStartup()
        {
            if (initStep == 3)
            {
                Game.MC.player = new Player(input.Text.TrimEnd(' '), 100, 1, 1, "It's you!", "");
                initStep++;
            }
            else
            {
                switch (input.Text.TrimEnd(' '))
                {
                    case "san antonio":
                    case "new orleans":
                    case "los angeles":
                        InitGameSequence();
                        break;
                    case "help":
                        DisplayHelp();
                        break;
                    case "start":
                        Game.MC.LoadLocations();
                        output.Clear();
                        InitGameSequence();
                        break;
                    case "quit":
                    case "exit":
                        Application.Exit();
                        break;
                    default:
                        output.AppendText("No such command." + '\n');
                        break;
                }

                output.SelectAll();
                output.SelectionAlignment = HorizontalAlignment.Center;
                input.ResetText();
            }
        }
        public void interpretarInput()
        {
                string[] command = input.Text.TrimEnd(' ').Split(new char[] { ' ', '\n', '\t' });
                switch (command[0])
                {
                    case "help":
                        DisplayHelp();
                        break;
                    case "quit":
                    case "exit":
                        //Application.Exit();
                        break;
                    default:
                        output.AppendText("No such command." + '\n');
                        break;
                }
            output.SelectAll();
            output.SelectionAlignment = HorizontalAlignment.Center;
            input.ResetText();
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
            List<string> toOut = new List<string>();

            foreach(string s in StartMenuTxt)
            {
                if (s.StartsWith("help:"))
                {
                    toOut.Add(s.Remove(0, 5));
                }
            }
            for(int i = 0; i < toOut.Count; i++)
            {
                output.AppendText(toOut[i] + '\n');
            }
            output.SelectAll();
            output.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void InitGameSequence()
        {
            switch (initStep)
            {
                case 1:
                    foreach (string s in StartMenuTxt)
                    {
                    if (s.StartsWith("init1:"))
                    {
                        output.AppendText(s.Remove(0, 6) + '\n');
                      }
                    }
                    initStep++;
                    break;
                case 2:
                    switch (input.Text)
                    {
                        case "los angeles":
                            MasterControl.difficulty = EDifficulty.EASY;
                            break;
                        case "san antonio":
                            MasterControl.difficulty = EDifficulty.NORMAL;
                            break;
                        case "new orleans":
                            MasterControl.difficulty = EDifficulty.HARD;
                            break;
                        default:
                            output.AppendText("No, no way you got there.");
                            return;
                            break;
                    }
                    foreach (string s in StartMenuTxt)
                    {
                        if (s.StartsWith("init2:"))
                        {
                            output.AppendText(s.Remove(0, 6) + '\n');
                        }
                    }
                    initStep++;
                    break;
                case 4:
                    //ParaTestear
                    //Game.MC.player.
                    break;
            }
        }

        public void look_around()
        {
            throw new NotImplementedException();
        }
    }
    //public static T ParsearJson<T>(string filepath)
    //{
    //    T arr = JsonConvert.DeserializeObject<T>(File.ReadAllText(filepath));
    //    //string[] file = File.ReadAllLines(filepath);
    //    //for(int i = 0; i < file.Length; i++)
    //    //{
    //    //    if (file[i].StartsWith("\"BigCity\":"))
    //    //    {
               
    //    //    }
    //    //}
    //}
}

//obo
