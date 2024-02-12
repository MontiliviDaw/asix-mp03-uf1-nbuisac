namespace WinFormsApp1 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            button1 = new Button();
            numero1 = new TextBox();
            numero2 = new TextBox();
            resultat = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(654, 44);
            button1.Name = "button1";
            button1.Size = new Size(112, 85);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numero1
            // 
            numero1.Location = new Point(286, 29);
            numero1.Name = "numero1";
            numero1.Size = new Size(210, 23);
            numero1.TabIndex = 1;
            // 
            // numero2
            // 
            numero2.Location = new Point(286, 76);
            numero2.Name = "numero2";
            numero2.Size = new Size(210, 23);
            numero2.TabIndex = 2;
            // 
            // resultat
            // 
            resultat.Location = new Point(286, 131);
            resultat.Name = "resultat";
            resultat.Size = new Size(210, 23);
            resultat.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultat);
            Controls.Add(numero2);
            Controls.Add(numero1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox numero1;
        private TextBox numero2;
        private TextBox resultat;
    }
}
