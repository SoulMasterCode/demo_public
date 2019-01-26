namespace Proceso
{
    partial class LblProceso
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
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.lblDato1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDato2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDato3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Location = new System.Drawing.Point(376, 235);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(172, 40);
            this.BtnRegresar.TabIndex = 5;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // lblDato1
            // 
            this.lblDato1.AutoSize = true;
            this.lblDato1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDato1.Location = new System.Drawing.Point(284, 121);
            this.lblDato1.Name = "lblDato1";
            this.lblDato1.Size = new System.Drawing.Size(69, 25);
            this.lblDato1.TabIndex = 6;
            this.lblDato1.Text = "Dato1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "+";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDato2
            // 
            this.lblDato2.AutoSize = true;
            this.lblDato2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDato2.Location = new System.Drawing.Point(426, 121);
            this.lblDato2.Name = "lblDato2";
            this.lblDato2.Size = new System.Drawing.Size(69, 25);
            this.lblDato2.TabIndex = 8;
            this.lblDato2.Text = "Dato2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "+";
            // 
            // lblDato3
            // 
            this.lblDato3.AutoSize = true;
            this.lblDato3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDato3.Location = new System.Drawing.Point(599, 121);
            this.lblDato3.Name = "lblDato3";
            this.lblDato3.Size = new System.Drawing.Size(69, 25);
            this.lblDato3.TabIndex = 10;
            this.lblDato3.Text = "Dato3";
            this.lblDato3.Click += new System.EventHandler(this.label4_Click);
            // 
            // LblProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 389);
            this.Controls.Add(this.lblDato3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDato2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDato1);
            this.Controls.Add(this.BtnRegresar);
            this.Name = "LblProceso";
            this.Text = "PROCESO";
            this.Load += new System.EventHandler(this.LblProceso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label lblDato1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDato2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDato3;
    }
}

