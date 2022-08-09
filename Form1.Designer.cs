namespace DeterminandoMaiorValor
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
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblNumero3 = new System.Windows.Forms.Label();
            this.txtBoxNum1 = new System.Windows.Forms.TextBox();
            this.txtBoxNum2 = new System.Windows.Forms.TextBox();
            this.txtBoxNum3 = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(0, 19);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(57, 15);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Número  ";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(0, 44);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(51, 15);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Número";
            // 
            // lblNumero3
            // 
            this.lblNumero3.AutoSize = true;
            this.lblNumero3.Location = new System.Drawing.Point(0, 74);
            this.lblNumero3.Name = "lblNumero3";
            this.lblNumero3.Size = new System.Drawing.Size(51, 15);
            this.lblNumero3.TabIndex = 2;
            this.lblNumero3.Text = "Número";
            // 
            // txtBoxNum1
            // 
            this.txtBoxNum1.Location = new System.Drawing.Point(53, 11);
            this.txtBoxNum1.Name = "txtBoxNum1";
            this.txtBoxNum1.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNum1.TabIndex = 3;
            // 
            // txtBoxNum2
            // 
            this.txtBoxNum2.Location = new System.Drawing.Point(53, 41);
            this.txtBoxNum2.Name = "txtBoxNum2";
            this.txtBoxNum2.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNum2.TabIndex = 4;
            // 
            // txtBoxNum3
            // 
            this.txtBoxNum3.Location = new System.Drawing.Point(53, 71);
            this.txtBoxNum3.Name = "txtBoxNum3";
            this.txtBoxNum3.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNum3.TabIndex = 5;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(3, 104);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(150, 23);
            this.btnValidar.TabIndex = 6;
            this.btnValidar.Text = "Validar Maior Número";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 142);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(150, 132);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 299);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtBoxNum3);
            this.Controls.Add(this.txtBoxNum2);
            this.Controls.Add(this.txtBoxNum1);
            this.Controls.Add(this.lblNumero3);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumero1;
        private Label lblNumero2;
        private Label lblNumero3;
        private TextBox txtBoxNum1;
        private TextBox txtBoxNum2;
        private TextBox txtBoxNum3;
        private Button btnValidar;
        private RichTextBox richTextBox1;
    }
}