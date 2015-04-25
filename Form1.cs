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
            Timer obj = new Timer();
            obj.Start();
            
        }

        private void save_doc_button_Click(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void TimerForSpeech_Tick(object sender, EventArgs e)
        {

        }
    }
}
