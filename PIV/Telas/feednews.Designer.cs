namespace PIV.Telas
{
    partial class feednews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(feednews));
            this.ts_menu = new System.Windows.Forms.ToolStrip();
            this.ts_first = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_previous = new System.Windows.Forms.ToolStripButton();
            this.ts_next = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_last = new System.Windows.Forms.ToolStripButton();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDetalhes = new System.Windows.Forms.RichTextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.RichTextBox();
            this.btBusca = new System.Windows.Forms.Button();
            this.ts_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_menu
            // 
            this.ts_menu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_menu.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ts_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_first,
            this.toolStripSeparator2,
            this.ts_previous,
            this.ts_next,
            this.toolStripSeparator1,
            this.ts_last});
            this.ts_menu.Location = new System.Drawing.Point(0, 0);
            this.ts_menu.Name = "ts_menu";
            this.ts_menu.Size = new System.Drawing.Size(904, 26);
            this.ts_menu.TabIndex = 0;
            this.ts_menu.Text = "toolStrip1";
            // 
            // ts_first
            // 
            this.ts_first.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_first.Image = ((System.Drawing.Image)(resources.GetObject("ts_first.Image")));
            this.ts_first.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_first.Name = "ts_first";
            this.ts_first.Size = new System.Drawing.Size(67, 23);
            this.ts_first.Text = "Primeiro";
            this.ts_first.Click += new System.EventHandler(this.ts_first_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // ts_previous
            // 
            this.ts_previous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_previous.Image = ((System.Drawing.Image)(resources.GetObject("ts_previous.Image")));
            this.ts_previous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_previous.Name = "ts_previous";
            this.ts_previous.Size = new System.Drawing.Size(23, 23);
            this.ts_previous.Text = "<";
            this.ts_previous.Click += new System.EventHandler(this.ts_previous_Click);
            // 
            // ts_next
            // 
            this.ts_next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_next.Image = ((System.Drawing.Image)(resources.GetObject("ts_next.Image")));
            this.ts_next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_next.Name = "ts_next";
            this.ts_next.Size = new System.Drawing.Size(23, 23);
            this.ts_next.Text = ">";
            this.ts_next.Click += new System.EventHandler(this.ts_next_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // ts_last
            // 
            this.ts_last.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_last.Image = ((System.Drawing.Image)(resources.GetObject("ts_last.Image")));
            this.ts_last.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_last.Name = "ts_last";
            this.ts_last.Size = new System.Drawing.Size(56, 23);
            this.ts_last.Text = "Ultimo";
            this.ts_last.Click += new System.EventHandler(this.ts_last_Click);
            // 
            // picImagem
            // 
            this.picImagem.BackgroundImage = global::PIV.Properties.Resources.refresh;
            this.picImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagem.Location = new System.Drawing.Point(10, 33);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(375, 321);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 1;
            this.picImagem.TabStop = false;
            this.picImagem.Visible = false;
            this.picImagem.Click += new System.EventHandler(this.picImagem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picImagem);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(493, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 378);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagem";
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalhes.Location = new System.Drawing.Point(8, 148);
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.ReadOnly = true;
            this.txtDetalhes.Size = new System.Drawing.Size(479, 291);
            this.txtDetalhes.TabIndex = 3;
            this.txtDetalhes.Text = "";
            // 
            // lbTitulo
            // 
            this.lbTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(6, 69);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(481, 76);
            this.lbTitulo.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.btBusca);
            this.groupBox2.Controls.Add(this.lbTitulo);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtDetalhes);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(7, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 476);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Feed News";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(6, 29);
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(173, 30);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.Text = "";
            // 
            // btBusca
            // 
            this.btBusca.BackgroundImage = global::PIV.Properties.Resources.buscar;
            this.btBusca.Location = new System.Drawing.Point(185, 29);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(34, 30);
            this.btBusca.TabIndex = 5;
            this.btBusca.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btBusca.UseVisualStyleBackColor = true;
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click);
            // 
            // feednews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PIV.Properties.Resources.esporte;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ts_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "feednews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeedNews";
            this.ts_menu.ResumeLayout(false);
            this.ts_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtDetalhes;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btBusca;
        private System.Windows.Forms.ToolStripButton ts_first;
        private System.Windows.Forms.ToolStripButton ts_previous;
        private System.Windows.Forms.ToolStripButton ts_next;
        private System.Windows.Forms.ToolStripButton ts_last;
        private System.Windows.Forms.RichTextBox txtBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}