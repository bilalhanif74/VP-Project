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
            this.convertedspeech = new System.Windows.Forms.RichTextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.record_new_button = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.STOPRECORDING = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // convertedspeech
            // 
            this.convertedspeech.Location = new System.Drawing.Point(12, 210);
            this.convertedspeech.Name = "convertedspeech";
            this.convertedspeech.Size = new System.Drawing.Size(651, 152);
            this.convertedspeech.TabIndex = 0;
            this.convertedspeech.Text = "";
            this.convertedspeech.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(557, 368);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(106, 28);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // record_new_button
            // 
            this.record_new_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.record_new_button.BackColor = System.Drawing.SystemColors.Control;
            this.record_new_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.record_new_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.record_new_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.record_new_button.Image = global::prototype.Properties.Resources._13652249372108434179Record_Button_Microphone_svg_thumb;
            this.record_new_button.Location = new System.Drawing.Point(30, 29);
            this.record_new_button.Name = "record_new_button";
            this.record_new_button.Size = new System.Drawing.Size(121, 123);
            this.record_new_button.TabIndex = 3;
            this.record_new_button.Text = "Speak Now";
            this.record_new_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.record_new_button.UseVisualStyleBackColor = false;
            this.record_new_button.Click += new System.EventHandler(this.record_new_button_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar.Location = new System.Drawing.Point(157, 87);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(387, 47);
            this.progressBar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "00:00:00";
            // 
            // STOPRECORDING
            // 
            this.STOPRECORDING.BackgroundImage = global::prototype.Properties.Resources.Stop1NormalRed;
            this.STOPRECORDING.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.STOPRECORDING.Enabled = false;
            this.STOPRECORDING.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.STOPRECORDING.FlatAppearance.BorderSize = 0;
            this.STOPRECORDING.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.STOPRECORDING.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STOPRECORDING.Location = new System.Drawing.Point(557, 55);
            this.STOPRECORDING.Name = "STOPRECORDING";
            this.STOPRECORDING.Size = new System.Drawing.Size(90, 79);
            this.STOPRECORDING.TabIndex = 6;
            this.STOPRECORDING.Text = "STOP";
            this.STOPRECORDING.UseVisualStyleBackColor = true;
            this.STOPRECORDING.Click += new System.EventHandler(this.STOPRECORDING_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(702, 416);
            this.Controls.Add(this.STOPRECORDING);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.record_new_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.convertedspeech);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Voice to Text";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox convertedspeech;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button record_new_button;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button STOPRECORDING;
    }
}

