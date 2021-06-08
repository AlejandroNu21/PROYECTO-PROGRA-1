
namespace ProyectoProgramacion.VISTA
{
    partial class FrmRequisitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRequisitos));
            this.btnSalirRequisitos = new System.Windows.Forms.Button();
            this.rtbrequisitos = new System.Windows.Forms.RichTextBox();
            this.rtbrequisitos2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSalirRequisitos
            // 
            this.btnSalirRequisitos.Location = new System.Drawing.Point(663, 393);
            this.btnSalirRequisitos.Name = "btnSalirRequisitos";
            this.btnSalirRequisitos.Size = new System.Drawing.Size(114, 45);
            this.btnSalirRequisitos.TabIndex = 0;
            this.btnSalirRequisitos.Text = "SALIR";
            this.btnSalirRequisitos.UseVisualStyleBackColor = true;
            this.btnSalirRequisitos.Click += new System.EventHandler(this.btnSalirRequisitos_Click);
            // 
            // rtbrequisitos
            // 
            this.rtbrequisitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbrequisitos.Location = new System.Drawing.Point(26, 12);
            this.rtbrequisitos.Name = "rtbrequisitos";
            this.rtbrequisitos.Size = new System.Drawing.Size(354, 350);
            this.rtbrequisitos.TabIndex = 1;
            this.rtbrequisitos.Text = resources.GetString("rtbrequisitos.Text");
            // 
            // rtbrequisitos2
            // 
            this.rtbrequisitos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbrequisitos2.Location = new System.Drawing.Point(389, 12);
            this.rtbrequisitos2.Name = "rtbrequisitos2";
            this.rtbrequisitos2.Size = new System.Drawing.Size(388, 350);
            this.rtbrequisitos2.TabIndex = 2;
            this.rtbrequisitos2.Text = resources.GetString("rtbrequisitos2.Text");
            // 
            // FrmRequisitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbrequisitos2);
            this.Controls.Add(this.rtbrequisitos);
            this.Controls.Add(this.btnSalirRequisitos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRequisitos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requisitos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalirRequisitos;
        private System.Windows.Forms.RichTextBox rtbrequisitos;
        private System.Windows.Forms.RichTextBox rtbrequisitos2;
    }
}