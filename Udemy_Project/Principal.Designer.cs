namespace Udemy_Project
{
    partial class Principal
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
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemalvarLog = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFerramentas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAbrirPorta = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFecharPorta = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAutoScroll = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAddQuebraDeLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLimparLog = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.itemVelocidade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEnviar
            // 
            this.txtEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnviar.Location = new System.Drawing.Point(12, 49);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(779, 20);
            this.txtEnviar.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Location = new System.Drawing.Point(797, 46);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemArquivo,
            this.itemFerramentas,
            this.itemSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemArquivo
            // 
            this.itemArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemalvarLog,
            this.itemSair});
            this.itemArquivo.Name = "itemArquivo";
            this.itemArquivo.Size = new System.Drawing.Size(61, 20);
            this.itemArquivo.Text = "Arquivo";
            // 
            // itemalvarLog
            // 
            this.itemalvarLog.Name = "itemalvarLog";
            this.itemalvarLog.Size = new System.Drawing.Size(180, 22);
            this.itemalvarLog.Text = "Salvar Log";
            // 
            // itemSair
            // 
            this.itemSair.Name = "itemSair";
            this.itemSair.Size = new System.Drawing.Size(180, 22);
            this.itemSair.Text = "Sair";
            // 
            // itemFerramentas
            // 
            this.itemFerramentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAbrirPorta,
            this.itemFecharPorta,
            this.itemVelocidade,
            this.itemAutoScroll,
            this.itemAddQuebraDeLinha,
            this.itemLimparLog});
            this.itemFerramentas.Name = "itemFerramentas";
            this.itemFerramentas.Size = new System.Drawing.Size(84, 20);
            this.itemFerramentas.Text = "Ferramentas";
            // 
            // itemAbrirPorta
            // 
            this.itemAbrirPorta.Name = "itemAbrirPorta";
            this.itemAbrirPorta.Size = new System.Drawing.Size(186, 22);
            this.itemAbrirPorta.Text = "Abrir Porta";
            // 
            // itemFecharPorta
            // 
            this.itemFecharPorta.Name = "itemFecharPorta";
            this.itemFecharPorta.Size = new System.Drawing.Size(186, 22);
            this.itemFecharPorta.Text = "Fechar Porta";
            this.itemFecharPorta.Click += new System.EventHandler(this.itemFecharPorta_Click);
            // 
            // itemAutoScroll
            // 
            this.itemAutoScroll.Name = "itemAutoScroll";
            this.itemAutoScroll.Size = new System.Drawing.Size(186, 22);
            this.itemAutoScroll.Text = "Auto Scroll";
            // 
            // itemAddQuebraDeLinha
            // 
            this.itemAddQuebraDeLinha.Name = "itemAddQuebraDeLinha";
            this.itemAddQuebraDeLinha.Size = new System.Drawing.Size(186, 22);
            this.itemAddQuebraDeLinha.Text = "Add Quebra de Linha";
            // 
            // itemLimparLog
            // 
            this.itemLimparLog.Name = "itemLimparLog";
            this.itemLimparLog.Size = new System.Drawing.Size(186, 22);
            this.itemLimparLog.Text = "Limpar Log";
            // 
            // itemSobre
            // 
            this.itemSobre.Name = "itemSobre";
            this.itemSobre.Size = new System.Drawing.Size(49, 20);
            this.itemSobre.Text = "Sobre";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(12, 75);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(860, 470);
            this.txtLog.TabIndex = 4;
            this.txtLog.Text = "";
            // 
            // itemVelocidade
            // 
            this.itemVelocidade.Name = "itemVelocidade";
            this.itemVelocidade.Size = new System.Drawing.Size(186, 22);
            this.itemVelocidade.Text = "Velocidade ";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 557);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Monito Serial_Udemy";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemArquivo;
        private System.Windows.Forms.ToolStripMenuItem itemalvarLog;
        private System.Windows.Forms.ToolStripMenuItem itemSair;
        private System.Windows.Forms.ToolStripMenuItem itemFerramentas;
        private System.Windows.Forms.ToolStripMenuItem itemAbrirPorta;
        private System.Windows.Forms.ToolStripMenuItem itemFecharPorta;
        private System.Windows.Forms.ToolStripMenuItem itemAutoScroll;
        private System.Windows.Forms.ToolStripMenuItem itemAddQuebraDeLinha;
        private System.Windows.Forms.ToolStripMenuItem itemLimparLog;
        private System.Windows.Forms.ToolStripMenuItem itemSobre;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.ToolStripMenuItem itemVelocidade;
    }
}

