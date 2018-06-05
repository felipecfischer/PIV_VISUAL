namespace PIV
{
    partial class quiz
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
            this.components = new System.ComponentModel.Container();
            this.btSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPergunta = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.RichTextBox();
            this.btConfirma = new System.Windows.Forms.Button();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.btConfig = new System.Windows.Forms.PictureBox();
            this.btfeednews = new System.Windows.Forms.PictureBox();
            this.ttManut = new System.Windows.Forms.ToolTip(this.components);
            this.ttFeed = new System.Windows.Forms.ToolTip(this.components);
            this.btBrasileiro = new System.Windows.Forms.PictureBox();
            this.ttBrasileiro = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btfeednews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btBrasileiro)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(543, 405);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(112, 37);
            this.btSair.TabIndex = 0;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(260, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 69);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quiz";
            // 
            // lbPergunta
            // 
            this.lbPergunta.BackColor = System.Drawing.Color.Transparent;
            this.lbPergunta.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPergunta.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbPergunta.Location = new System.Drawing.Point(37, 122);
            this.lbPergunta.Name = "lbPergunta";
            this.lbPergunta.Size = new System.Drawing.Size(618, 128);
            this.lbPergunta.TabIndex = 9;
            this.lbPergunta.Text = "Quiz";
            this.lbPergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResposta
            // 
            this.txtResposta.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResposta.Location = new System.Drawing.Point(169, 265);
            this.txtResposta.MaxLength = 20;
            this.txtResposta.Multiline = false;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(360, 55);
            this.txtResposta.TabIndex = 10;
            this.txtResposta.Text = "";
            this.txtResposta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResposta_KeyPress);
            // 
            // btConfirma
            // 
            this.btConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btConfirma.FlatAppearance.BorderSize = 2;
            this.btConfirma.Location = new System.Drawing.Point(417, 327);
            this.btConfirma.Name = "btConfirma";
            this.btConfirma.Size = new System.Drawing.Size(112, 37);
            this.btConfirma.TabIndex = 11;
            this.btConfirma.Text = "Confirmar";
            this.btConfirma.UseVisualStyleBackColor = true;
            this.btConfirma.Click += new System.EventHandler(this.btConfirma_Click);
            // 
            // cbTime
            // 
            this.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTime.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(252, 91);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(171, 26);
            this.cbTime.TabIndex = 12;
            // 
            // btConfig
            // 
            this.btConfig.BackColor = System.Drawing.Color.Transparent;
            this.btConfig.BackgroundImage = global::PIV.Properties.Resources.config;
            this.btConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConfig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btConfig.Location = new System.Drawing.Point(12, 405);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(44, 40);
            this.btConfig.TabIndex = 13;
            this.btConfig.TabStop = false;
            this.ttManut.SetToolTip(this.btConfig, "Manutenção base");
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // btfeednews
            // 
            this.btfeednews.BackColor = System.Drawing.Color.Transparent;
            this.btfeednews.BackgroundImage = global::PIV.Properties.Resources.feednews;
            this.btfeednews.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btfeednews.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btfeednews.InitialImage = null;
            this.btfeednews.Location = new System.Drawing.Point(113, 405);
            this.btfeednews.Name = "btfeednews";
            this.btfeednews.Size = new System.Drawing.Size(45, 40);
            this.btfeednews.TabIndex = 14;
            this.btfeednews.TabStop = false;
            this.ttFeed.SetToolTip(this.btfeednews, "Feed News");
            this.btfeednews.Click += new System.EventHandler(this.bt_feednews_Click);
            // 
            // btBrasileiro
            // 
            this.btBrasileiro.BackColor = System.Drawing.Color.Transparent;
            this.btBrasileiro.BackgroundImage = global::PIV.Properties.Resources.brasileirao;
            this.btBrasileiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBrasileiro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btBrasileiro.InitialImage = null;
            this.btBrasileiro.Location = new System.Drawing.Point(62, 405);
            this.btBrasileiro.Name = "btBrasileiro";
            this.btBrasileiro.Size = new System.Drawing.Size(45, 40);
            this.btBrasileiro.TabIndex = 15;
            this.btBrasileiro.TabStop = false;
            this.ttFeed.SetToolTip(this.btBrasileiro, "Tabela Brasileirão 2018");
            this.btBrasileiro.Click += new System.EventHandler(this.btBrasileiro_Click);
            // 
            // quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::PIV.Properties.Resources.quiz;
            this.ClientSize = new System.Drawing.Size(687, 457);
            this.Controls.Add(this.btBrasileiro);
            this.Controls.Add(this.btfeednews);
            this.Controls.Add(this.btConfig);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.btConfirma);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.lbPergunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quiz";
            ((System.ComponentModel.ISupportInitialize)(this.btConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btfeednews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btBrasileiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPergunta;
        private System.Windows.Forms.RichTextBox txtResposta;
        private System.Windows.Forms.Button btConfirma;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.PictureBox btConfig;
        private System.Windows.Forms.PictureBox btfeednews;
        private System.Windows.Forms.ToolTip ttManut;
        private System.Windows.Forms.ToolTip ttFeed;
        private System.Windows.Forms.PictureBox btBrasileiro;
        private System.Windows.Forms.ToolTip ttBrasileiro;
    }
}