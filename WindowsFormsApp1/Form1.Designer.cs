
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btbAdicionar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(770, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "&X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 10;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 28F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(647, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 175);
            this.button2.TabIndex = 7;
            this.button2.Text = "&LIMPAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "OPERAÇÕES ARITIMÉTICAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(53, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "INFORME UM NUMERO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(53, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "INFORME OUTRO NUMERO";
            // 
            // btbAdicionar
            // 
            this.btbAdicionar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btbAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btbAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F);
            this.btbAdicionar.Location = new System.Drawing.Point(50, 539);
            this.btbAdicionar.Name = "btbAdicionar";
            this.btbAdicionar.Size = new System.Drawing.Size(181, 102);
            this.btbAdicionar.TabIndex = 3;
            this.btbAdicionar.Text = "+";
            this.btbAdicionar.UseVisualStyleBackColor = false;
            this.btbAdicionar.Click += new System.EventHandler(this.btbAdicionar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSubtrair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubtrair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F);
            this.btnSubtrair.Location = new System.Drawing.Point(257, 539);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(181, 102);
            this.btnSubtrair.TabIndex = 4;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMultiplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F);
            this.btnMultiplicar.Location = new System.Drawing.Point(461, 539);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(181, 102);
            this.btnMultiplicar.TabIndex = 5;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDividir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F);
            this.btnDividir.Location = new System.Drawing.Point(662, 539);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(181, 102);
            this.btnDividir.TabIndex = 6;
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Black;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Cursor = System.Windows.Forms.Cursors.No;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F);
            this.lblResultado.ForeColor = System.Drawing.Color.Lime;
            this.lblResultado.Location = new System.Drawing.Point(50, 359);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(793, 151);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "RESULTADO";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtN1
            // 
            this.txtN1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F);
            this.txtN1.Location = new System.Drawing.Point(50, 148);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(581, 65);
            this.txtN1.TabIndex = 1;
            this.txtN1.Text = "0";
            this.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtN1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtN1_MouseClick);
            this.txtN1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN2_KeyPress_1);
            // 
            // txtN2
            // 
            this.txtN2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F);
            this.txtN2.Location = new System.Drawing.Point(50, 258);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(581, 65);
            this.txtN2.TabIndex = 2;
            this.txtN2.Text = "0";
            this.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtN2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtN2_MouseClick);
            this.txtN2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN2_KeyPress_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(881, 675);
            this.ControlBox = false;
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btbAdicionar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btbAdicionar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
    }
}

