using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Threading;

namespace prototype
{
    public partial class MainForm : Form
    {

        SpeechRecognitionEngine speechrecog = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        public MainForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void record_new_button_Click(object sender, EventArgs e)
        {
             
            speechrecog.SetInputToDefaultAudioDevice();

            Choices colors = new Choices();
            colors.Add(new string[] {"hello","how","are", "machine", "door","you", "what","hassan","tipu", "dancer"});

            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(colors);

            Grammar g = new Grammar(gb);
            speechrecog.LoadGrammar(g);
            speechrecog.SpeechRecognized +=new EventHandler<SpeechRecognizedEventArgs>(speechrecog_SpeechRecognized);   
            speechrecog.Recognize();
    //      record_new_button.Enabled = false;
         }
            
        void speechrecog_SpeechRecognized(object sender, SpeechRecognizedEventArgs e) //working
            {
                //MessageBox.Show("Speech recognized: " + e.Result.Text);
                convertedspeech.AppendText(" " + e.Result.Text); 
            }

        private void cancel_button_Click(object sender, EventArgs e)  //working
            {
                System.Windows.Forms.Application.Exit();
            }
        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }
       
        private void STOPRECORDING_Click(object sender, EventArgs e)
        {
          //  speechrecog.RecognizeAsyncStop();
          //  STOPRECORDING.Enabled = false;
          //  record_new_button.Enabled = true;
        }


        
    }
}