using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


namespace prototype
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void record_new_button_Click(object sender, EventArgs e)
        {
            this.timer.Start();
            
        }

        private void cancel_button_Click(object sender, EventArgs e)  //working
        {
            System.Windows.Forms.Application.Exit();
        }

   
        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProgressBar obj = new ProgressBar();
            obj.Show();
            obj.
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}