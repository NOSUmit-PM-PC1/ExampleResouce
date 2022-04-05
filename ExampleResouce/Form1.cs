using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExampleResouce
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // для рисунков в папке debug
            // не сохраняютяс картинки на github
            //pictureBox1.Load("p2.jpg");

            // для рисунков хранящихся в папке в проекте
            //string path = Directory.GetCurrentDirectory() + "/images/p1.jpg";
            //pictureBox1.Load(path);

            // для рисунков находящихся в ресурсах
            pictureBox1.Image = Properties.Resources.yellowBoy;
        }
    }
}
