
namespace PROYECTO_PROGRA_1.VISTA
{
    partial class FrmPDonar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPDonar));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSalirPDonar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(119, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(397, 173);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btnSalirPDonar
            // 
            this.btnSalirPDonar.Location = new System.Drawing.Point(452, 288);
            this.btnSalirPDonar.Name = "btnSalirPDonar";
            this.btnSalirPDonar.Size = new System.Drawing.Size(115, 41);
            this.btnSalirPDonar.TabIndex = 1;
            this.btnSalirPDonar.Text = "SALIR";
            this.btnSalirPDonar.UseVisualStyleBackColor = true;
            this.btnSalirPDonar.Click += new System.EventHandler(this.btnSalirPDonar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_PROGRA_1.Properties.Resources._gota_sangre;
            this.pictureBox1.Location = new System.Drawing.Point(12, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPDonar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 341);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalirPDonar);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FrmPDonar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PORQUE DONAR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSalirPDonar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}