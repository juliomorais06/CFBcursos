namespace Aula63_Componentes
{
    partial class F_Veiculos
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
            this.tb_listaVeiculos2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_listaVeiculos2
            // 
            this.tb_listaVeiculos2.Location = new System.Drawing.Point(12, 12);
            this.tb_listaVeiculos2.Multiline = true;
            this.tb_listaVeiculos2.Name = "tb_listaVeiculos2";
            this.tb_listaVeiculos2.Size = new System.Drawing.Size(556, 459);
            this.tb_listaVeiculos2.TabIndex = 0;
            // 
            // F_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 483);
            this.Controls.Add(this.tb_listaVeiculos2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Veículos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Veiculos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_listaVeiculos2;
    }
}