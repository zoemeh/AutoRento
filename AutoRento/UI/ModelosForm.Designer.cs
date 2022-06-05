namespace AutoRento.UI
{
    partial class ModelosForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.descripcionText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.marcasCombo = new System.Windows.Forms.ComboBox();
            this.estadoCheck = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.actualizarBtn = new System.Windows.Forms.Button();
            this.otroBtn = new System.Windows.Forms.Button();
            this.borrarBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AutoRento.Properties.Resources._615hURQ4qsL__AC_SX425_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.descripcionText);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.marcasCombo);
            this.flowLayoutPanel1.Controls.Add(this.estadoCheck);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(243, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(554, 219);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion";
            // 
            // descripcionText
            // 
            this.descripcionText.Location = new System.Drawing.Point(3, 18);
            this.descripcionText.Name = "descripcionText";
            this.descripcionText.Size = new System.Drawing.Size(330, 23);
            this.descripcionText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marca";
            // 
            // marcasCombo
            // 
            this.marcasCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marcasCombo.FormattingEnabled = true;
            this.marcasCombo.Location = new System.Drawing.Point(3, 62);
            this.marcasCombo.Name = "marcasCombo";
            this.marcasCombo.Size = new System.Drawing.Size(330, 23);
            this.marcasCombo.TabIndex = 1;
            // 
            // estadoCheck
            // 
            this.estadoCheck.AutoSize = true;
            this.estadoCheck.Location = new System.Drawing.Point(3, 91);
            this.estadoCheck.Name = "estadoCheck";
            this.estadoCheck.Size = new System.Drawing.Size(61, 19);
            this.estadoCheck.TabIndex = 2;
            this.estadoCheck.Text = "Estado";
            this.estadoCheck.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(243, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(554, 219);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.guardarBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.actualizarBtn, 0, 1);
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
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // guardarBtn
            // 
            this.guardarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guardarBtn.Location = new System.Drawing.Point(3, 3);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(228, 48);
            this.guardarBtn.TabIndex = 0;
            this.guardarBtn.Text = "Crear";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // actualizarBtn
            // 
            this.actualizarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actualizarBtn.Location = new System.Drawing.Point(3, 57);
            this.actualizarBtn.Name = "actualizarBtn";
            this.actualizarBtn.Size = new System.Drawing.Size(228, 48);
            this.actualizarBtn.TabIndex = 1;
            this.actualizarBtn.Text = "Editar";
            this.actualizarBtn.UseVisualStyleBackColor = true;
            this.actualizarBtn.Click += new System.EventHandler(this.actualizarBtn_Click);
            // 
            // otroBtn
            // 
            this.otroBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otroBtn.Enabled = false;
            this.otroBtn.Location = new System.Drawing.Point(3, 111);
            this.otroBtn.Name = "otroBtn";
            this.otroBtn.Size = new System.Drawing.Size(228, 48);
            this.otroBtn.TabIndex = 2;
            this.otroBtn.Text = "Otro";
            this.otroBtn.UseVisualStyleBackColor = true;
            this.otroBtn.Click += new System.EventHandler(this.otroBtn_Click);
            // 
            // borrarBtn
            // 
            this.borrarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrarBtn.Enabled = false;
            this.borrarBtn.Location = new System.Drawing.Point(3, 165);
            this.borrarBtn.Name = "borrarBtn";
            this.borrarBtn.Size = new System.Drawing.Size(228, 51);
            this.borrarBtn.TabIndex = 3;
            this.borrarBtn.Text = "Borrar";
            this.borrarBtn.UseVisualStyleBackColor = true;
            this.borrarBtn.Click += new System.EventHandler(this.borrarBtn_Click);
            // 
            // ModelosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ModelosForm";
            this.Text = "ModelosForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox descripcionText;
        private Label label1;
        private ComboBox marcasCombo;
        private CheckBox estadoCheck;
        private DataGridView dataGridView1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button guardarBtn;
        private Button actualizarBtn;
        private Button otroBtn;
        private Button borrarBtn;
    }
}