
namespace LenguajeProgramacionIII
{
    partial class FrmArreglos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ArregloslistBox = new System.Windows.Forms.ListBox();
            this.ejecutarbutton = new System.Windows.Forms.Button();
            this.PaiseslistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ArregloslistBox
            // 
            this.ArregloslistBox.FormattingEnabled = true;
            this.ArregloslistBox.Location = new System.Drawing.Point(30, 134);
            this.ArregloslistBox.Name = "ArregloslistBox";
            this.ArregloslistBox.Size = new System.Drawing.Size(124, 121);
            this.ArregloslistBox.TabIndex = 0;
            // 
            // ejecutarbutton
            // 
            this.ejecutarbutton.Location = new System.Drawing.Point(218, 57);
            this.ejecutarbutton.Name = "ejecutarbutton";
            this.ejecutarbutton.Size = new System.Drawing.Size(104, 39);
            this.ejecutarbutton.TabIndex = 1;
            this.ejecutarbutton.Text = "Ejecutar";
            this.ejecutarbutton.UseVisualStyleBackColor = true;
            this.ejecutarbutton.Click += new System.EventHandler(this.ejecutarbutton_Click);
            // 
            // PaiseslistBox
            // 
            this.PaiseslistBox.FormattingEnabled = true;
            this.PaiseslistBox.Location = new System.Drawing.Point(218, 134);
            this.PaiseslistBox.Name = "PaiseslistBox";
            this.PaiseslistBox.Size = new System.Drawing.Size(132, 147);
            this.PaiseslistBox.TabIndex = 2;
            // 
            // FrmArreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 463);
            this.Controls.Add(this.PaiseslistBox);
            this.Controls.Add(this.ejecutarbutton);
            this.Controls.Add(this.ArregloslistBox);
            this.Name = "FrmArreglos";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ArregloslistBox;
        private System.Windows.Forms.Button ejecutarbutton;
        private System.Windows.Forms.ListBox PaiseslistBox;
    }
}

