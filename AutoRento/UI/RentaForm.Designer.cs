namespace AutoRento.UI
{
    partial class RentaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.otroBtn = new System.Windows.Forms.Button();
            this.borrarBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.empleadoCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clienteCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vehiculoCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rentaDate = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.devolucionDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.montoText = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comentarioText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.montoText)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(940, 546);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(285, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(652, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.guardarBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.editarBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.otroBtn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.borrarBtn, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 276);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(276, 267);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // guardarBtn
            // 
            this.guardarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guardarBtn.Location = new System.Drawing.Point(3, 3);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(270, 60);
            this.guardarBtn.TabIndex = 0;
            this.guardarBtn.Text = "Crear";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // editarBtn
            // 
            this.editarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editarBtn.Enabled = false;
            this.editarBtn.Location = new System.Drawing.Point(3, 69);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(270, 60);
            this.editarBtn.TabIndex = 1;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = true;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // otroBtn
            // 
            this.otroBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otroBtn.Enabled = false;
            this.otroBtn.Location = new System.Drawing.Point(3, 135);
            this.otroBtn.Name = "otroBtn";
            this.otroBtn.Size = new System.Drawing.Size(270, 60);
            this.otroBtn.TabIndex = 2;
            this.otroBtn.Text = "Devolver";
            this.otroBtn.UseVisualStyleBackColor = true;
            this.otroBtn.Click += new System.EventHandler(this.otroBtn_Click);
            // 
            // borrarBtn
            // 
            this.borrarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrarBtn.Location = new System.Drawing.Point(3, 201);
            this.borrarBtn.Name = "borrarBtn";
            this.borrarBtn.Size = new System.Drawing.Size(270, 63);
            this.borrarBtn.TabIndex = 3;
            this.borrarBtn.Text = "Borrar";
            this.borrarBtn.UseVisualStyleBackColor = true;
            this.borrarBtn.Click += new System.EventHandler(this.borrarBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(285, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(652, 267);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.empleadoCombo);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.clienteCombo);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.vehiculoCombo);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.rentaDate);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 261);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            // 
            // empleadoCombo
            // 
            this.empleadoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empleadoCombo.FormattingEnabled = true;
            this.empleadoCombo.Location = new System.Drawing.Point(3, 18);
            this.empleadoCombo.Name = "empleadoCombo";
            this.empleadoCombo.Size = new System.Drawing.Size(265, 23);
            this.empleadoCombo.TabIndex = 6;
            this.empleadoCombo.SelectedIndexChanged += new System.EventHandler(this.empleadoCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // clienteCombo
            // 
            this.clienteCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteCombo.FormattingEnabled = true;
            this.clienteCombo.Location = new System.Drawing.Point(3, 62);
            this.clienteCombo.Name = "clienteCombo";
            this.clienteCombo.Size = new System.Drawing.Size(265, 23);
            this.clienteCombo.TabIndex = 7;
            this.clienteCombo.SelectedIndexChanged += new System.EventHandler(this.clienteCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vehiculo";
            // 
            // vehiculoCombo
            // 
            this.vehiculoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehiculoCombo.FormattingEnabled = true;
            this.vehiculoCombo.Location = new System.Drawing.Point(3, 106);
            this.vehiculoCombo.Name = "vehiculoCombo";
            this.vehiculoCombo.Size = new System.Drawing.Size(265, 23);
            this.vehiculoCombo.TabIndex = 8;
            this.vehiculoCombo.SelectedIndexChanged += new System.EventHandler(this.vehiculoCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha Renta";
            // 
            // rentaDate
            // 
            this.rentaDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rentaDate.Location = new System.Drawing.Point(3, 150);
            this.rentaDate.Name = "rentaDate";
            this.rentaDate.Size = new System.Drawing.Size(265, 23);
            this.rentaDate.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.devolucionDate);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.montoText);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.comentarioText);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(329, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(320, 261);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha Devolucion";
            // 
            // devolucionDate
            // 
            this.devolucionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.devolucionDate.Location = new System.Drawing.Point(3, 18);
            this.devolucionDate.Name = "devolucionDate";
            this.devolucionDate.Size = new System.Drawing.Size(242, 23);
            this.devolucionDate.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Monto por dia";
            // 
            // montoText
            // 
            this.montoText.Location = new System.Drawing.Point(3, 62);
            this.montoText.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.montoText.Name = "montoText";
            this.montoText.Size = new System.Drawing.Size(242, 23);
            this.montoText.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Comentarios";
            // 
            // comentarioText
            // 
            this.comentarioText.Location = new System.Drawing.Point(3, 106);
            this.comentarioText.Name = "comentarioText";
            this.comentarioText.Size = new System.Drawing.Size(242, 23);
            this.comentarioText.TabIndex = 14;
            // 
            // RentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 546);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RentaForm";
            this.Text = "Rentas y Devoluciones";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.montoText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button guardarBtn;
        private Button editarBtn;
        private Button otroBtn;
        private Button borrarBtn;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private ComboBox empleadoCombo;
        private Label label2;
        private ComboBox clienteCombo;
        private Label label3;
        private ComboBox vehiculoCombo;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label4;
        private DateTimePicker rentaDate;
        private Label label5;
        private DateTimePicker devolucionDate;
        private Label label6;
        private NumericUpDown montoText;
        private Label label7;
        private TextBox comentarioText;
    }
}