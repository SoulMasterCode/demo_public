namespace Kaktura
{
    partial class Kaktura
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
            this.LblDato1 = new System.Windows.Forms.Label();
            this.TxtDato1 = new System.Windows.Forms.TextBox();
            this.TxtDato2 = new System.Windows.Forms.TextBox();
            this.LblDato2 = new System.Windows.Forms.Label();
            this.TxtDato3 = new System.Windows.Forms.TextBox();
            this.LblDato3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(403, 310);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(119, 40);
            this.BtnRegresar.TabIndex = 1;
            this.BtnRegresar.Text = "Regresar...";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // LblDato1
            // 
            this.LblDato1.AutoSize = true;
            this.LblDato1.Location = new System.Drawing.Point(307, 68);
            this.LblDato1.Name = "LblDato1";
            this.LblDato1.Size = new System.Drawing.Size(42, 13);
            this.LblDato1.TabIndex = 2;
            this.LblDato1.Text = "Dato 1:";
            // 
            // TxtDato1
            // 
            this.TxtDato1.Location = new System.Drawing.Point(492, 61);
            this.TxtDato1.Name = "TxtDato1";
            this.TxtDato1.Size = new System.Drawing.Size(100, 20);
            this.TxtDato1.TabIndex = 3;
            this.TxtDato1.TextChanged += new System.EventHandler(this.TxtDato1_TextChanged);
            // 
            // TxtDato2
            // 
            this.TxtDato2.Location = new System.Drawing.Point(492, 149);
            this.TxtDato2.Name = "TxtDato2";
            this.TxtDato2.Size = new System.Drawing.Size(100, 20);
            this.TxtDato2.TabIndex = 5;
            this.TxtDato2.TextChanged += new System.EventHandler(this.TxtDato2_TextChanged);
            // 
            // LblDato2
            // 
            this.LblDato2.AutoSize = true;
            this.LblDato2.Location = new System.Drawing.Point(307, 156);
            this.LblDato2.Name = "LblDato2";
            this.LblDato2.Size = new System.Drawing.Size(42, 13);
            this.LblDato2.TabIndex = 4;
            this.LblDato2.Text = "Dato 2:";
            // 
            // TxtDato3
            // 
            this.TxtDato3.Location = new System.Drawing.Point(492, 230);
            this.TxtDato3.Name = "TxtDato3";
            this.TxtDato3.Size = new System.Drawing.Size(100, 20);
            this.TxtDato3.TabIndex = 7;
            this.TxtDato3.TextChanged += new System.EventHandler(this.TxtDato3_TextChanged);
            // 
            // LblDato3
            // 
            this.LblDato3.AutoSize = true;
            this.LblDato3.Location = new System.Drawing.Point(307, 237);
            this.LblDato3.Name = "LblDato3";
            this.LblDato3.Size = new System.Drawing.Size(42, 13);
            this.LblDato3.TabIndex = 6;
            this.LblDato3.Text = "Dato 3:";
            // 
            // Kaktura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(932, 399);
            this.Controls.Add(this.TxtDato3);
            this.Controls.Add(this.LblDato3);
            this.Controls.Add(this.TxtDato2);
            this.Controls.Add(this.LblDato2);
            this.Controls.Add(this.TxtDato1);
            this.Controls.Add(this.LblDato1);
            this.Controls.Add(this.BtnRegresar);
            this.Name = "Kaktura";
            this.Text = "KAKTURA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label LblDato1;
        private System.Windows.Forms.TextBox TxtDato1;
        private System.Windows.Forms.TextBox TxtDato2;
        private System.Windows.Forms.Label LblDato2;
        private System.Windows.Forms.TextBox TxtDato3;
        private System.Windows.Forms.Label LblDato3;
    }
}

