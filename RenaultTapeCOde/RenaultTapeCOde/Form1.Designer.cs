namespace RenaultTapeCOde
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt4 = new TextBox();
            txt3 = new TextBox();
            txt2 = new TextBox();
            txt1 = new TextBox();
            gb1 = new GroupBox();
            btnGO = new Button();
            gb1.SuspendLayout();
            SuspendLayout();
            // 
            // txt4
            // 
            txt4.AcceptsReturn = true;
            txt4.AcceptsTab = true;
            txt4.CharacterCasing = CharacterCasing.Upper;
            txt4.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txt4.Location = new Point(508, 200);
            txt4.MaxLength = 1;
            txt4.Name = "txt4";
            txt4.PlaceholderText = "3";
            txt4.Size = new Size(60, 64);
            txt4.TabIndex = 4;
            txt4.TextAlign = HorizontalAlignment.Center;
            txt4.TextChanged += txt4_TextChanged;
            // 
            // txt3
            // 
            txt3.AcceptsReturn = true;
            txt3.AcceptsTab = true;
            txt3.CharacterCasing = CharacterCasing.Upper;
            txt3.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txt3.Location = new Point(442, 200);
            txt3.MaxLength = 1;
            txt3.Name = "txt3";
            txt3.PlaceholderText = "2";
            txt3.Size = new Size(60, 64);
            txt3.TabIndex = 3;
            txt3.TextAlign = HorizontalAlignment.Center;
            txt3.TextChanged += txt3_TextChanged;
            // 
            // txt2
            // 
            txt2.AcceptsReturn = true;
            txt2.AcceptsTab = true;
            txt2.CharacterCasing = CharacterCasing.Upper;
            txt2.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txt2.Location = new Point(376, 200);
            txt2.MaxLength = 1;
            txt2.Name = "txt2";
            txt2.PlaceholderText = "1";
            txt2.Size = new Size(60, 64);
            txt2.TabIndex = 1;
            txt2.TextAlign = HorizontalAlignment.Center;
            txt2.TextChanged += txt2_TextChanged;
            // 
            // txt1
            // 
            txt1.AcceptsReturn = true;
            txt1.AcceptsTab = true;
            txt1.CharacterCasing = CharacterCasing.Upper;
            txt1.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txt1.Location = new Point(310, 200);
            txt1.MaxLength = 1;
            txt1.Name = "txt1";
            txt1.PlaceholderText = "A";
            txt1.Size = new Size(60, 64);
            txt1.TabIndex = 0;
            txt1.TextAlign = HorizontalAlignment.Center;
            txt1.TextChanged += txt1_TextChanged;
            txt1.KeyDown += txt1_KeyDown;
            // 
            // gb1
            // 
            gb1.AutoSize = true;
            gb1.BackColor = SystemColors.ControlDark;
            gb1.BackgroundImage = Properties.Resources.Renault_Logo;
            gb1.BackgroundImageLayout = ImageLayout.Zoom;
            gb1.Controls.Add(btnGO);
            gb1.Controls.Add(txt2);
            gb1.Controls.Add(txt1);
            gb1.Controls.Add(txt4);
            gb1.Controls.Add(txt3);
            gb1.Dock = DockStyle.Fill;
            gb1.Location = new Point(0, 0);
            gb1.Name = "gb1";
            gb1.Size = new Size(887, 658);
            gb1.TabIndex = 7;
            gb1.TabStop = false;
            // 
            // btnGO
            // 
            btnGO.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnGO.Location = new Point(310, 289);
            btnGO.Name = "btnGO";
            btnGO.Size = new Size(258, 75);
            btnGO.TabIndex = 5;
            btnGO.Text = "ŞİFRE BUL";
            btnGO.UseVisualStyleBackColor = true;
            btnGO.Click += btnGO_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 658);
            Controls.Add(gb1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Renault Code Remover by Schanda";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt4;
        private TextBox txt3;
        private TextBox txt2;
        private TextBox txt1;
        private GroupBox gb1;
        private Button btnGO;
    }
}
