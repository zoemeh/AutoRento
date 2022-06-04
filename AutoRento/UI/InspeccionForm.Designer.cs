namespace AutoRento.UI
{
    partial class InspeccionForm
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
            this.crearBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.otroBtn = new System.Windows.Forms.Button();
            this.borrarBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.vehiculoCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clienteCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.empleadoCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combustibleCombo = new System.Windows.Forms.ComboBox();
            this.ralladurasCheck = new System.Windows.Forms.CheckBox();
            this.repuestaCheck = new System.Windows.Forms.CheckBox();
            this.gatoCheck = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cristalCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.GomaIzqFcheck = new System.Windows.Forms.CheckBox();
            this.GomaDerFCheck = new System.Windows.Forms.CheckBox();
            this.gomaIzqTCheck = new System.Windows.Forms.CheckBox();
            this.GomaDerTCheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fechaCheck = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(243, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(554, 219);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.crearBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.editarBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.otroBtn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.borrarBtn, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 228);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 219);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // crearBtn
            // 
            this.crearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crearBtn.Location = new System.Drawing.Point(3, 3);
            this.crearBtn.Name = "crearBtn";
            this.crearBtn.Size = new System.Drawing.Size(228, 48);
            this.crearBtn.TabIndex = 0;
            this.crearBtn.Text = "Crear";
            this.crearBtn.UseVisualStyleBackColor = true;
            this.crearBtn.Click += new System.EventHandler(this.crearBtn_Click);
            // 
            // editarBtn
            // 
            this.editarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editarBtn.Location = new System.Drawing.Point(3, 57);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(228, 48);
            this.editarBtn.TabIndex = 1;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = true;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // otroBtn
            // 
            this.otroBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otroBtn.Location = new System.Drawing.Point(3, 111);
            this.otroBtn.Name = "otroBtn";
            this.otroBtn.Size = new System.Drawing.Size(228, 48);
            this.otroBtn.TabIndex = 2;
            this.otroBtn.Text = "Otro";
            this.otroBtn.UseVisualStyleBackColor = true;
            // 
            // borrarBtn
            // 
            this.borrarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrarBtn.Location = new System.Drawing.Point(3, 165);
            this.borrarBtn.Name = "borrarBtn";
            this.borrarBtn.Size = new System.Drawing.Size(228, 51);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(243, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(554, 219);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.vehiculoCombo);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.clienteCombo);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.empleadoCombo);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.combustibleCombo);
            this.flowLayoutPanel1.Controls.Add(this.ralladurasCheck);
            this.flowLayoutPanel1.Controls.Add(this.repuestaCheck);
            this.flowLayoutPanel1.Controls.Add(this.gatoCheck);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(271, 213);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehiculo";
            // 
            // vehiculoCombo
            // 
            this.vehiculoCombo.FormattingEnabled = true;
            this.vehiculoCombo.Location = new System.Drawing.Point(3, 18);
            this.vehiculoCombo.Name = "vehiculoCombo";
            this.vehiculoCombo.Size = new System.Drawing.Size(121, 23);
            this.vehiculoCombo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cliente";
            // 
            // clienteCombo
            // 
            this.clienteCombo.FormattingEnabled = true;
            this.clienteCombo.Location = new System.Drawing.Point(3, 62);
            this.clienteCombo.Name = "clienteCombo";
            this.clienteCombo.Size = new System.Drawing.Size(121, 23);
            this.clienteCombo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleado";
            // 
            // empleadoCombo
            // 
            this.empleadoCombo.FormattingEnabled = true;
            this.empleadoCombo.Location = new System.Drawing.Point(3, 106);
            this.empleadoCombo.Name = "empleadoCombo";
            this.empleadoCombo.Size = new System.Drawing.Size(121, 23);
            this.empleadoCombo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Combustible";
            // 
            // combustibleCombo
            // 
            this.combustibleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combustibleCombo.FormattingEnabled = true;
            this.combustibleCombo.Items.AddRange(new object[] {
            "0.25",
            "0.5",
            "0.75",
            "1"});
            this.combustibleCombo.Location = new System.Drawing.Point(3, 150);
            this.combustibleCombo.Name = "combustibleCombo";
            this.combustibleCombo.Size = new System.Drawing.Size(121, 23);
            this.combustibleCombo.TabIndex = 5;
            // 
            // ralladurasCheck
            // 
            this.ralladurasCheck.AutoSize = true;
            this.ralladurasCheck.Location = new System.Drawing.Point(3, 179);
            this.ralladurasCheck.Name = "ralladurasCheck";
            this.ralladurasCheck.Size = new System.Drawing.Size(80, 19);
            this.ralladurasCheck.TabIndex = 6;
            this.ralladurasCheck.Text = "Ralladuras";
            this.ralladurasCheck.UseVisualStyleBackColor = true;
            // 
            // repuestaCheck
            // 
            this.repuestaCheck.AutoSize = true;
            this.repuestaCheck.Location = new System.Drawing.Point(130, 3);
            this.repuestaCheck.Name = "repuestaCheck";
            this.repuestaCheck.Size = new System.Drawing.Size(125, 19);
            this.repuestaCheck.TabIndex = 7;
            this.repuestaCheck.Text = "Goma de Repuesta";
            this.repuestaCheck.UseVisualStyleBackColor = true;
            // 
            // gatoCheck
            // 
            this.gatoCheck.AutoSize = true;
            this.gatoCheck.Location = new System.Drawing.Point(130, 28);
            this.gatoCheck.Name = "gatoCheck";
            this.gatoCheck.Size = new System.Drawing.Size(51, 19);
            this.gatoCheck.TabIndex = 8;
            this.gatoCheck.Text = "Gato";
            this.gatoCheck.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.cristalCheck);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel4);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.fechaCheck);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(280, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(271, 213);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // cristalCheck
            // 
            this.cristalCheck.AutoSize = true;
            this.cristalCheck.Location = new System.Drawing.Point(3, 3);
            this.cristalCheck.Name = "cristalCheck";
            this.cristalCheck.Size = new System.Drawing.Size(84, 19);
            this.cristalCheck.TabIndex = 1;
            this.cristalCheck.Text = "Cristal roto";
            this.cristalCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Estado Gomas";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.GomaIzqFcheck, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.GomaDerFCheck, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.gomaIzqTCheck, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.GomaDerTCheck, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // GomaIzqFcheck
            // 
            this.GomaIzqFcheck.AutoSize = true;
            this.GomaIzqFcheck.Location = new System.Drawing.Point(3, 3);
            this.GomaIzqFcheck.Name = "GomaIzqFcheck";
            this.GomaIzqFcheck.Size = new System.Drawing.Size(84, 19);
            this.GomaIzqFcheck.TabIndex = 0;
            this.GomaIzqFcheck.Text = "Izq. Frontal";
            this.GomaIzqFcheck.UseVisualStyleBackColor = true;
            // 
            // GomaDerFCheck
            // 
            this.GomaDerFCheck.AutoSize = true;
            this.GomaDerFCheck.Location = new System.Drawing.Point(103, 3);
            this.GomaDerFCheck.Name = "GomaDerFCheck";
            this.GomaDerFCheck.Size = new System.Drawing.Size(87, 19);
            this.GomaDerFCheck.TabIndex = 1;
            this.GomaDerFCheck.Text = "Der. Frontal";
            this.GomaDerFCheck.UseVisualStyleBackColor = true;
            // 
            // gomaIzqTCheck
            // 
            this.gomaIzqTCheck.AutoSize = true;
            this.gomaIzqTCheck.Location = new System.Drawing.Point(3, 53);
            this.gomaIzqTCheck.Name = "gomaIzqTCheck";
            this.gomaIzqTCheck.Size = new System.Drawing.Size(83, 19);
            this.gomaIzqTCheck.TabIndex = 2;
            this.gomaIzqTCheck.Text = "Izq. Trasera";
            this.gomaIzqTCheck.UseVisualStyleBackColor = true;
            // 
            // GomaDerTCheck
            // 
            this.GomaDerTCheck.AutoSize = true;
            this.GomaDerTCheck.Location = new System.Drawing.Point(103, 53);
            this.GomaDerTCheck.Name = "GomaDerTCheck";
            this.GomaDerTCheck.Size = new System.Drawing.Size(86, 19);
            this.GomaDerTCheck.TabIndex = 3;
            this.GomaDerTCheck.Text = "Der. Trasera";
            this.GomaDerTCheck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha";
            // 
            // fechaCheck
            // 
            this.fechaCheck.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCheck.Location = new System.Drawing.Point(3, 164);
            this.fechaCheck.Name = "fechaCheck";
            this.fechaCheck.Size = new System.Drawing.Size(200, 23);
            this.fechaCheck.TabIndex = 4;
            // 
            // InspeccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InspeccionForm";
            this.Text = "InspeccionForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button crearBtn;
        private Button editarBtn;
        private Button otroBtn;
        private Button borrarBtn;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private ComboBox vehiculoCombo;
        private Label label2;
        private ComboBox empleadoCombo;
        private Label label3;
        private ComboBox combustibleCombo;
        private CheckBox ralladurasCheck;
        private CheckBox repuestaCheck;
        private CheckBox gatoCheck;
        private FlowLayoutPanel flowLayoutPanel2;
        private CheckBox cristalCheck;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel4;
        private CheckBox GomaIzqFcheck;
        private CheckBox GomaDerFCheck;
        private CheckBox gomaIzqTCheck;
        private CheckBox GomaDerTCheck;
        private Label label5;
        private DateTimePicker fechaCheck;
        private Label label6;
        private ComboBox clienteCombo;
    }
}