namespace AutoRento.UI
{
    partial class ReportesForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.clienteCheck = new System.Windows.Forms.CheckBox();
            this.clientesCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoVehiculoCheck = new System.Windows.Forms.CheckBox();
            this.tipoVehiculoCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.marcaCheck = new System.Windows.Forms.CheckBox();
            this.marcaCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.modeloCheck = new System.Windows.Forms.CheckBox();
            this.modeloCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.desdeDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.hastaDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(419, 763);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 767);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.clienteCheck);
            this.flowLayoutPanel1.Controls.Add(this.clientesCombo);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.tipoVehiculoCheck);
            this.flowLayoutPanel1.Controls.Add(this.tipoVehiculoCombo);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.marcaCheck);
            this.flowLayoutPanel1.Controls.Add(this.marcaCombo);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.modeloCheck);
            this.flowLayoutPanel1.Controls.Add(this.modeloCombo);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.desdeDate);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.hastaDate);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(426, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(417, 761);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // clienteCheck
            // 
            this.clienteCheck.AutoSize = true;
            this.clienteCheck.Location = new System.Drawing.Point(3, 18);
            this.clienteCheck.Name = "clienteCheck";
            this.clienteCheck.Size = new System.Drawing.Size(60, 19);
            this.clienteCheck.TabIndex = 7;
            this.clienteCheck.Text = "Activo";
            this.clienteCheck.UseVisualStyleBackColor = true;
            this.clienteCheck.CheckedChanged += new System.EventHandler(this.clienteCheck_CheckedChanged);
            // 
            // clientesCombo
            // 
            this.clientesCombo.FormattingEnabled = true;
            this.clientesCombo.Location = new System.Drawing.Point(3, 43);
            this.clientesCombo.Name = "clientesCombo";
            this.clientesCombo.Size = new System.Drawing.Size(121, 23);
            this.clientesCombo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo Vehiculo";
            // 
            // tipoVehiculoCheck
            // 
            this.tipoVehiculoCheck.AutoSize = true;
            this.tipoVehiculoCheck.Location = new System.Drawing.Point(3, 87);
            this.tipoVehiculoCheck.Name = "tipoVehiculoCheck";
            this.tipoVehiculoCheck.Size = new System.Drawing.Size(60, 19);
            this.tipoVehiculoCheck.TabIndex = 14;
            this.tipoVehiculoCheck.Text = "Activo";
            this.tipoVehiculoCheck.UseVisualStyleBackColor = true;
            this.tipoVehiculoCheck.CheckedChanged += new System.EventHandler(this.tipoVehiculoCheck_CheckedChanged);
            // 
            // tipoVehiculoCombo
            // 
            this.tipoVehiculoCombo.FormattingEnabled = true;
            this.tipoVehiculoCombo.Location = new System.Drawing.Point(3, 112);
            this.tipoVehiculoCombo.Name = "tipoVehiculoCombo";
            this.tipoVehiculoCombo.Size = new System.Drawing.Size(121, 23);
            this.tipoVehiculoCombo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Marca";
            // 
            // marcaCheck
            // 
            this.marcaCheck.AutoSize = true;
            this.marcaCheck.Location = new System.Drawing.Point(3, 156);
            this.marcaCheck.Name = "marcaCheck";
            this.marcaCheck.Size = new System.Drawing.Size(60, 19);
            this.marcaCheck.TabIndex = 15;
            this.marcaCheck.Text = "Activo";
            this.marcaCheck.UseVisualStyleBackColor = true;
            this.marcaCheck.CheckedChanged += new System.EventHandler(this.marcaCheck_CheckedChanged);
            // 
            // marcaCombo
            // 
            this.marcaCombo.FormattingEnabled = true;
            this.marcaCombo.Location = new System.Drawing.Point(3, 181);
            this.marcaCombo.Name = "marcaCombo";
            this.marcaCombo.Size = new System.Drawing.Size(121, 23);
            this.marcaCombo.TabIndex = 12;
            this.marcaCombo.SelectionChangeCommitted += new System.EventHandler(this.marcaCombo_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Modelo";
            // 
            // modeloCheck
            // 
            this.modeloCheck.AutoSize = true;
            this.modeloCheck.Location = new System.Drawing.Point(3, 225);
            this.modeloCheck.Name = "modeloCheck";
            this.modeloCheck.Size = new System.Drawing.Size(60, 19);
            this.modeloCheck.TabIndex = 16;
            this.modeloCheck.Text = "Activo";
            this.modeloCheck.UseVisualStyleBackColor = true;
            this.modeloCheck.CheckedChanged += new System.EventHandler(this.modeloCheck_CheckedChanged);
            // 
            // modeloCombo
            // 
            this.modeloCombo.FormattingEnabled = true;
            this.modeloCombo.Location = new System.Drawing.Point(3, 250);
            this.modeloCombo.Name = "modeloCombo";
            this.modeloCombo.Size = new System.Drawing.Size(121, 23);
            this.modeloCombo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde";
            // 
            // desdeDate
            // 
            this.desdeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desdeDate.Location = new System.Drawing.Point(3, 294);
            this.desdeDate.Name = "desdeDate";
            this.desdeDate.Size = new System.Drawing.Size(200, 23);
            this.desdeDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta";
            // 
            // hastaDate
            // 
            this.hastaDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastaDate.Location = new System.Drawing.Point(3, 338);
            this.hastaDate.Name = "hastaDate";
            this.hastaDate.Size = new System.Drawing.Size(200, 23);
            this.hastaDate.TabIndex = 5;
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 767);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportesForm";
            this.Text = "ReportesForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private ComboBox clientesCombo;
        private Label label2;
        private DateTimePicker desdeDate;
        private Label label3;
        private DateTimePicker hastaDate;
        private CheckBox clienteCheck;
        private Label label4;
        private ComboBox tipoVehiculoCombo;
        private Label label5;
        private ComboBox marcaCombo;
        private Label label6;
        private ComboBox modeloCombo;
        private CheckBox tipoVehiculoCheck;
        private CheckBox marcaCheck;
        private CheckBox modeloCheck;
    }
}