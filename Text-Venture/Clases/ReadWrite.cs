using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Text_Venture.Clases.ResourcesClases;
using System.Drawing;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Reflection;

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
        private static string[] CommandsTxt;
        private static Queue<string> BuferOutput;
        private static Queue<string> BuferInput;
        protected static Assembly assembly;
        //private static WaitHandle wait;
        //private Dictionary<string, ECommands> commandDic;

        public ReadWrite(ref RichTextBox text, ref TextBox command)
        {
            StartMenuTxt = File.ReadAllLines(@"..\..\Recursos\StartMenu.txt");
            CommandsTxt = File.ReadAllLines(@"..\..\Recursos\Commands.txt");
            input = command;
            output = text;
            Historial = new List<string>();
            initStep = 1;
            isStart = true;
            BuferOutput = new Queue<string>();
            BuferInput = new Queue<string>();
            assembly = Assembly.GetExecutingAssembly();
            //wait = new EventWaitHandle(false, EventResetMode.ManualReset);
            //commandDic = new Dictionary<string, ECommands>();
        }


        private static void PrintOutput()
        {
            foreach (string s in BuferOutput)
            {
                output.AppendText(s + '\n');
            }
            BuferOutput.Clear();
            output.SelectAll();
            output.SelectionAlignment = HorizontalAlignment.Center;
        }
        private static void PrintOutput(System.Drawing.Color color, params string[] substr)
        {

            foreach (string s in BuferOutput)
            {
                output.AppendText(s + '\n');
                foreach (string str in substr)
                {
                    Regex rx = new Regex(@"(?:" + str + ")");
                    if (rx.IsMatch(s))
                    {
                        output.Select(output.Find(str, output.TextLength - s.Length, RichTextBoxFinds.None), str.Length);
                        output.SelectionColor = color;
                    }

                }
            }
            BuferOutput.Clear();
            output.SelectAll();
            output.SelectionAlignment = HorizontalAlignment.Center;
        }
        private static void PrintOutput(Font font, params string[] substr)
        {

            foreach (string s in BuferOutput)   
            {
                output.AppendText(s + '\n');
            }
            foreach (string str in substr)
            {

                Regex rx = new Regex(@"(?:" + str + ")");
                if (rx.IsMatch(output.Text))
                {
                    output.Select(output.Find(str, 0, RichTextBoxFinds.None), str.Length);
                    output.SelectionFont = font;
                }


            }
            BuferOutput.Clear();
            output.SelectAll();
            output.SelectionAlignment = HorizontalAlignment.Center;
        }
        public static void ImprimirMenu()
        {

            foreach (string s in StartMenuTxt)
            {
                if (s.StartsWith("start:"))
                {
                    BuferOutput.Enqueue(s.Remove(0, 6));
                }
            }
            PrintOutput(new Font("00 Starmap Truetype", 8), new string[] { "<<", ">>" });
        }

        public void Interpretar(string inp)
        {
            foreach (string s in inp.Split(' '))
                BuferInput.Enqueue(s);

            if (isStart)
            {
                InitGameSequence(BuferInput.First());
                BuferInput.Clear();
            }
            else
            {
                interpretarInput();
            }
        }

        //public void interpretarInStartup()
        //{
        //    foreach (string argument in input.Text.Split(' '))
        //    {
        //        BuferInput.Enqueue(argument);
        //    }


        //    if (initStep == 3)
        //    {
        //        Game.MC.player.name = input.Text.TrimEnd(' ');
        //        initStep++;
        //        InitGameSequence();
        //    }
        //    else
        //    {
        //        switch (BuferInput.First())
        //        {
        //            case "san antonio":
        //            case "new orleans":
        //            case "los angeles":
        //                InitGameSequence();
        //                break;
        //            case "help":
        //                DisplayHelp();
        //                break;
        //            case "start":
        //                output.Clear();
        //                InitGameSequence();
        //                break;
        //            case "quit":
        //            case "exit":
        //                Application.Exit();
        //                break;
        //            default:
        //                output.AppendText("No such command." + '\n');
        //                break;
        //        }

        //        output.SelectAll();
        //        output.SelectionAlignment = HorizontalAlignment.Center;
        //        input.ResetText();
        //    }
        //}
        public void interpretarInput()
        {
            //string[] command = input.Text.TrimEnd(' ').Split(' ');
            string c = input.Text;
            //foreach (string str in CommandsTxt)
            if ((c.StartsWith(CommandsTxt[3])) || (c.StartsWith(CommandsTxt[4])) || (c.StartsWith(CommandsTxt[5])))
            {
                this.look_around(); Historial.Add(c);
            }
            else if ((c.StartsWith(CommandsTxt[6])))
            {
                DisplayHelp(); Historial.Add(c);
            }
            else if (c.StartsWith(CommandsTxt[0]) || c.StartsWith(CommandsTxt[1]) || c.StartsWith(CommandsTxt[2]))
                if (c.StartsWith(CommandsTxt[0]))
                {
                    this.GoTo(c.Remove(0, (CommandsTxt[0].Length)));
                }
                else if (c.StartsWith(CommandsTxt[1]))
                {
                    this.GoTo(c.Remove(0, (CommandsTxt[1].Length)));
                }
                else
                {
                    this.GoTo(c.Remove(0, (CommandsTxt[2].Length)));
                }
            else if (c.StartsWith(CommandsTxt[7]) || c.StartsWith(CommandsTxt[8]))
            {
                this.PreExit();
            }
            else if (c.StartsWith(CommandsTxt[9]))
            {
                //this.use(); Historial.Add(c);
            }
            else if (c.StartsWith(CommandsTxt[10]))
            {
                // this.take(c.Remove(0,CommandsTxt[10].Length)); Historial.Add(c);
            }
            else if (c.StartsWith(CommandsTxt[11]))
            {
                //Game.MC.player.Attack(ref );
            }
            else
            {
                output.AppendText("No such command." + '\n');
            }
            output.SelectAll();
            output.SelectionAlignment = HorizontalAlignment.Center;
            input.ResetText();
        }

        private void PreExit()
        {
        //    var sample = typeof(Commandos);
        //    var metodo = sample.GetMethod();
        //    metodo.Invoke(Game.MC.player, );
            File.WriteAllLines(@"..\..\Recursos\Historial.txt", Historial);
            input.Clear();
            Application.Exit();

        }

        [Commandos("examine")]
        public void examine<T>(T item, ref RichTextBox consola)
        {
            throw new NotImplementedException();
        }

        [Commandos("go to")]
        public void GoTo(string PlaceName)
        {
            Game.MC.player.GoTo(PlaceName);
            MasterControl.displayImg.ImageLocation = Game.MC.locs[PlaceName].FilePath;
            output.AppendText(Game.MC.locs[PlaceName].DESC + '\n');
        }

        [Commandos("help")]
        private static void DisplayHelp()
        {
            foreach (string s in StartMenuTxt)
            {
                if (s.StartsWith("help:"))
                {
                    BuferOutput.Enqueue(s.Remove(0, 5));
                }
            }
            PrintOutput(Color.Red, new string[] {"abscond", "attack" });

        }

        private void InitGameSequence(string strin)
        {
            switch (strin)
            {
                case "start":
                    foreach (string s in StartMenuTxt)
                    {
                        if (s.StartsWith("init1:"))
                        {
                            BuferOutput.Enqueue(s.Remove(0, 6));
                        }
                    }
                    PrintOutput();
                    switch (input.Text)
                    {
                        case "los angeles":
                            MasterControl.difficulty = EDifficulty.EASY;
                            Game.MC.player.GoTo("los angeles");
                            break;
                        case "san antonio":
                            MasterControl.difficulty = EDifficulty.NORMAL;
                            Game.MC.player.GoTo("san antonio");
                            break;
                        case "new orleans":
                            MasterControl.difficulty = EDifficulty.HARD;
                            Game.MC.player.GoTo("new orleans");
                            break;
                        default:
                            output.AppendText("No, no way you got there.");
                            return;
                    }
                    foreach (string s in StartMenuTxt)
                    {
                        if (s.StartsWith("init2:"))
                        {
                            BuferOutput.Enqueue(s.Remove(0, 6) + '\n');
                        }
                    }
                    initStep++;
                    foreach (string s in BuferOutput)
                    {
                        output.AppendText(s);
                        BuferOutput.Dequeue();

                    }
                    break;
                case "a":
                    //ParaTestear
                    foreach (string s in StartMenuTxt)
                    {
                        if (s.StartsWith("init4:"))
                        {
                            output.AppendText(s.Remove(0, 6) + '\n');
                        }
                    }
                    output.SelectAll();
                    output.SelectionAlignment = HorizontalAlignment.Center;
                    input.Clear();
                    initStep = 0;
                    isStart = false;
                    playGame();
                    break;



                case "help":
                    DisplayHelp();
                    break;
                case "quit":
                case "exit":
                    Application.Exit();
                    break;
                default:
                    BuferOutput.Enqueue("Unknown Command.");
                    PrintOutput();
                    break;
            }
        }




    private void playGame()
        {
            string temp = "Your name is " + Game.MC.player.name.ToUpper() + ", you have heard rumors that the zombie outbreak has not affected Canada. You are currently in " + Game.MC.player.location.NAME.ToUpper() + " .\n\n";
            output.AppendText(temp);
            output.AppendText(Game.MC.player.location.DESC);
            output.AppendText("There seems to be a" + Game.MC.player.location.onLook());
            output.AppendText("What do you do?\n");

            output.SelectAll();
            output.SelectionAlignment = HorizontalAlignment.Center;
        }

        public void look_around()
        {
            output.AppendText(Game.MC.player.location.onLook() + '\n');
        }

        public void take<T>(T item) where T : Resource
        {
            output.AppendText(item.ToDisplay(item.Size));
            Game.MC.player.take(item);
        }

        public void use(Resource resource)
        {
            throw new NotImplementedException();
        }
    }

}

//obo
