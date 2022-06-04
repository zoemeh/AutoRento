namespace AutoRento.UI
{
    partial class VehiculosDetailForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.descripcionText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chasisText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.motorText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.placaText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoVehiculoCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.marcaCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.modeloCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tipoConbustibleCombo = new System.Windows.Forms.ComboBox();
            this.estadoCheck = new System.Windows.Forms.CheckBox();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.descripcionText);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.chasisText);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.motorText);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.placaText);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(394, 219);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descripcionText
            // 
            this.descripcionText.Location = new System.Drawing.Point(3, 18);
            this.descripcionText.Name = "descripcionText";
            this.descripcionText.Size = new System.Drawing.Size(371, 23);
            this.descripcionText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. Chasis";
            // 
            // chasisText
            // 
            this.chasisText.Location = new System.Drawing.Point(3, 62);
            this.chasisText.Name = "chasisText";
            this.chasisText.Size = new System.Drawing.Size(371, 23);
            this.chasisText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "No. Motor";
            // 
            // motorText
            // 
            this.motorText.Location = new System.Drawing.Point(3, 106);
            this.motorText.Name = "motorText";
            this.motorText.Size = new System.Drawing.Size(371, 23);
            this.motorText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "No. Placa";
            // 
            // placaText
            // 
            this.placaText.Location = new System.Drawing.Point(3, 150);
            this.placaText.Name = "placaText";
            this.placaText.Size = new System.Drawing.Size(371, 23);
            this.placaText.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.guardarBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cancelarBtn, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.tipoVehiculoCombo);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.marcaCombo);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.modeloCombo);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.tipoConbustibleCombo);
            this.flowLayoutPanel2.Controls.Add(this.estadoCheck);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(403, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(394, 219);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo Vehiculo";
            // 
            // tipoVehiculoCombo
            // 
            this.tipoVehiculoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoVehiculoCombo.FormattingEnabled = true;
            this.tipoVehiculoCombo.Location = new System.Drawing.Point(3, 18);
            this.tipoVehiculoCombo.Name = "tipoVehiculoCombo";
            this.tipoVehiculoCombo.Size = new System.Drawing.Size(299, 23);
            this.tipoVehiculoCombo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Marca";
            // 
            // marcaCombo
            // 
            this.marcaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marcaCombo.FormattingEnabled = true;
            this.marcaCombo.Location = new System.Drawing.Point(3, 62);
            this.marcaCombo.Name = "marcaCombo";
            this.marcaCombo.Size = new System.Drawing.Size(299, 23);
            this.marcaCombo.TabIndex = 11;
            this.marcaCombo.SelectionChangeCommitted += new System.EventHandler(this.marcaCombo_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Modelo";
            // 
            // modeloCombo
            // 
            this.modeloCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeloCombo.FormattingEnabled = true;
            this.modeloCombo.Location = new System.Drawing.Point(3, 106);
            this.modeloCombo.Name = "modeloCombo";
            this.modeloCombo.Size = new System.Drawing.Size(299, 23);
            this.modeloCombo.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tipo Combustible";
            // 
            // tipoConbustibleCombo
            // 
            this.tipoConbustibleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoConbustibleCombo.FormattingEnabled = true;
            this.tipoConbustibleCombo.Location = new System.Drawing.Point(3, 150);
            this.tipoConbustibleCombo.Name = "tipoConbustibleCombo";
            this.tipoConbustibleCombo.Size = new System.Drawing.Size(299, 23);
            this.tipoConbustibleCombo.TabIndex = 17;
            // 
            // estadoCheck
            // 
            this.estadoCheck.AutoSize = true;
            this.estadoCheck.Location = new System.Drawing.Point(3, 179);
            this.estadoCheck.Name = "estadoCheck";
            this.estadoCheck.Size = new System.Drawing.Size(61, 19);
            this.estadoCheck.TabIndex = 16;
            this.estadoCheck.Text = "Estado";
            this.estadoCheck.UseVisualStyleBackColor = true;
            // 
            // guardarBtn
            // 
            this.guardarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guardarBtn.Location = new System.Drawing.Point(3, 228);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(394, 219);
            this.guardarBtn.TabIndex = 2;
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
            this.cancelarBtn.TabIndex = 3;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // VehiculosDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VehiculosDetailForm";
            this.Text = "VehiculosDetailForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox descripcionText;
        private Label label2;
        private TextBox chasisText;
        private Label label3;
        private TextBox motorText;
        private Label label4;
        private TextBox placaText;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label5;
        private ComboBox tipoVehiculoCombo;
        private Label label6;
        private ComboBox marcaCombo;
        private Label label7;
        private ComboBox modeloCombo;
        private Label label8;
        private CheckBox estadoCheck;
        private Button guardarBtn;
        private Button cancelarBtn;
        private ComboBox tipoConbustibleCombo;
    }
}