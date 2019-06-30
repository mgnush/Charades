namespace Charades_v1._0
{
    partial class CHARADES
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.drinkbut = new System.Windows.Forms.Button();
            this.cattext = new System.Windows.Forms.TextBox();
            this.drinkCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(510, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "Another!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.generate);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1280, 73);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // drinkbut
            // 
            this.drinkbut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drinkbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.drinkbut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drinkbut.FlatAppearance.BorderSize = 0;
            this.drinkbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drinkbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkbut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drinkbut.Location = new System.Drawing.Point(1133, 585);
            this.drinkbut.Name = "drinkbut";
            this.drinkbut.Size = new System.Drawing.Size(140, 25);
            this.drinkbut.TabIndex = 3;
            this.drinkbut.Text = "Drinking Game Mode";
            this.drinkbut.UseVisualStyleBackColor = false;
            this.drinkbut.Click += new System.EventHandler(this.drinkingMode);
            // 
            // cattext
            // 
            this.cattext.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cattext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cattext.Cursor = System.Windows.Forms.Cursors.Default;
            this.cattext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cattext.Location = new System.Drawing.Point(1090, 125);
            this.cattext.Name = "cattext";
            this.cattext.ReadOnly = true;
            this.cattext.Size = new System.Drawing.Size(178, 19);
            this.cattext.TabIndex = 4;
            // 
            // drinkCount
            // 
            this.drinkCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drinkCount.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkCount.Location = new System.Drawing.Point(591, 229);
            this.drinkCount.Name = "drinkCount";
            this.drinkCount.Size = new System.Drawing.Size(100, 30);
            this.drinkCount.TabIndex = 5;
            this.drinkCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CHARADES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.drinkCount);
            this.Controls.Add(this.cattext);
            this.Controls.Add(this.drinkbut);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CHARADES";
            this.Text = "CHARADES!!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button drinkbut;
        private System.Windows.Forms.TextBox cattext;
        private System.Windows.Forms.TextBox drinkCount;
    }
}

