using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int Hieu(int a, int b)
        {   //tong > hieu
            return a+b;
        }
        public bool login(string username, string password)
        {
            if (username == "admin" && password == "admin")
                return true;
            {
                return false;
            }
        }
    }
}
