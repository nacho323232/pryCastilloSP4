namespace pryCastilloSP4
{
    partial class frmPrincipal
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
            dgvDatos = new DataGridView();
            colComida = new DataGridViewTextBoxColumn();
            colBebidaNo = new DataGridViewTextBoxColumn();
            colBebida = new DataGridViewTextBoxColumn();
            colPostres = new DataGridViewTextBoxColumn();
            btnValidarDatos = new Button();
            btnMozo = new Button();
            btnTotal = new Button();
            btnCerrar = new Button();
            lblMozo = new Label();
            lblTotal = new Label();
            lstTotales = new ListBox();
            txtNombreMozo = new TextBox();
            txtImporteMozo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colComida, colBebidaNo, colBebida, colPostres });
            dgvDatos.Location = new Point(47, 21);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(721, 203);
            dgvDatos.TabIndex = 0;
            // 
            // colComida
            // 
            colComida.HeaderText = "Comida";
            colComida.Name = "colComida";
            // 
            // colBebidaNo
            // 
            colBebidaNo.HeaderText = "Bebida sin alchol";
            colBebidaNo.Name = "colBebidaNo";
            // 
            // colBebida
            // 
            colBebida.HeaderText = "Bebida Con Alcohol";
            colBebida.Name = "colBebida";
            // 
            // colPostres
            // 
            colPostres.HeaderText = "Postres";
            colPostres.Name = "colPostres";
            // 
            // btnValidarDatos
            // 
            btnValidarDatos.Location = new Point(54, 239);
            btnValidarDatos.Name = "btnValidarDatos";
            btnValidarDatos.Size = new Size(119, 23);
            btnValidarDatos.TabIndex = 1;
            btnValidarDatos.Text = "Validar Datos";
            btnValidarDatos.UseVisualStyleBackColor = true;
            btnValidarDatos.Click += btnValidarDatos_Click;
            // 
            // btnMozo
            // 
            btnMozo.Location = new Point(490, 374);
            btnMozo.Name = "btnMozo";
            btnMozo.Size = new Size(116, 23);
            btnMozo.TabIndex = 2;
            btnMozo.Text = "Mozo del dia";
            btnMozo.UseVisualStyleBackColor = true;
            btnMozo.Click += btnMozo_Click;
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(628, 374);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(116, 23);
            btnTotal.TabIndex = 3;
            btnTotal.Text = "Totales";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(603, 403);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(116, 23);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblMozo
            // 
            lblMozo.AutoSize = true;
            lblMozo.Location = new Point(54, 308);
            lblMozo.Name = "lblMozo";
            lblMozo.Size = new Size(75, 15);
            lblMozo.TabIndex = 5;
            lblMozo.Text = "Mozo del dia";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(47, 374);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(76, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total General";
            // 
            // lstTotales
            // 
            lstTotales.FormattingEnabled = true;
            lstTotales.ItemHeight = 15;
            lstTotales.Location = new Point(148, 374);
            lstTotales.Name = "lstTotales";
            lstTotales.Size = new Size(312, 64);
            lstTotales.TabIndex = 7;
            lstTotales.SelectedIndexChanged += lstTotales_SelectedIndexChanged;
            // 
            // txtNombreMozo
            // 
            txtNombreMozo.Location = new Point(148, 305);
            txtNombreMozo.Name = "txtNombreMozo";
            txtNombreMozo.Size = new Size(213, 23);
            txtNombreMozo.TabIndex = 8;
            // 
            // txtImporteMozo
            // 
            txtImporteMozo.Location = new Point(377, 305);
            txtImporteMozo.Name = "txtImporteMozo";
            txtImporteMozo.Size = new Size(193, 23);
            txtImporteMozo.TabIndex = 9;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtImporteMozo);
            Controls.Add(txtNombreMozo);
            Controls.Add(lstTotales);
            Controls.Add(lblTotal);
            Controls.Add(lblMozo);
            Controls.Add(btnCerrar);
            Controls.Add(btnTotal);
            Controls.Add(btnMozo);
            Controls.Add(btnValidarDatos);
            Controls.Add(dgvDatos);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private Button btnValidarDatos;
        private Button btnMozo;
        private Button btnTotal;
        private Button btnCerrar;
        private Label lblMozo;
        private Label lblTotal;
        private ListBox lstTotales;
        private TextBox txtNombreMozo;
        private TextBox txtImporteMozo;
        private DataGridViewTextBoxColumn colComida;
        private DataGridViewTextBoxColumn colBebidaNo;
        private DataGridViewTextBoxColumn colBebida;
        private DataGridViewTextBoxColumn colPostres;
    }
}