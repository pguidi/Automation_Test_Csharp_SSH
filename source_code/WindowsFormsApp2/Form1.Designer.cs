namespace WindowsFormsApp2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discbtn = new System.Windows.Forms.Button();
            this.Showdisc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.texttxtfile = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MILAN",
            "E7(115)",
            "E7(117)",
            "E7(118)"});
            this.comboBox1.Location = new System.Drawing.Point(59, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "OLT";
            // 
            // discbtn
            // 
            this.discbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discbtn.Location = new System.Drawing.Point(27, 61);
            this.discbtn.Name = "discbtn";
            this.discbtn.Size = new System.Drawing.Size(262, 25);
            this.discbtn.TabIndex = 2;
            this.discbtn.Text = "Discover ONT";
            this.discbtn.UseVisualStyleBackColor = true;
            this.discbtn.Click += new System.EventHandler(this.discbtn_Click_1);
            // 
            // Showdisc
            // 
            this.Showdisc.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Showdisc.ForeColor = System.Drawing.SystemColors.Window;
            this.Showdisc.Location = new System.Drawing.Point(27, 101);
            this.Showdisc.Multiline = true;
            this.Showdisc.Name = "Showdisc";
            this.Showdisc.Size = new System.Drawing.Size(899, 239);
            this.Showdisc.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(820, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // texttxtfile
            // 
            this.texttxtfile.Location = new System.Drawing.Point(28, 361);
            this.texttxtfile.Name = "texttxtfile";
            this.texttxtfile.Size = new System.Drawing.Size(772, 232);
            this.texttxtfile.TabIndex = 6;
            this.texttxtfile.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 618);
            this.Controls.Add(this.texttxtfile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Showdisc);
            this.Controls.Add(this.discbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button discbtn;
        private System.Windows.Forms.TextBox Showdisc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox texttxtfile;
    }
}

