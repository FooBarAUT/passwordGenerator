namespace converter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.lowercase = new System.Windows.Forms.CheckBox();
            this.numbers = new System.Windows.Forms.CheckBox();
            this.uppercase = new System.Windows.Forms.CheckBox();
            this.symbols = new System.Windows.Forms.CheckBox();
            this.export = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.CausesValidation = false;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(727, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "\r\nPassword generator";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(12, 177);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(729, 265);
            this.textBox2.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(14, 46);
            this.trackBar1.Maximum = 64;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(685, 56);
            this.trackBar1.TabIndex = 32;
            this.trackBar1.Value = 12;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(705, 51);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(36, 36);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Generate.FlatAppearance.BorderSize = 0;
            this.Generate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.Location = new System.Drawing.Point(224, 123);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(169, 40);
            this.Generate.TabIndex = 17;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Reset.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(574, 123);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(169, 40);
            this.Reset.TabIndex = 18;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // lowercase
            // 
            this.lowercase.AutoSize = true;
            this.lowercase.Location = new System.Drawing.Point(14, 123);
            this.lowercase.Name = "lowercase";
            this.lowercase.Size = new System.Drawing.Size(93, 21);
            this.lowercase.TabIndex = 19;
            this.lowercase.Text = "lowercase";
            this.lowercase.UseVisualStyleBackColor = true;
            this.lowercase.CheckedChanged += new System.EventHandler(this.lowercase_CheckedChanged);
            // 
            // numbers
            // 
            this.numbers.AutoSize = true;
            this.numbers.Location = new System.Drawing.Point(133, 123);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(85, 21);
            this.numbers.TabIndex = 20;
            this.numbers.Text = "numbers";
            this.numbers.UseVisualStyleBackColor = true;
            this.numbers.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // uppercase
            // 
            this.uppercase.AutoSize = true;
            this.uppercase.Location = new System.Drawing.Point(14, 150);
            this.uppercase.Name = "uppercase";
            this.uppercase.Size = new System.Drawing.Size(113, 21);
            this.uppercase.TabIndex = 21;
            this.uppercase.Text = "UPPERCASE";
            this.uppercase.UseVisualStyleBackColor = true;
            // 
            // symbols
            // 
            this.symbols.AutoSize = true;
            this.symbols.Location = new System.Drawing.Point(133, 150);
            this.symbols.Name = "symbols";
            this.symbols.Size = new System.Drawing.Size(81, 21);
            this.symbols.TabIndex = 22;
            this.symbols.Text = "symbols";
            this.symbols.UseVisualStyleBackColor = true;
            // 
            // export
            // 
            this.export.BackColor = System.Drawing.SystemColors.Info;
            this.export.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export.Location = new System.Drawing.Point(399, 123);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(169, 40);
            this.export.TabIndex = 33;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = false;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(133, 91);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(81, 26);
            this.numericUpDown1.TabIndex = 34;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(12, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(115, 19);
            this.textBox4.TabIndex = 35;
            this.textBox4.Text = "How many?";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(755, 455);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.export);
            this.Controls.Add(this.symbols);
            this.Controls.Add(this.uppercase);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.lowercase);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PW-G V5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.CheckBox lowercase;
        private System.Windows.Forms.CheckBox numbers;
        private System.Windows.Forms.CheckBox uppercase;
        private System.Windows.Forms.CheckBox symbols;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox4;
    }
}

