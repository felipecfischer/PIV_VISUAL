namespace PIV.Telas
{
    partial class brasileiro
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
            this.dvTabela = new System.Windows.Forms.DataGridView();
            this.cbSerie = new System.Windows.Forms.ComboBox();
            this.lbBr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // dvTabela
            // 
            this.dvTabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvTabela.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvTabela.BackgroundColor = System.Drawing.Color.White;
            this.dvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvTabela.Location = new System.Drawing.Point(171, 12);
            this.dvTabela.Name = "dvTabela";
            this.dvTabela.ReadOnly = true;
            this.dvTabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvTabela.Size = new System.Drawing.Size(854, 518);
            this.dvTabela.TabIndex = 0;
            // 
            // cbSerie
            // 
            this.cbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerie.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSerie.FormattingEnabled = true;
            this.cbSerie.Location = new System.Drawing.Point(8, 99);
            this.cbSerie.Name = "cbSerie";
            this.cbSerie.Size = new System.Drawing.Size(157, 31);
            this.cbSerie.TabIndex = 13;
            this.cbSerie.SelectedValueChanged += new System.EventHandler(this.cbSerie_SelectedValueChanged);
            // 
            // lbBr
            // 
            this.lbBr.BackColor = System.Drawing.Color.Transparent;
            this.lbBr.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Italic);
            this.lbBr.Image = global::PIV.Properties.Resources.brasileirao;
            this.lbBr.Location = new System.Drawing.Point(47, 22);
            this.lbBr.Name = "lbBr";
            this.lbBr.Size = new System.Drawing.Size(72, 74);
            this.lbBr.TabIndex = 17;
            // 
            // brasileiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PIV.Properties.Resources.brasileirao_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1037, 554);
            this.Controls.Add(this.lbBr);
            this.Controls.Add(this.cbSerie);
            this.Controls.Add(this.dvTabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "brasileiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brasileirão";
            ((System.ComponentModel.ISupportInitialize)(this.dvTabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvTabela;
        private System.Windows.Forms.ComboBox cbSerie;
        private System.Windows.Forms.Label lbBr;
    }
}