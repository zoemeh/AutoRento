namespace AutoRento.UI
{
    partial class ClientesDetailForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cedulaText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tarjetaText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.limiteCreditoText = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoPersonaCombo = new System.Windows.Forms.ComboBox();
            this.estadoCheck = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limiteCreditoText)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.guardarBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cancelarBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // guardarBtn
            // 
            this.guardarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guardarBtn.Location = new System.Drawing.Point(3, 228);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(394, 219);
            this.guardarBtn.TabIndex = 0;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelarBtn.Location = new System.Drawing.Point(403, 228);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(394, 219);
            this.cancelarBtn.TabIndex = 1;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.nombreText);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.cedulaText);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.tarjetaText);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.limiteCreditoText);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(394, 219);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(3, 18);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(371, 23);
            this.nombreText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cedula";
            // 
            // cedulaText
            // 
            this.cedulaText.Location = new System.Drawing.Point(3, 62);
            this.cedulaText.Name = "cedulaText";
            this.cedulaText.Size = new System.Drawing.Size(371, 23);
            this.cedulaText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tarjeta de Credito";
            // 
            // tarjetaText
            // 
            this.tarjetaText.Location = new System.Drawing.Point(3, 106);
            this.tarjetaText.Name = "tarjetaText";
            this.tarjetaText.Size = new System.Drawing.Size(371, 23);
            this.tarjetaText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Limite de Credito";
            // 
            // limiteCreditoText
            // 
            this.limiteCreditoText.Location = new System.Drawing.Point(3, 150);
            this.limiteCreditoText.Name = "limiteCreditoText";
            this.limiteCreditoText.Size = new System.Drawing.Size(371, 23);
            this.limiteCreditoText.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.tipoPersonaCombo);
            this.flowLayoutPanel2.Controls.Add(this.estadoCheck);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(403, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(394, 219);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo de Persona";
            // 
            // tipoPersonaCombo
            // 
            this.tipoPersonaCombo.FormattingEnabled = true;
            this.tipoPersonaCombo.Items.AddRange(new object[] {
            "Fisica",
            "Juridica"});
            this.tipoPersonaCombo.Location = new System.Drawing.Point(3, 18);
            this.tipoPersonaCombo.Name = "tipoPersonaCombo";
            this.tipoPersonaCombo.Size = new System.Drawing.Size(314, 23);
            this.tipoPersonaCombo.TabIndex = 10;
            // 
            // estadoCheck
            // 
            this.estadoCheck.AutoSize = true;
            this.estadoCheck.Location = new System.Drawing.Point(3, 47);
            this.estadoCheck.Name = "estadoCheck";
            this.estadoCheck.Size = new System.Drawing.Size(61, 19);
            this.estadoCheck.TabIndex = 6;
            this.estadoCheck.Text = "Estado";
            this.estadoCheck.UseVisualStyleBackColor = true;
            // 
            // ClientesDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClientesDetailForm";
            this.Text = "ClientesDetailForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limiteCreditoText)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button guardarBtn;
        private Button cancelarBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox nombreText;
        private Label label2;
        private TextBox cedulaText;
        private Label label3;
        private TextBox tarjetaText;
        private Label label4;
        private NumericUpDown limiteCreditoText;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label5;
        private ComboBox tipoPersonaCombo;
        private CheckBox estadoCheck;
    }
}