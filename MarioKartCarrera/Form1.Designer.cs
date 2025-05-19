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
            this.Luigi = new System.Windows.Forms.PictureBox();
            this.Toad = new System.Windows.Forms.PictureBox();
            this.Mario = new System.Windows.Forms.PictureBox();
            this.Yoshi = new System.Windows.Forms.PictureBox();
            this.ShyGuy = new System.Windows.Forms.PictureBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.btnReinicio = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Luigi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yoshi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShyGuy)).BeginInit();
            this.SuspendLayout();
            // 
            // Luigi
            // 
            this.Luigi.Image = global::MarioKartCarrera.Properties.Resources.c2;
            this.Luigi.Location = new System.Drawing.Point(61, 286);
            this.Luigi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Luigi.Name = "Luigi";
            this.Luigi.Size = new System.Drawing.Size(44, 39);
            this.Luigi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Luigi.TabIndex = 1;
            this.Luigi.TabStop = false;
            // 
            // Toad
            // 
            this.Toad.Image = global::MarioKartCarrera.Properties.Resources.c4;
            this.Toad.Location = new System.Drawing.Point(61, 331);
            this.Toad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Toad.Name = "Toad";
            this.Toad.Size = new System.Drawing.Size(44, 39);
            this.Toad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Toad.TabIndex = 2;
            this.Toad.TabStop = false;
            // 
            // Mario
            // 
            this.Mario.Image = global::MarioKartCarrera.Properties.Resources.C1;
            this.Mario.Location = new System.Drawing.Point(35, 286);
            this.Mario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mario.Name = "Mario";
            this.Mario.Size = new System.Drawing.Size(44, 39);
            this.Mario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mario.TabIndex = 3;
            this.Mario.TabStop = false;
            // 
            // Yoshi
            // 
            this.Yoshi.Image = global::MarioKartCarrera.Properties.Resources.c3;
            this.Yoshi.Location = new System.Drawing.Point(61, 373);
            this.Yoshi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Yoshi.Name = "Yoshi";
            this.Yoshi.Size = new System.Drawing.Size(44, 39);
            this.Yoshi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Yoshi.TabIndex = 4;
            this.Yoshi.TabStop = false;
            // 
            // ShyGuy
            // 
            this.ShyGuy.Image = global::MarioKartCarrera.Properties.Resources.c5;
            this.ShyGuy.Location = new System.Drawing.Point(35, 359);
            this.ShyGuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShyGuy.Name = "ShyGuy";
            this.ShyGuy.Size = new System.Drawing.Size(44, 39);
            this.ShyGuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShyGuy.TabIndex = 5;
            this.ShyGuy.TabStop = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImage = global::MarioKartCarrera.Properties.Resources.btninicio;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.Location = new System.Drawing.Point(419, 12);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnPausa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnReinicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnDetener.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.ClientSize = new System.Drawing.Size(981, 654);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnReinicio);
            this.Controls.Add(this.btnPausa);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.ShyGuy);
            this.Controls.Add(this.Yoshi);
            this.Controls.Add(this.Mario);
            this.Controls.Add(this.Toad);
            this.Controls.Add(this.Luigi);
            this.Location = new System.Drawing.Point(-20, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Luigi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yoshi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShyGuy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Luigi;
        private System.Windows.Forms.PictureBox Toad;
        private System.Windows.Forms.PictureBox Mario;
        private System.Windows.Forms.PictureBox Yoshi;
        private System.Windows.Forms.PictureBox ShyGuy;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Button btnReinicio;
        private System.Windows.Forms.Button btnDetener;
    }
}

