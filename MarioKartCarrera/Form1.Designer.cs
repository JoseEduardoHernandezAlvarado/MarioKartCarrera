namespace MarioKartCarrera
{
    partial class Form1
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
            this.C2 = new System.Windows.Forms.PictureBox();
            this.C4 = new System.Windows.Forms.PictureBox();
            this.C1 = new System.Windows.Forms.PictureBox();
            this.C3 = new System.Windows.Forms.PictureBox();
            this.C5 = new System.Windows.Forms.PictureBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.btnReinicio = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C5)).BeginInit();
            this.SuspendLayout();
            // 
            // C2
            // 
            this.C2.Image = global::MarioKartCarrera.Properties.Resources.c2;
            this.C2.Location = new System.Drawing.Point(62, 285);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(44, 40);
            this.C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C2.TabIndex = 1;
            this.C2.TabStop = false;
            // 
            // C4
            // 
            this.C4.Image = global::MarioKartCarrera.Properties.Resources.c4;
            this.C4.Location = new System.Drawing.Point(62, 331);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(44, 40);
            this.C4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C4.TabIndex = 2;
            this.C4.TabStop = false;
            // 
            // C1
            // 
            this.C1.Image = global::MarioKartCarrera.Properties.Resources.C1;
            this.C1.Location = new System.Drawing.Point(34, 285);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(44, 40);
            this.C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C1.TabIndex = 3;
            this.C1.TabStop = false;
            // 
            // C3
            // 
            this.C3.Image = global::MarioKartCarrera.Properties.Resources.c3;
            this.C3.Location = new System.Drawing.Point(62, 373);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(44, 40);
            this.C3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C3.TabIndex = 4;
            this.C3.TabStop = false;
            // 
            // C5
            // 
            this.C5.Image = global::MarioKartCarrera.Properties.Resources.c5;
            this.C5.Location = new System.Drawing.Point(34, 360);
            this.C5.Name = "C5";
            this.C5.Size = new System.Drawing.Size(44, 40);
            this.C5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C5.TabIndex = 5;
            this.C5.TabStop = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImage = global::MarioKartCarrera.Properties.Resources.btninicio;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.Location = new System.Drawing.Point(419, 12);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(53, 52);
            this.btnInicio.TabIndex = 6;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnPausa
            // 
            this.btnPausa.BackColor = System.Drawing.Color.Transparent;
            this.btnPausa.BackgroundImage = global::MarioKartCarrera.Properties.Resources.btnpausa;
            this.btnPausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPausa.Location = new System.Drawing.Point(507, 12);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(53, 52);
            this.btnPausa.TabIndex = 7;
            this.btnPausa.UseVisualStyleBackColor = false;
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // btnReinicio
            // 
            this.btnReinicio.BackColor = System.Drawing.Color.Transparent;
            this.btnReinicio.BackgroundImage = global::MarioKartCarrera.Properties.Resources.btnre;
            this.btnReinicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReinicio.Location = new System.Drawing.Point(419, 92);
            this.btnReinicio.Name = "btnReinicio";
            this.btnReinicio.Size = new System.Drawing.Size(53, 52);
            this.btnReinicio.TabIndex = 8;
            this.btnReinicio.UseVisualStyleBackColor = false;
            this.btnReinicio.Click += new System.EventHandler(this.btnReinicio_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.Transparent;
            this.btnDetener.BackgroundImage = global::MarioKartCarrera.Properties.Resources.btnquitar;
            this.btnDetener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetener.Location = new System.Drawing.Point(507, 92);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(53, 52);
            this.btnDetener.TabIndex = 9;
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::MarioKartCarrera.Properties.Resources.CircuitoMario_Kart;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnReinicio);
            this.Controls.Add(this.btnPausa);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.C5);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.C2);
            this.Location = new System.Drawing.Point(-20, 0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox C2;
        private System.Windows.Forms.PictureBox C4;
        private System.Windows.Forms.PictureBox C1;
        private System.Windows.Forms.PictureBox C3;
        private System.Windows.Forms.PictureBox C5;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Button btnReinicio;
        private System.Windows.Forms.Button btnDetener;
    }
}

