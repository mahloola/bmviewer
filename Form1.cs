using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OsuMemoryDataProvider;

namespace bmviewer
{
    public partial class Form1 : Form
    {
        string directory = @"E:\osu!\Songs";
        OsuMemoryReader memoryReader = new OsuMemoryReader();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string folderName = memoryReader.GetMapFolderName();
            Console.WriteLine(folderName);
            string fileName = memoryReader.GetOsuFileName();
            Console.WriteLine(fileName);

        }

    }
}
