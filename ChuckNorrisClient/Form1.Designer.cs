namespace ChuckNorrisClient
{
    partial class Form1
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
            this.btnGetRandJoke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetRandJoke
            // 
            this.btnGetRandJoke.Location = new System.Drawing.Point(12, 12);
            this.btnGetRandJoke.Name = "btnGetRandJoke";
            this.btnGetRandJoke.Size = new System.Drawing.Size(180, 104);
            this.btnGetRandJoke.TabIndex = 0;
            this.btnGetRandJoke.Text = "Get Random Joke";
            this.btnGetRandJoke.UseVisualStyleBackColor = true;
            this.btnGetRandJoke.Click += new System.EventHandler(this.btnGetRandJoke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 284);
            this.Controls.Add(this.btnGetRandJoke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetRandJoke;
    }
}

