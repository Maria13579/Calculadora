namespace Calculadora
{
    partial class frmCalculadora
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
            this.lblv1 = new System.Windows.Forms.Label();
            this.lblv2 = new System.Windows.Forms.Label();
            this.lblopera = new System.Windows.Forms.Label();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.txtv2 = new System.Windows.Forms.TextBox();
            this.cmdSuma = new System.Windows.Forms.Button();
            this.cmdResta = new System.Windows.Forms.Button();
            this.cmdMulti = new System.Windows.Forms.Button();
            this.cmdDiv = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblv1
            // 
            this.lblv1.AutoSize = true;
            this.lblv1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblv1.Location = new System.Drawing.Point(199, 60);
            this.lblv1.Name = "lblv1";
            this.lblv1.Size = new System.Drawing.Size(114, 21);
            this.lblv1.TabIndex = 0;
            this.lblv1.Text = "Primer Valor";
            // 
            // lblv2
            // 
            this.lblv2.AutoSize = true;
            this.lblv2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblv2.Location = new System.Drawing.Point(199, 117);
            this.lblv2.Name = "lblv2";
            this.lblv2.Size = new System.Drawing.Size(124, 21);
            this.lblv2.TabIndex = 1;
            this.lblv2.Text = "Segundo Valor";
            this.lblv2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblopera
            // 
            this.lblopera.AutoSize = true;
            this.lblopera.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblopera.Location = new System.Drawing.Point(27, 257);
            this.lblopera.Name = "lblopera";
            this.lblopera.Size = new System.Drawing.Size(122, 27);
            this.lblopera.TabIndex = 2;
            this.lblopera.Text = "Operación";
            // 
            // txtv1
            // 
            this.txtv1.Location = new System.Drawing.Point(334, 61);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(89, 20);
            this.txtv1.TabIndex = 4;
            // 
            // txtv2
            // 
            this.txtv2.Location = new System.Drawing.Point(334, 117);
            this.txtv2.Name = "txtv2";
            this.txtv2.Size = new System.Drawing.Size(89, 20);
            this.txtv2.TabIndex = 5;
            // 
            // cmdSuma
            // 
            this.cmdSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdSuma.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSuma.Location = new System.Drawing.Point(182, 186);
            this.cmdSuma.Name = "cmdSuma";
            this.cmdSuma.Size = new System.Drawing.Size(160, 37);
            this.cmdSuma.TabIndex = 6;
            this.cmdSuma.Text = "Suma";
            this.cmdSuma.UseVisualStyleBackColor = false;
            this.cmdSuma.Click += new System.EventHandler(this.cmdSuma_Click);
            // 
            // cmdResta
            // 
            this.cmdResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdResta.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdResta.ForeColor = System.Drawing.Color.Black;
            this.cmdResta.Location = new System.Drawing.Point(182, 229);
            this.cmdResta.Name = "cmdResta";
            this.cmdResta.Size = new System.Drawing.Size(160, 37);
            this.cmdResta.TabIndex = 7;
            this.cmdResta.Text = "Resta";
            this.cmdResta.UseVisualStyleBackColor = false;
            this.cmdResta.Click += new System.EventHandler(this.cmdResta_Click);
            // 
            // cmdMulti
            // 
            this.cmdMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdMulti.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMulti.Location = new System.Drawing.Point(182, 272);
            this.cmdMulti.Name = "cmdMulti";
            this.cmdMulti.Size = new System.Drawing.Size(160, 37);
            this.cmdMulti.TabIndex = 8;
            this.cmdMulti.Text = "Multiplicación";
            this.cmdMulti.UseVisualStyleBackColor = false;
            this.cmdMulti.Click += new System.EventHandler(this.cmdMulti_Click);
            // 
            // cmdDiv
            // 
            this.cmdDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdDiv.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDiv.Location = new System.Drawing.Point(182, 315);
            this.cmdDiv.Name = "cmdDiv";
            this.cmdDiv.Size = new System.Drawing.Size(160, 37);
            this.cmdDiv.TabIndex = 9;
            this.cmdDiv.Text = "División";
            this.cmdDiv.UseVisualStyleBackColor = false;
            this.cmdDiv.Click += new System.EventHandler(this.cmdDiv_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.BlueViolet;
            this.lblResultado.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(475, 248);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(32, 36);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "0";
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(655, 458);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmdDiv);
            this.Controls.Add(this.cmdMulti);
            this.Controls.Add(this.cmdResta);
            this.Controls.Add(this.cmdSuma);
            this.Controls.Add(this.txtv2);
            this.Controls.Add(this.txtv1);
            this.Controls.Add(this.lblopera);
            this.Controls.Add(this.lblv2);
            this.Controls.Add(this.lblv1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblv1;
        private System.Windows.Forms.Label lblv2;
        private System.Windows.Forms.Label lblopera;
        private System.Windows.Forms.TextBox txtv1;
        private System.Windows.Forms.TextBox txtv2;
        private System.Windows.Forms.Button cmdSuma;
        private System.Windows.Forms.Button cmdResta;
        private System.Windows.Forms.Button cmdMulti;
        private System.Windows.Forms.Button cmdDiv;
        private System.Windows.Forms.Label lblResultado;
    }
}

