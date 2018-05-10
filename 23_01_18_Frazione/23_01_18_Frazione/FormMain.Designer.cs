namespace _23_01_18_Frazione
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_fine = new System.Windows.Forms.Button();
            this.text_n1 = new System.Windows.Forms.TextBox();
            this.text_d1 = new System.Windows.Forms.TextBox();
            this.text_d2 = new System.Windows.Forms.TextBox();
            this.text_n2 = new System.Windows.Forms.TextBox();
            this.text_d_ris = new System.Windows.Forms.TextBox();
            this.text_n_ris = new System.Windows.Forms.TextBox();
            this.comboBox_Operator = new System.Windows.Forms.ComboBox();
            this.button_Uguale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frazione 1\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(160, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frazione 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Risultato\r\n";
            // 
            // btn_fine
            // 
            this.btn_fine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fine.Location = new System.Drawing.Point(286, 256);
            this.btn_fine.Name = "btn_fine";
            this.btn_fine.Size = new System.Drawing.Size(75, 23);
            this.btn_fine.TabIndex = 3;
            this.btn_fine.Text = "Fine";
            this.btn_fine.UseVisualStyleBackColor = true;
            this.btn_fine.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_n1
            // 
            this.text_n1.Location = new System.Drawing.Point(12, 64);
            this.text_n1.Name = "text_n1";
            this.text_n1.Size = new System.Drawing.Size(65, 21);
            this.text_n1.TabIndex = 4;
            this.text_n1.Text = "0";
            this.text_n1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_d1
            // 
            this.text_d1.Location = new System.Drawing.Point(12, 112);
            this.text_d1.Name = "text_d1";
            this.text_d1.Size = new System.Drawing.Size(65, 21);
            this.text_d1.TabIndex = 5;
            this.text_d1.Text = "1";
            this.text_d1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_d2
            // 
            this.text_d2.Location = new System.Drawing.Point(151, 112);
            this.text_d2.Name = "text_d2";
            this.text_d2.Size = new System.Drawing.Size(65, 21);
            this.text_d2.TabIndex = 6;
            this.text_d2.Text = "1";
            this.text_d2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_n2
            // 
            this.text_n2.Location = new System.Drawing.Point(151, 64);
            this.text_n2.Name = "text_n2";
            this.text_n2.Size = new System.Drawing.Size(65, 21);
            this.text_n2.TabIndex = 7;
            this.text_n2.Text = "0";
            this.text_n2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_d_ris
            // 
            this.text_d_ris.Location = new System.Drawing.Point(283, 112);
            this.text_d_ris.Name = "text_d_ris";
            this.text_d_ris.Size = new System.Drawing.Size(65, 21);
            this.text_d_ris.TabIndex = 8;
            this.text_d_ris.Text = "1";
            this.text_d_ris.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_n_ris
            // 
            this.text_n_ris.Location = new System.Drawing.Point(283, 64);
            this.text_n_ris.Name = "text_n_ris";
            this.text_n_ris.Size = new System.Drawing.Size(65, 21);
            this.text_n_ris.TabIndex = 9;
            this.text_n_ris.Text = "0";
            this.text_n_ris.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox_Operator
            // 
            this.comboBox_Operator.FormattingEnabled = true;
            this.comboBox_Operator.Items.AddRange(new object[] {
            "   +",
            "   -",
            "   x",
            "   /"});
            this.comboBox_Operator.Location = new System.Drawing.Point(83, 82);
            this.comboBox_Operator.Name = "comboBox_Operator";
            this.comboBox_Operator.Size = new System.Drawing.Size(62, 23);
            this.comboBox_Operator.TabIndex = 10;
            // 
            // button_Uguale
            // 
            this.button_Uguale.BackColor = System.Drawing.Color.White;
            this.button_Uguale.Location = new System.Drawing.Point(222, 82);
            this.button_Uguale.Name = "button_Uguale";
            this.button_Uguale.Size = new System.Drawing.Size(55, 23);
            this.button_Uguale.TabIndex = 11;
            this.button_Uguale.Text = "=";
            this.button_Uguale.UseVisualStyleBackColor = false;
            this.button_Uguale.Click += new System.EventHandler(this.button_Uguale_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(373, 327);
            this.Controls.Add(this.button_Uguale);
            this.Controls.Add(this.comboBox_Operator);
            this.Controls.Add(this.text_n_ris);
            this.Controls.Add(this.text_d_ris);
            this.Controls.Add(this.text_n2);
            this.Controls.Add(this.text_d2);
            this.Controls.Add(this.text_d1);
            this.Controls.Add(this.text_n1);
            this.Controls.Add(this.btn_fine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMain";
            this.Text = "Test Frazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_fine;
        private System.Windows.Forms.TextBox text_n1;
        private System.Windows.Forms.TextBox text_d1;
        private System.Windows.Forms.TextBox text_d2;
        private System.Windows.Forms.TextBox text_n2;
        private System.Windows.Forms.TextBox text_d_ris;
        private System.Windows.Forms.TextBox text_n_ris;
        private System.Windows.Forms.ComboBox comboBox_Operator;
        private System.Windows.Forms.Button button_Uguale;
    }
}

