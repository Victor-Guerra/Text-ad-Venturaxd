using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Text_Venture.Clases;

namespace Text_Venture
{
    public partial class Game : Form
    {

        public static MasterControl MC;
        public Game()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MC = new MasterControl(ref picBxPreview, ref lstBxStatus, ref rchTxtOut, ref txtBxInput);
            MC.Startup();
        }

        private void BttnSubmit_Click(object sender, EventArgs e)
        {
            MC.LoadLocations();
            //if (MC.IOC.isStart)
            //    MC.IOC.interpretarInStartup();
            //else
            //    MC.IOC.interpretarInput();
        }
    }
}
