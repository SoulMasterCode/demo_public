namespace Resultado
{
    partial class Resultado
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
            this.lblSuma = new System.Windows.Forms.Label();
            this.lbligual = new System.Windows.Forms.Label();
            this.lblResultado1 = new System.Windows.Forms.Label();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Location = new System.Drawing.Point(382, 225);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(153, 40);
            this.BtnRegresar.TabIndex = 5;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(295, 91);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(84, 31);
            this.lblSuma.TabIndex = 6;
            this.lblSuma.Text = "Suma";
            // 
            // lbligual
            // 
            this.lbligual.AutoSize = true;
            this.lbligual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbligual.Location = new System.Drawing.Point(376, 91);
            this.lbligual.Name = "lbligual";
            this.lbligual.Size = new System.Drawing.Size(30, 31);
            this.lbligual.TabIndex = 7;
            this.lbligual.Text = "=";
            // 
            // lblResultado1
            // 
            this.lblResultado1.AutoSize = true;
            this.lblResultado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado1.Location = new System.Drawing.Point(412, 91);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(159, 31);
            this.lblResultado1.TabIndex = 8;
            this.lblResultado1.Text = "Resultado 1";
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado2.Location = new System.Drawing.Point(412, 149);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(159, 31);
            this.lblResultado2.TabIndex = 11;
            this.lblResultado2.Text = "Resultado 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resta";
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 369);
            this.Controls.Add(this.lblResultado2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResultado1);
            this.Controls.Add(this.lbligual);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.BtnRegresar);
            this.Name = "Resultado";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lbligual;
        private System.Windows.Forms.Label lblResultado1;
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

