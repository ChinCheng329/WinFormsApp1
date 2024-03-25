namespace WinFormsApp1
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
            textBox1 = new TextBox();
            btnGo = new Button();
            txtShow = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(512, 171);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 54);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(512, 171);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(191, 54);
            btnGo.TabIndex = 1;
            btnGo.Text = "開始";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += button1_Click;
            // 
            // txtShow
            // 
            txtShow.Location = new Point(124, 186);
            txtShow.Name = "txtShow";
            txtShow.Size = new Size(343, 27);
            txtShow.TabIndex = 2;
            txtShow.TextChanged += textBox2_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtShow);
            Controls.Add(btnGo);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnGo;
        private TextBox txtShow;
    }
}
