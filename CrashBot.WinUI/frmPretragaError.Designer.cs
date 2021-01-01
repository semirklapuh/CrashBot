namespace CrashBot.WinUI
{
    partial class frmPretragaError
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
            this.dgvErrorLista = new System.Windows.Forms.DataGridView();
            this.cmbKorisnik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.ErrorLogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvErrorLista
            // 
            this.dgvErrorLista.AllowUserToAddRows = false;
            this.dgvErrorLista.AllowUserToDeleteRows = false;
            this.dgvErrorLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrorLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ErrorLogId,
            this.KorisnikId});
            this.dgvErrorLista.Location = new System.Drawing.Point(12, 119);
            this.dgvErrorLista.Name = "dgvErrorLista";
            this.dgvErrorLista.ReadOnly = true;
            this.dgvErrorLista.Size = new System.Drawing.Size(776, 319);
            this.dgvErrorLista.TabIndex = 0;
            // 
            // cmbKorisnik
            // 
            this.cmbKorisnik.FormattingEnabled = true;
            this.cmbKorisnik.Location = new System.Drawing.Point(32, 61);
            this.cmbKorisnik.Name = "cmbKorisnik";
            this.cmbKorisnik.Size = new System.Drawing.Size(195, 21);
            this.cmbKorisnik.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izaberite korisnika";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(629, 61);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(91, 23);
            this.btnTrazi.TabIndex = 3;
            this.btnTrazi.Text = "Trazi";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // ErrorLogId
            // 
            this.ErrorLogId.DataPropertyName = "ErrorLogId";
            this.ErrorLogId.HeaderText = "ErrorLogId";
            this.ErrorLogId.Name = "ErrorLogId";
            this.ErrorLogId.ReadOnly = true;
            this.ErrorLogId.Visible = false;
            // 
            // KorisnikId
            // 
            this.KorisnikId.DataPropertyName = "KorisnikId";
            this.KorisnikId.HeaderText = "KorisnikId";
            this.KorisnikId.Name = "KorisnikId";
            this.KorisnikId.ReadOnly = true;
            this.KorisnikId.Visible = false;
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(379, 41);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(200, 20);
            this.dtpOd.TabIndex = 4;
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(379, 83);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Od";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Do";
            // 
            // frmPretragaError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKorisnik);
            this.Controls.Add(this.dgvErrorLista);
            this.Name = "frmPretragaError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPretragaError";
            this.Load += new System.EventHandler(this.frmPretragaError_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvErrorLista;
        private System.Windows.Forms.ComboBox cmbKorisnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorLogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}