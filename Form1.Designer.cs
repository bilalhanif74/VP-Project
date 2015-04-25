namespace prototype
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.save_doc_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.record_new_button = new System.Windows.Forms.Button();
            this.TimerForSpeech = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(13, 387);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(651, 152);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // save_doc_button
            // 
            this.save_doc_button.Location = new System.Drawing.Point(422, 556);
            this.save_doc_button.Name = "save_doc_button";
            this.save_doc_button.Size = new System.Drawing.Size(104, 28);
            this.save_doc_button.TabIndex = 1;
            this.save_doc_button.Text = "Save Document";
            this.save_doc_button.UseVisualStyleBackColor = true;
            this.save_doc_button.Click += new System.EventHandler(this.save_doc_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(558, 556);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(106, 28);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // record_new_button
            // 
            this.record_new_button.Location = new System.Drawing.Point(13, 41);
            this.record_new_button.Name = "record_new_button";
            this.record_new_button.Size = new System.Drawing.Size(104, 28);
            this.record_new_button.TabIndex = 3;
            this.record_new_button.Text = "Speak Now";
            this.record_new_button.UseVisualStyleBackColor = true;
            this.record_new_button.Click += new System.EventHandler(this.record_new_button_Click);
            // 
            // TimerForSpeech
            // 
            this.TimerForSpeech.Tick += new System.EventHandler(this.TimerForSpeech_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(709, 596);
            this.Controls.Add(this.record_new_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_doc_button);
            this.Controls.Add(this.richTextBox);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "A & H Voice to Text";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button save_doc_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button record_new_button;
        private System.Windows.Forms.Timer TimerForSpeech;
    }
}

