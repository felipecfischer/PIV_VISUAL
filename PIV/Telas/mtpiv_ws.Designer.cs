namespace PIV
{
    partial class mtpiv_ws
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
            this.label1 = new System.Windows.Forms.Label();
            this.btReload = new System.Windows.Forms.Button();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPageTag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbCopa = new System.Windows.Forms.ComboBox();
            this.cbBr = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.label_inf = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recarregar News Feed";
            // 
            // btReload
            // 
            this.btReload.Location = new System.Drawing.Point(282, 21);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(89, 23);
            this.btReload.TabIndex = 4;
            this.btReload.Text = "Iniciar";
            this.btReload.UseVisualStyleBackColor = true;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(181, 24);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(72, 20);
            this.txtPage.TabIndex = 1;
            this.txtPage.TextChanged += new System.EventHandler(this.txtPage_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "/ Páginas";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(92, 26);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(161, 20);
            this.txtTag.TabIndex = 2;
            this.txtTag.TextChanged += new System.EventHandler(this.txtTag_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tags (ex: Copa)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 63);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feeds";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPageTag);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTag);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(15, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 91);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tags";
            // 
            // txtPageTag
            // 
            this.txtPageTag.Location = new System.Drawing.Point(92, 52);
            this.txtPageTag.Name = "txtPageTag";
            this.txtPageTag.Size = new System.Drawing.Size(72, 20);
            this.txtPageTag.TabIndex = 4;
            this.txtPageTag.TextChanged += new System.EventHandler(this.txtPageTag_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Páginas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbCopa);
            this.groupBox3.Controls.Add(this.cbBr);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(15, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 90);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tabelas";
            // 
            // cbCopa
            // 
            this.cbCopa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCopa.FormattingEnabled = true;
            this.cbCopa.Items.AddRange(new object[] {
            "<--Selecione-->",
            "Copa do Brasil",
            "Copa do Nordeste"});
            this.cbCopa.Location = new System.Drawing.Point(92, 53);
            this.cbCopa.Name = "cbCopa";
            this.cbCopa.Size = new System.Drawing.Size(161, 21);
            this.cbCopa.TabIndex = 8;
            this.cbCopa.TextChanged += new System.EventHandler(this.cbCopa_TextChanged);
            // 
            // cbBr
            // 
            this.cbBr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBr.FormattingEnabled = true;
            this.cbBr.Items.AddRange(new object[] {
            "<--Selecione-->",
            "A",
            "B",
            "C",
            "D"});
            this.cbBr.Location = new System.Drawing.Point(92, 24);
            this.cbBr.Name = "cbBr";
            this.cbBr.Size = new System.Drawing.Size(161, 21);
            this.cbBr.TabIndex = 5;
            this.cbBr.TextChanged += new System.EventHandler(this.cbBr_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Brasileirão Série";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Copa Br";
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(282, 79);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(89, 23);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label_inf
            // 
            this.label_inf.AutoSize = true;
            this.label_inf.Location = new System.Drawing.Point(205, 298);
            this.label_inf.Name = "label_inf";
            this.label_inf.Size = new System.Drawing.Size(0, 13);
            this.label_inf.TabIndex = 5;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(282, 50);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(89, 23);
            this.btClear.TabIndex = 10;
            this.btClear.Text = "Limpar";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // mtpiv_ws
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 319);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.label_inf);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btReload);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mtpiv_ws";
            this.Text = "Manutenção WebScraping";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.TextBox txtPageTag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_inf;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ComboBox cbBr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCopa;
    }
}

