namespace silnia
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
            label1 = new Label();
            label2 = new Label();
            stopien = new TextBox();
            button1 = new Button();
            wynik = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 30);
            label1.Name = "label1";
            label1.Size = new Size(397, 32);
            label1.TabIndex = 0;
            label1.Text = "Program obliczający silnię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(42, 134);
            label2.Name = "label2";
            label2.Size = new Size(190, 29);
            label2.TabIndex = 1;
            label2.Text = "Podaj stopień:";
            // 
            // stopien
            // 
            stopien.Location = new Point(238, 132);
            stopien.Name = "stopien";
            stopien.Size = new Size(150, 31);
            stopien.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(394, 131);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "oblicz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // wynik
            // 
            wynik.AutoSize = true;
            wynik.Location = new Point(534, 140);
            wynik.Name = "wynik";
            wynik.Size = new Size(0, 25);
            wynik.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(wynik);
            Controls.Add(button1);
            Controls.Add(stopien);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox stopien;
        private Button button1;
        private Label wynik;
    }
}
