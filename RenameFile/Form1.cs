using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string source = @"C:\Users\Kulpot\Desktop\photoshop.Ink";
            const string destination = @"C:\Users\Kulpot\Desktop\photoshop CSS.Ink";

            try
            {
                File.Move(source, destination);
            }
            catch
            {
                MessageBox.Show("Unable to rename file!", Application.ProductName);
            }
        }
    }
}
