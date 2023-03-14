namespace SubNetMask_calculator
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
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
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.lblIndirizzo = new System.Windows.Forms.Label();
            this.lblMask = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.lblIndBinario = new System.Windows.Forms.Label();
            this.lblSubBinario = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblNetFormato = new System.Windows.Forms.Label();
            this.lblBrDec = new System.Windows.Forms.Label();
            this.lblBrBin = new System.Windows.Forms.Label();
            this.lblNReti = new System.Windows.Forms.Label();
            this.lblNHost = new System.Windows.Forms.Label();
            this.lblWildCardDec = new System.Windows.Forms.Label();
            this.lblWildCardBin = new System.Windows.Forms.Label();
            this.lblReteBin = new System.Windows.Forms.Label();
            this.lblReteDec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Location = new System.Drawing.Point(133, 34);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(150, 26);
            this.txtIndirizzo.TabIndex = 0;
            this.txtIndirizzo.Text = "192.168.5.4";
            // 
            // txtMask
            // 
            this.txtMask.Location = new System.Drawing.Point(133, 66);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(150, 26);
            this.txtMask.TabIndex = 1;
            this.txtMask.Text = "255.255.255.0";
            // 
            // lblIndirizzo
            // 
            this.lblIndirizzo.AutoSize = true;
            this.lblIndirizzo.Location = new System.Drawing.Point(12, 40);
            this.lblIndirizzo.Name = "lblIndirizzo";
            this.lblIndirizzo.Size = new System.Drawing.Size(72, 20);
            this.lblIndirizzo.TabIndex = 3;
            this.lblIndirizzo.Text = "Indirizzo:";
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Location = new System.Drawing.Point(12, 72);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(105, 20);
            this.lblMask.TabIndex = 4;
            this.lblMask.Text = "SubNetMask:";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(17, 120);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(144, 58);
            this.btnCalcola.TabIndex = 5;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // lblIndBinario
            // 
            this.lblIndBinario.AutoSize = true;
            this.lblIndBinario.Location = new System.Drawing.Point(12, 206);
            this.lblIndBinario.Name = "lblIndBinario";
            this.lblIndBinario.Size = new System.Drawing.Size(191, 20);
            this.lblIndBinario.TabIndex = 6;
            this.lblIndBinario.Text = "Indirizzo di rete in binario: ";
            // 
            // lblSubBinario
            // 
            this.lblSubBinario.AutoSize = true;
            this.lblSubBinario.Location = new System.Drawing.Point(12, 236);
            this.lblSubBinario.Name = "lblSubBinario";
            this.lblSubBinario.Size = new System.Drawing.Size(182, 20);
            this.lblSubBinario.TabIndex = 7;
            this.lblSubBinario.Text = "Sub net mask in binario: ";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(12, 335);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(65, 20);
            this.lblClasse.TabIndex = 8;
            this.lblClasse.Text = "Classe: ";
            // 
            // lblNetFormato
            // 
            this.lblNetFormato.AutoSize = true;
            this.lblNetFormato.Location = new System.Drawing.Point(12, 364);
            this.lblNetFormato.Name = "lblNetFormato";
            this.lblNetFormato.Size = new System.Drawing.Size(174, 20);
            this.lblNetFormato.TabIndex = 9;
            this.lblNetFormato.Text = "Net mask in formato /x: ";
            // 
            // lblBrDec
            // 
            this.lblBrDec.AutoSize = true;
            this.lblBrDec.Location = new System.Drawing.Point(12, 394);
            this.lblBrDec.Name = "lblBrDec";
            this.lblBrDec.Size = new System.Drawing.Size(157, 20);
            this.lblBrDec.TabIndex = 10;
            this.lblBrDec.Text = "Broadcast decimale: ";
            // 
            // lblBrBin
            // 
            this.lblBrBin.AutoSize = true;
            this.lblBrBin.Location = new System.Drawing.Point(12, 426);
            this.lblBrBin.Name = "lblBrBin";
            this.lblBrBin.Size = new System.Drawing.Size(141, 20);
            this.lblBrBin.TabIndex = 11;
            this.lblBrBin.Text = "Broadcast binario: ";
            // 
            // lblNReti
            // 
            this.lblNReti.AutoSize = true;
            this.lblNReti.Location = new System.Drawing.Point(13, 556);
            this.lblNReti.Name = "lblNReti";
            this.lblNReti.Size = new System.Drawing.Size(207, 20);
            this.lblNReti.TabIndex = 13;
            this.lblNReti.Text = "Numero reti reppresentabili: ";
            // 
            // lblNHost
            // 
            this.lblNHost.AutoSize = true;
            this.lblNHost.Location = new System.Drawing.Point(13, 527);
            this.lblNHost.Name = "lblNHost";
            this.lblNHost.Size = new System.Drawing.Size(216, 20);
            this.lblNHost.TabIndex = 12;
            this.lblNHost.Text = "Numero host rappresentabili: ";
            // 
            // lblWildCardDec
            // 
            this.lblWildCardDec.AutoSize = true;
            this.lblWildCardDec.Location = new System.Drawing.Point(13, 267);
            this.lblWildCardDec.Name = "lblWildCardDec";
            this.lblWildCardDec.Size = new System.Drawing.Size(190, 20);
            this.lblWildCardDec.TabIndex = 14;
            this.lblWildCardDec.Text = "WildCard mask decimale: ";
            // 
            // lblWildCardBin
            // 
            this.lblWildCardBin.AutoSize = true;
            this.lblWildCardBin.Location = new System.Drawing.Point(13, 303);
            this.lblWildCardBin.Name = "lblWildCardBin";
            this.lblWildCardBin.Size = new System.Drawing.Size(174, 20);
            this.lblWildCardBin.TabIndex = 15;
            this.lblWildCardBin.Text = "WildCard mask binaria: ";
            // 
            // lblReteBin
            // 
            this.lblReteBin.AutoSize = true;
            this.lblReteBin.Location = new System.Drawing.Point(12, 492);
            this.lblReteBin.Name = "lblReteBin";
            this.lblReteBin.Size = new System.Drawing.Size(159, 20);
            this.lblReteBin.TabIndex = 17;
            this.lblReteBin.Text = "Indirizzo rete binario: ";
            // 
            // lblReteDec
            // 
            this.lblReteDec.AutoSize = true;
            this.lblReteDec.Location = new System.Drawing.Point(12, 460);
            this.lblReteDec.Name = "lblReteDec";
            this.lblReteDec.Size = new System.Drawing.Size(175, 20);
            this.lblReteDec.TabIndex = 16;
            this.lblReteDec.Text = "Indirizzo rete decimale: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.lblReteBin);
            this.Controls.Add(this.lblReteDec);
            this.Controls.Add(this.lblWildCardBin);
            this.Controls.Add(this.lblWildCardDec);
            this.Controls.Add(this.lblNReti);
            this.Controls.Add(this.lblNHost);
            this.Controls.Add(this.lblBrBin);
            this.Controls.Add(this.lblBrDec);
            this.Controls.Add(this.lblNetFormato);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.lblSubBinario);
            this.Controls.Add(this.lblIndBinario);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.lblIndirizzo);
            this.Controls.Add(this.txtMask);
            this.Controls.Add(this.txtIndirizzo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.Label lblIndirizzo;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.Label lblIndBinario;
        private System.Windows.Forms.Label lblSubBinario;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblNetFormato;
        private System.Windows.Forms.Label lblBrDec;
        private System.Windows.Forms.Label lblBrBin;
        private System.Windows.Forms.Label lblNReti;
        private System.Windows.Forms.Label lblNHost;
        private System.Windows.Forms.Label lblWildCardDec;
        private System.Windows.Forms.Label lblWildCardBin;
        private System.Windows.Forms.Label lblReteBin;
        private System.Windows.Forms.Label lblReteDec;
    }
}

