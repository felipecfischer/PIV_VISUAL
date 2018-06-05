namespace PIV
{
    partial class exec
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
            this.txtExec = new System.Windows.Forms.TextBox();
            this.btExec = new System.Windows.Forms.Button();
            this.lbExec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtExec
            // 
            this.txtExec.Location = new System.Drawing.Point(122, 28);
            this.txtExec.Name = "txtExec";
            this.txtExec.Size = new System.Drawing.Size(171, 20);
            this.txtExec.TabIndex = 0;
            this.txtExec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExec_KeyPress);
            // 
            // btExec
            // 
            this.btExec.Location = new System.Drawing.Point(218, 54);
            this.btExec.Name = "btExec";
            this.btExec.Size = new System.Drawing.Size(75, 23);
            this.btExec.TabIndex = 1;
            this.btExec.Text = "Executar";
            this.btExec.UseVisualStyleBackColor = true;
            this.btExec.Click += new System.EventHandler(this.btExec_Click);
            // 
            // lbExec
            // 
            this.lbExec.AutoSize = true;
            this.lbExec.Location = new System.Drawing.Point(19, 31);
            this.lbExec.Name = "lbExec";
            this.lbExec.Size = new System.Drawing.Size(97, 13);
            this.lbExec.TabIndex = 2;
            this.lbExec.Text = "Executar Programa";
            // 
            // exec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 98);
            this.Controls.Add(this.lbExec);
            this.Controls.Add(this.btExec);
            this.Controls.Add(this.txtExec);
            this.Name = "exec";
            this.Text = "exec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExec;
        private System.Windows.Forms.Button btExec;
        private System.Windows.Forms.Label lbExec;
    }
}