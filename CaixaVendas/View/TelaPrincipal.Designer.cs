namespace CaixaVendas.View
{
    partial class TelaPrincipal
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbxTotal = new TextBox();
            tbxPago = new TextBox();
            tbxTroco = new TextBox();
            btnCalcular = new Button();
            btnLimparTudo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 32);
            label1.Name = "label1";
            label1.Size = new Size(269, 40);
            label1.TabIndex = 0;
            label1.Text = "Caixa- Venda Final";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(84, 127);
            label2.Name = "label2";
            label2.Size = new Size(125, 32);
            label2.TabIndex = 1;
            label2.Text = "Valor Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(84, 190);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 2;
            label3.Text = "Valor Pago";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(123, 258);
            label4.Name = "label4";
            label4.Size = new Size(72, 32);
            label4.TabIndex = 3;
            label4.Text = "Troco";
            // 
            // tbxTotal
            // 
            tbxTotal.Location = new Point(231, 136);
            tbxTotal.Name = "tbxTotal";
            tbxTotal.Size = new Size(136, 23);
            tbxTotal.TabIndex = 4;
            // 
            // tbxPago
            // 
            tbxPago.Location = new Point(231, 199);
            tbxPago.Name = "tbxPago";
            tbxPago.Size = new Size(136, 23);
            tbxPago.TabIndex = 5;
            // 
            // tbxTroco
            // 
            tbxTroco.Location = new Point(231, 267);
            tbxTroco.Name = "tbxTroco";
            tbxTroco.ReadOnly = true;
            tbxTroco.Size = new Size(136, 23);
            tbxTroco.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(59, 339);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(187, 60);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimparTudo
            // 
            btnLimparTudo.Location = new Point(269, 339);
            btnLimparTudo.Name = "btnLimparTudo";
            btnLimparTudo.Size = new Size(171, 60);
            btnLimparTudo.TabIndex = 8;
            btnLimparTudo.Text = "Limpar Tudo";
            btnLimparTudo.UseVisualStyleBackColor = true;
            btnLimparTudo.Click += btnLimparTudo_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(516, 463);
            Controls.Add(btnLimparTudo);
            Controls.Add(btnCalcular);
            Controls.Add(tbxTroco);
            Controls.Add(tbxPago);
            Controls.Add(tbxTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaPrincipal";
            ShowIcon = false;
            Text = "Sistema de Venda do Produtos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbxTotal;
        private TextBox tbxPago;
        private TextBox tbxTroco;
        private Button btnCalcular;
        private Button btnLimparTudo;
    }
}