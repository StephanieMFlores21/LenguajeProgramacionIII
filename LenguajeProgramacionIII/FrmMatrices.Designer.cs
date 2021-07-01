
namespace LenguajeProgramacionIII
{
    partial class FrmMatrices
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
            this.Consultarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.Location = new System.Drawing.Point(188, 180);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(108, 44);
            this.Consultarbutton.TabIndex = 0;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.UseVisualStyleBackColor = true;
            this.Consultarbutton.Click += new System.EventHandler(this.Consultarbutton_Click);
            // 
            // FrmMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 436);
            this.Controls.Add(this.Consultarbutton);
            this.Name = "FrmMatrices";
            this.Text = "FrmMatrices";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Consultarbutton;
    }
}