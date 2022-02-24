namespace Scrambling_Text
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
            this.scrambleText_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scrambleText_button
            // 
            this.scrambleText_button.BackColor = System.Drawing.Color.White;
            this.scrambleText_button.Location = new System.Drawing.Point(528, 490);
            this.scrambleText_button.Name = "scrambleText_button";
            this.scrambleText_button.Size = new System.Drawing.Size(247, 85);
            this.scrambleText_button.TabIndex = 0;
            this.scrambleText_button.Text = "Got to scrambler\r\n";
            this.scrambleText_button.UseVisualStyleBackColor = false;
            this.scrambleText_button.Click += new System.EventHandler(this.scrambleText_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 1178);
            this.Controls.Add(this.scrambleText_button);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button scrambleText_button;
    }
}

