
namespace Numero_Mayor_de_5_2._0
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
            this.Btn1 = new System.Windows.Forms.Button();
            this.Etique1 = new System.Windows.Forms.Label();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.txtb4 = new System.Windows.Forms.TextBox();
            this.txtb3 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.Etique2 = new System.Windows.Forms.Label();
            this.Etique3 = new System.Windows.Forms.Label();
            this.Etique4 = new System.Windows.Forms.Label();
            this.Etique5 = new System.Windows.Forms.Label();
            this.txtb5 = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(490, 251);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(141, 39);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "Iniciar";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Etique1
            // 
            this.Etique1.AutoSize = true;
            this.Etique1.Location = new System.Drawing.Point(420, 25);
            this.Etique1.Name = "Etique1";
            this.Etique1.Size = new System.Drawing.Size(87, 23);
            this.Etique1.TabIndex = 1;
            this.Etique1.Text = "Numero 1";
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(513, 25);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(100, 30);
            this.txtb1.TabIndex = 2;
            // 
            // txtb4
            // 
            this.txtb4.Location = new System.Drawing.Point(513, 133);
            this.txtb4.Name = "txtb4";
            this.txtb4.Size = new System.Drawing.Size(100, 30);
            this.txtb4.TabIndex = 3;
            // 
            // txtb3
            // 
            this.txtb3.Location = new System.Drawing.Point(513, 97);
            this.txtb3.Name = "txtb3";
            this.txtb3.Size = new System.Drawing.Size(100, 30);
            this.txtb3.TabIndex = 4;
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(513, 61);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(100, 30);
            this.txtb2.TabIndex = 5;
            // 
            // Etique2
            // 
            this.Etique2.AutoSize = true;
            this.Etique2.Location = new System.Drawing.Point(420, 61);
            this.Etique2.Name = "Etique2";
            this.Etique2.Size = new System.Drawing.Size(87, 23);
            this.Etique2.TabIndex = 6;
            this.Etique2.Text = "Numero 2";
            // 
            // Etique3
            // 
            this.Etique3.AutoSize = true;
            this.Etique3.Location = new System.Drawing.Point(420, 97);
            this.Etique3.Name = "Etique3";
            this.Etique3.Size = new System.Drawing.Size(87, 23);
            this.Etique3.TabIndex = 7;
            this.Etique3.Text = "Numero 3";
            // 
            // Etique4
            // 
            this.Etique4.AutoSize = true;
            this.Etique4.Location = new System.Drawing.Point(420, 133);
            this.Etique4.Name = "Etique4";
            this.Etique4.Size = new System.Drawing.Size(87, 23);
            this.Etique4.TabIndex = 8;
            this.Etique4.Text = "Numero 4";
            this.Etique4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Etique5
            // 
            this.Etique5.AutoSize = true;
            this.Etique5.Location = new System.Drawing.Point(420, 167);
            this.Etique5.Name = "Etique5";
            this.Etique5.Size = new System.Drawing.Size(87, 23);
            this.Etique5.TabIndex = 9;
            this.Etique5.Text = "Numero 5";
            // 
            // txtb5
            // 
            this.txtb5.Location = new System.Drawing.Point(513, 167);
            this.txtb5.Name = "txtb5";
            this.txtb5.Size = new System.Drawing.Size(100, 30);
            this.txtb5.TabIndex = 10;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(535, 211);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(19, 23);
            this.Resultado.TabIndex = 11;
            this.Resultado.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.txtb5);
            this.Controls.Add(this.Etique5);
            this.Controls.Add(this.Etique4);
            this.Controls.Add(this.Etique3);
            this.Controls.Add(this.Etique2);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.txtb3);
            this.Controls.Add(this.txtb4);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.Etique1);
            this.Controls.Add(this.Btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Label Etique1;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.TextBox txtb4;
        private System.Windows.Forms.TextBox txtb3;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.Label Etique2;
        private System.Windows.Forms.Label Etique3;
        private System.Windows.Forms.Label Etique4;
        private System.Windows.Forms.Label Etique5;
        private System.Windows.Forms.TextBox txtb5;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Label label1;
    }
}

