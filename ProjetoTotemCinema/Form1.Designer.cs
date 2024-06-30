namespace ProjetoTotemCinema
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblSala = new System.Windows.Forms.Label();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.txtAssentos = new System.Windows.Forms.TextBox();
            this.lblAssentos = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(35, 170);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 36);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSala.Location = new System.Drawing.Point(35, 58);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(60, 24);
            this.lblSala.TabIndex = 1;
            this.lblSala.Text = "Sala:";
            // 
            // txtSala
            // 
            this.txtSala.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSala.Location = new System.Drawing.Point(117, 59);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(126, 29);
            this.txtSala.TabIndex = 2;
            // 
            // txtAssentos
            // 
            this.txtAssentos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAssentos.Location = new System.Drawing.Point(154, 100);
            this.txtAssentos.Name = "txtAssentos";
            this.txtAssentos.Size = new System.Drawing.Size(89, 29);
            this.txtAssentos.TabIndex = 4;
            // 
            // lblAssentos
            // 
            this.lblAssentos.AutoSize = true;
            this.lblAssentos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAssentos.Location = new System.Drawing.Point(35, 99);
            this.lblAssentos.Name = "lblAssentos";
            this.lblAssentos.Size = new System.Drawing.Size(113, 24);
            this.lblAssentos.TabIndex = 3;
            this.lblAssentos.Text = "Assentos:";
            this.lblAssentos.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(158, 170);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 36);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 273);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtAssentos);
            this.Controls.Add(this.lblAssentos);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.btnSalvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalvar;
        private Label lblSala;
        private TextBox txtSala;
        private TextBox txtAssentos;
        private Label lblAssentos;
        private Button btnLimpar;
    }
}