namespace PIV.Telas
{
    partial class telaExplosao
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
            this.lbDisplay = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDisplay
            // 
            this.lbDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lbDisplay.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay.ForeColor = System.Drawing.Color.DarkGray;
            this.lbDisplay.Location = new System.Drawing.Point(17, 83);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(579, 285);
            this.lbDisplay.TabIndex = 10;
            this.lbDisplay.Text = "Display";
            this.lbDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Transparent;
            this.btSair.Image = global::PIV.Properties.Resources.saida;
            this.btSair.Location = new System.Drawing.Point(555, 30);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(42, 40);
            this.btSair.TabIndex = 11;
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // telaExplosao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::PIV.Properties.Resources.attention;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(608, 444);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.lbDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaExplosao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explosao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDisplay;
        private System.Windows.Forms.Button btSair;
    }
}