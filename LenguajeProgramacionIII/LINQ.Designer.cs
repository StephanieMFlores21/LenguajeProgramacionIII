
namespace LenguajeProgramacionIII
{
    partial class LINQ
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sumabutton = new System.Windows.Forms.Button();
            this.SumaLINQbutton = new System.Windows.Forms.Button();
            this.Paresbutton = new System.Windows.Forms.Button();
            this.ParesLINQbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valores:";
            // 
            // Sumabutton
            // 
            this.Sumabutton.Location = new System.Drawing.Point(347, 38);
            this.Sumabutton.Name = "Sumabutton";
            this.Sumabutton.Size = new System.Drawing.Size(97, 34);
            this.Sumabutton.TabIndex = 2;
            this.Sumabutton.Text = "Suma";
            this.Sumabutton.UseVisualStyleBackColor = true;
            this.Sumabutton.Click += new System.EventHandler(this.Sumabutton_Click);
            // 
            // SumaLINQbutton
            // 
            this.SumaLINQbutton.Location = new System.Drawing.Point(465, 38);
            this.SumaLINQbutton.Name = "SumaLINQbutton";
            this.SumaLINQbutton.Size = new System.Drawing.Size(97, 34);
            this.SumaLINQbutton.TabIndex = 3;
            this.SumaLINQbutton.Text = "Suma LINQ";
            this.SumaLINQbutton.UseVisualStyleBackColor = true;
            this.SumaLINQbutton.Click += new System.EventHandler(this.SumaLINQbutton_Click);
            // 
            // Paresbutton
            // 
            this.Paresbutton.Location = new System.Drawing.Point(347, 94);
            this.Paresbutton.Name = "Paresbutton";
            this.Paresbutton.Size = new System.Drawing.Size(97, 33);
            this.Paresbutton.TabIndex = 4;
            this.Paresbutton.Text = "Pares";
            this.Paresbutton.UseVisualStyleBackColor = true;
            this.Paresbutton.Click += new System.EventHandler(this.Paresbutton_Click);
            // 
            // ParesLINQbutton
            // 
            this.ParesLINQbutton.Location = new System.Drawing.Point(465, 94);
            this.ParesLINQbutton.Name = "ParesLINQbutton";
            this.ParesLINQbutton.Size = new System.Drawing.Size(97, 33);
            this.ParesLINQbutton.TabIndex = 5;
            this.ParesLINQbutton.Text = "Pares";
            this.ParesLINQbutton.UseVisualStyleBackColor = true;
            this.ParesLINQbutton.Click += new System.EventHandler(this.ParesLINQbutton_Click);
            // 
            // LINQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 405);
            this.Controls.Add(this.ParesLINQbutton);
            this.Controls.Add(this.Paresbutton);
            this.Controls.Add(this.SumaLINQbutton);
            this.Controls.Add(this.Sumabutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "LINQ";
            this.Text = "LINQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sumabutton;
        private System.Windows.Forms.Button SumaLINQbutton;
        private System.Windows.Forms.Button Paresbutton;
        private System.Windows.Forms.Button ParesLINQbutton;
    }
}