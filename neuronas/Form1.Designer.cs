namespace neuronas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.pb_grafico = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnPlano = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_grafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.X2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.X1);
            this.panel1.Controls.Add(this.txtX2);
            this.panel1.Controls.Add(this.txtX1);
            this.panel1.Location = new System.Drawing.Point(1, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 659);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::neuronas.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(23, 330);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(11, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Peso w2 =1 ";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.btnIngresar.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(23, 276);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(220, 48);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(11, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Peso W1 =1 ";
            // 
            // X2
            // 
            this.X2.AutoSize = true;
            this.X2.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.X2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.X2.Location = new System.Drawing.Point(32, 135);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(125, 31);
            this.X2.TabIndex = 4;
            this.X2.Text = "Valor X2";
            this.X2.Click += new System.EventHandler(this.X2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(11, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Umbral de activación: 1.5 ";
            // 
            // X1
            // 
            this.X1.AutoSize = true;
            this.X1.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.X1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.X1.Location = new System.Drawing.Point(32, 29);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(125, 31);
            this.X1.TabIndex = 3;
            this.X1.Text = "Valor X1";
            // 
            // txtX2
            // 
            this.txtX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.txtX2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtX2.Location = new System.Drawing.Point(32, 185);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(220, 38);
            this.txtX2.TabIndex = 2;
            // 
            // txtX1
            // 
            this.txtX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.txtX1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtX1.Location = new System.Drawing.Point(32, 63);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(220, 38);
            this.txtX1.TabIndex = 1;
            // 
            // pb_grafico
            // 
            this.pb_grafico.Location = new System.Drawing.Point(293, 150);
            this.pb_grafico.Name = "pb_grafico";
            this.pb_grafico.Size = new System.Drawing.Size(800, 800);
            this.pb_grafico.TabIndex = 1;
            this.pb_grafico.TabStop = false;
            this.pb_grafico.Click += new System.EventHandler(this.pb_grafico_Click);
            this.pb_grafico.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_grafico_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1325, 26);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.panel3.Location = new System.Drawing.Point(1, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1325, 26);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(259, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "INTELIGENCIA ARTIFICIAL II";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Redes Neuronales";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::neuronas.Properties.Resources.pngwing_com__1_;
            this.pictureBox3.Location = new System.Drawing.Point(1, 163);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(286, 138);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // btnPlano
            // 
            this.btnPlano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.btnPlano.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlano.Location = new System.Drawing.Point(329, 106);
            this.btnPlano.Name = "btnPlano";
            this.btnPlano.Size = new System.Drawing.Size(371, 38);
            this.btnPlano.TabIndex = 12;
            this.btnPlano.Text = "Plano cartesiano";
            this.btnPlano.UseVisualStyleBackColor = false;
            this.btnPlano.Click += new System.EventHandler(this.btnPlano_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1119, 964);
            this.Controls.Add(this.btnPlano);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pb_grafico);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_grafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label X2;
        private Label X1;
        private TextBox txtX2;
        private TextBox txtX1;
        private PictureBox pb_grafico;
        private Button btnIngresar;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnPlano;
    }
}