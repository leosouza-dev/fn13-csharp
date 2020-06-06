namespace OlaMundo
{
    partial class Form1
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
            this.Btn_OlaMundo = new System.Windows.Forms.Button();
            this.Btn_PrimeiraConta = new System.Windows.Forms.Button();
            this.btn_conv = new System.Windows.Forms.Button();
            this.Btn_controle = new System.Windows.Forms.Button();
            this.btn_repeticao = new System.Windows.Forms.Button();
            this.btn_for = new System.Windows.Forms.Button();
            this.btn_rendimento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_OlaMundo
            // 
            this.Btn_OlaMundo.Location = new System.Drawing.Point(12, 12);
            this.Btn_OlaMundo.Name = "Btn_OlaMundo";
            this.Btn_OlaMundo.Size = new System.Drawing.Size(114, 23);
            this.Btn_OlaMundo.TabIndex = 0;
            this.Btn_OlaMundo.Text = "Olá Mundo";
            this.Btn_OlaMundo.UseVisualStyleBackColor = true;
            this.Btn_OlaMundo.Click += new System.EventHandler(this.Btn_OlaMundo_Click);
            // 
            // Btn_PrimeiraConta
            // 
            this.Btn_PrimeiraConta.Location = new System.Drawing.Point(12, 41);
            this.Btn_PrimeiraConta.Name = "Btn_PrimeiraConta";
            this.Btn_PrimeiraConta.Size = new System.Drawing.Size(114, 23);
            this.Btn_PrimeiraConta.TabIndex = 1;
            this.Btn_PrimeiraConta.Text = "Primeira Conta";
            this.Btn_PrimeiraConta.UseVisualStyleBackColor = true;
            this.Btn_PrimeiraConta.Click += new System.EventHandler(this.Btn_PrimeiraConta_Click);
            // 
            // btn_conv
            // 
            this.btn_conv.Location = new System.Drawing.Point(12, 70);
            this.btn_conv.Name = "btn_conv";
            this.btn_conv.Size = new System.Drawing.Size(114, 23);
            this.btn_conv.TabIndex = 2;
            this.btn_conv.Text = "Conversão";
            this.btn_conv.UseVisualStyleBackColor = true;
            this.btn_conv.Click += new System.EventHandler(this.btn_conv_Click);
            // 
            // Btn_controle
            // 
            this.Btn_controle.Location = new System.Drawing.Point(12, 99);
            this.Btn_controle.Name = "Btn_controle";
            this.Btn_controle.Size = new System.Drawing.Size(114, 23);
            this.Btn_controle.TabIndex = 3;
            this.Btn_controle.Text = "Estrutura de Controle";
            this.Btn_controle.UseVisualStyleBackColor = true;
            this.Btn_controle.Click += new System.EventHandler(this.Btn_controle_Click);
            // 
            // btn_repeticao
            // 
            this.btn_repeticao.Location = new System.Drawing.Point(12, 128);
            this.btn_repeticao.Name = "btn_repeticao";
            this.btn_repeticao.Size = new System.Drawing.Size(139, 23);
            this.btn_repeticao.TabIndex = 4;
            this.btn_repeticao.Text = "Estrutura de Repeticao";
            this.btn_repeticao.UseVisualStyleBackColor = true;
            this.btn_repeticao.Click += new System.EventHandler(this.btn_repeticao_Click);
            // 
            // btn_for
            // 
            this.btn_for.Location = new System.Drawing.Point(12, 157);
            this.btn_for.Name = "btn_for";
            this.btn_for.Size = new System.Drawing.Size(139, 23);
            this.btn_for.TabIndex = 5;
            this.btn_for.Text = "For";
            this.btn_for.UseVisualStyleBackColor = true;
            this.btn_for.Click += new System.EventHandler(this.btn_for_Click);
            // 
            // btn_rendimento
            // 
            this.btn_rendimento.Location = new System.Drawing.Point(12, 186);
            this.btn_rendimento.Name = "btn_rendimento";
            this.btn_rendimento.Size = new System.Drawing.Size(139, 23);
            this.btn_rendimento.TabIndex = 6;
            this.btn_rendimento.Text = "Calc. Rendimento";
            this.btn_rendimento.UseVisualStyleBackColor = true;
            this.btn_rendimento.Click += new System.EventHandler(this.btn_rendimento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 235);
            this.Controls.Add(this.btn_rendimento);
            this.Controls.Add(this.btn_for);
            this.Controls.Add(this.btn_repeticao);
            this.Controls.Add(this.Btn_controle);
            this.Controls.Add(this.btn_conv);
            this.Controls.Add(this.Btn_PrimeiraConta);
            this.Controls.Add(this.Btn_OlaMundo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_OlaMundo;
        private System.Windows.Forms.Button Btn_PrimeiraConta;
        private System.Windows.Forms.Button btn_conv;
        private System.Windows.Forms.Button Btn_controle;
        private System.Windows.Forms.Button btn_repeticao;
        private System.Windows.Forms.Button btn_for;
        private System.Windows.Forms.Button btn_rendimento;
    }
}

