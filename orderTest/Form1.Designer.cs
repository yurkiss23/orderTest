namespace orderTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.orderLabel = new System.Windows.Forms.Label();
            this.dataSelectionBox = new System.Windows.Forms.GroupBox();
            this.downToFile = new System.Windows.Forms.Button();
            this.radioTable = new System.Windows.Forms.TableLayoutPanel();
            this.radioHead = new System.Windows.Forms.RadioButton();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.radioEPS = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.addPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.nameADD = new System.Windows.Forms.ComboBox();
            this.meterADD = new System.Windows.Forms.ComboBox();
            this.amountADD = new System.Windows.Forms.TextBox();
            this.addAddToOrderButton = new System.Windows.Forms.Button();
            this.addData = new System.Windows.Forms.DataGridView();
            this.nmADD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtrADD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amADD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epsPanel = new System.Windows.Forms.Panel();
            this.selectEpsTable = new System.Windows.Forms.TableLayoutPanel();
            this.markEPS = new System.Windows.Forms.ComboBox();
            this.thikEPS = new System.Windows.Forms.ComboBox();
            this.amountEPSlabel = new System.Windows.Forms.Label();
            this.amountEPS = new System.Windows.Forms.TextBox();
            this.packEPSlabel = new System.Windows.Forms.Label();
            this.packEPS = new System.Windows.Forms.TextBox();
            this.addEpsToOrderButton = new System.Windows.Forms.Button();
            this.epsData = new System.Windows.Forms.DataGridView();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thikness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.headDate = new System.Windows.Forms.DateTimePicker();
            this.clientData = new System.Windows.Forms.TextBox();
            this.markData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addHeadData = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vehicleData = new System.Windows.Forms.TextBox();
            this.adressData = new System.Windows.Forms.TextBox();
            this.driverData = new System.Windows.Forms.TextBox();
            this.dataSelectionBox.SuspendLayout();
            this.radioTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addData)).BeginInit();
            this.epsPanel.SuspendLayout();
            this.selectEpsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epsData)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderLabel
            // 
            this.orderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderLabel.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderLabel.Location = new System.Drawing.Point(0, 0);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.orderLabel.Size = new System.Drawing.Size(760, 55);
            this.orderLabel.TabIndex = 1;
            this.orderLabel.Text = "замовлення";
            this.orderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataSelectionBox
            // 
            this.dataSelectionBox.Controls.Add(this.downToFile);
            this.dataSelectionBox.Controls.Add(this.radioTable);
            this.dataSelectionBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataSelectionBox.Location = new System.Drawing.Point(0, 0);
            this.dataSelectionBox.Name = "dataSelectionBox";
            this.dataSelectionBox.Size = new System.Drawing.Size(751, 90);
            this.dataSelectionBox.TabIndex = 2;
            this.dataSelectionBox.TabStop = false;
            this.dataSelectionBox.Text = "заповнення";
            // 
            // downToFile
            // 
            this.downToFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.downToFile.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downToFile.Location = new System.Drawing.Point(526, 5);
            this.downToFile.Name = "downToFile";
            this.downToFile.Size = new System.Drawing.Size(150, 80);
            this.downToFile.TabIndex = 4;
            this.downToFile.Text = "вивантажити";
            this.downToFile.UseVisualStyleBackColor = true;
            this.downToFile.Click += new System.EventHandler(this.downToFile_Click);
            // 
            // radioTable
            // 
            this.radioTable.ColumnCount = 3;
            this.radioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.radioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.radioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.radioTable.Controls.Add(this.radioHead, 0, 0);
            this.radioTable.Controls.Add(this.radioAdd, 2, 0);
            this.radioTable.Controls.Add(this.radioEPS, 1, 0);
            this.radioTable.Location = new System.Drawing.Point(6, 25);
            this.radioTable.Name = "radioTable";
            this.radioTable.RowCount = 1;
            this.radioTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.radioTable.Size = new System.Drawing.Size(469, 63);
            this.radioTable.TabIndex = 3;
            // 
            // radioHead
            // 
            this.radioHead.AutoSize = true;
            this.radioHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioHead.Location = new System.Drawing.Point(3, 3);
            this.radioHead.Name = "radioHead";
            this.radioHead.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.radioHead.Size = new System.Drawing.Size(150, 57);
            this.radioHead.TabIndex = 0;
            this.radioHead.Text = "реквізити";
            this.radioHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioHead.UseVisualStyleBackColor = true;
            this.radioHead.Enter += new System.EventHandler(this.radioButton1_Enter);
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioAdd.Location = new System.Drawing.Point(315, 3);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.radioAdd.Size = new System.Drawing.Size(151, 57);
            this.radioAdd.TabIndex = 2;
            this.radioAdd.Text = "додаткові";
            this.radioAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioAdd.UseVisualStyleBackColor = true;
            this.radioAdd.Enter += new System.EventHandler(this.radioButton3_Enter);
            // 
            // radioEPS
            // 
            this.radioEPS.AutoSize = true;
            this.radioEPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioEPS.Location = new System.Drawing.Point(159, 3);
            this.radioEPS.Name = "radioEPS";
            this.radioEPS.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.radioEPS.Size = new System.Drawing.Size(150, 57);
            this.radioEPS.TabIndex = 1;
            this.radioEPS.Text = "пінопласт";
            this.radioEPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioEPS.UseVisualStyleBackColor = true;
            this.radioEPS.Enter += new System.EventHandler(this.radioButton2_Enter);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.orderLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(760, 620);
            this.splitContainer1.SplitterDistance = 55;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataSelectionBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.addPanel);
            this.splitContainer2.Panel2.Controls.Add(this.epsPanel);
            this.splitContainer2.Panel2.Controls.Add(this.headerPanel);
            this.splitContainer2.Size = new System.Drawing.Size(754, 553);
            this.splitContainer2.SplitterDistance = 100;
            this.splitContainer2.TabIndex = 3;
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.tableLayoutPanel3);
            this.addPanel.Controls.Add(this.addAddToOrderButton);
            this.addPanel.Controls.Add(this.addData);
            this.addPanel.Enabled = false;
            this.addPanel.Location = new System.Drawing.Point(0, 320);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(753, 374);
            this.addPanel.TabIndex = 6;
            this.addPanel.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.nameADD, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.meterADD, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.amountADD, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(750, 50);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // nameADD
            // 
            this.nameADD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameADD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameADD.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameADD.FormattingEnabled = true;
            this.nameADD.Items.AddRange(new object[] {
            "---назва---",
            "клей Століт М",
            "склосітка Століт 90 зелена",
            "грунт  маскувальний  Століт 15кг",
            "грунт глибокопроникний 10 л",
            "кутник з сіткою пластиковий 3м"});
            this.nameADD.Location = new System.Drawing.Point(3, 3);
            this.nameADD.Name = "nameADD";
            this.nameADD.Size = new System.Drawing.Size(444, 31);
            this.nameADD.TabIndex = 0;
            this.nameADD.Tag = "";
            this.nameADD.SelectedIndexChanged += new System.EventHandler(this.nameADD_SelectedIndexChanged);
            // 
            // meterADD
            // 
            this.meterADD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meterADD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.meterADD.Enabled = false;
            this.meterADD.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.meterADD.FormattingEnabled = true;
            this.meterADD.Items.AddRange(new object[] {
            "---од.вим.---",
            "шт",
            "мішок",
            "відро",
            "каністра",
            "рулон",
            "м2"});
            this.meterADD.Location = new System.Drawing.Point(453, 3);
            this.meterADD.Name = "meterADD";
            this.meterADD.Size = new System.Drawing.Size(144, 31);
            this.meterADD.TabIndex = 1;
            this.meterADD.SelectedIndexChanged += new System.EventHandler(this.meterADD_SelectedIndexChanged);
            // 
            // amountADD
            // 
            this.amountADD.BackColor = System.Drawing.SystemColors.Window;
            this.amountADD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountADD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountADD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amountADD.Enabled = false;
            this.amountADD.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountADD.Location = new System.Drawing.Point(603, 3);
            this.amountADD.Name = "amountADD";
            this.amountADD.Size = new System.Drawing.Size(144, 31);
            this.amountADD.TabIndex = 2;
            this.amountADD.Leave += new System.EventHandler(this.amountADD_Leave);
            // 
            // addAddToOrderButton
            // 
            this.addAddToOrderButton.Enabled = false;
            this.addAddToOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addAddToOrderButton.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAddToOrderButton.Location = new System.Drawing.Point(40, 65);
            this.addAddToOrderButton.Name = "addAddToOrderButton";
            this.addAddToOrderButton.Size = new System.Drawing.Size(406, 70);
            this.addAddToOrderButton.TabIndex = 2;
            this.addAddToOrderButton.Text = "додати в замовлення";
            this.addAddToOrderButton.UseVisualStyleBackColor = true;
            this.addAddToOrderButton.Click += new System.EventHandler(this.addAddToOrderButton_Click);
            // 
            // addData
            // 
            this.addData.AllowUserToAddRows = false;
            this.addData.AllowUserToDeleteRows = false;
            this.addData.AllowUserToResizeColumns = false;
            this.addData.AllowUserToResizeRows = false;
            this.addData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.addData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.addData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.addData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nmADD,
            this.mtrADD,
            this.amADD});
            this.addData.Location = new System.Drawing.Point(510, 65);
            this.addData.MultiSelect = false;
            this.addData.Name = "addData";
            this.addData.ReadOnly = true;
            this.addData.RowHeadersVisible = false;
            this.addData.RowHeadersWidth = 60;
            this.addData.RowTemplate.ReadOnly = true;
            this.addData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.addData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.addData.Size = new System.Drawing.Size(242, 320);
            this.addData.TabIndex = 4;
            this.addData.Visible = false;
            // 
            // nmADD
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.nmADD.DefaultCellStyle = dataGridViewCellStyle11;
            this.nmADD.DividerWidth = 1;
            this.nmADD.FillWeight = 130F;
            this.nmADD.HeaderText = "назва";
            this.nmADD.MinimumWidth = 130;
            this.nmADD.Name = "nmADD";
            this.nmADD.ReadOnly = true;
            this.nmADD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nmADD.Width = 140;
            // 
            // mtrADD
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mtrADD.DefaultCellStyle = dataGridViewCellStyle12;
            this.mtrADD.DividerWidth = 1;
            this.mtrADD.FillWeight = 40F;
            this.mtrADD.HeaderText = "од.вим.";
            this.mtrADD.MinimumWidth = 40;
            this.mtrADD.Name = "mtrADD";
            this.mtrADD.ReadOnly = true;
            this.mtrADD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mtrADD.Width = 50;
            // 
            // amADD
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.amADD.DefaultCellStyle = dataGridViewCellStyle13;
            this.amADD.DividerWidth = 1;
            this.amADD.FillWeight = 40F;
            this.amADD.HeaderText = "кіл-ть";
            this.amADD.MinimumWidth = 40;
            this.amADD.Name = "amADD";
            this.amADD.ReadOnly = true;
            this.amADD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.amADD.Width = 50;
            // 
            // epsPanel
            // 
            this.epsPanel.Controls.Add(this.selectEpsTable);
            this.epsPanel.Controls.Add(this.addEpsToOrderButton);
            this.epsPanel.Controls.Add(this.epsData);
            this.epsPanel.Enabled = false;
            this.epsPanel.Location = new System.Drawing.Point(0, 160);
            this.epsPanel.Name = "epsPanel";
            this.epsPanel.Size = new System.Drawing.Size(753, 150);
            this.epsPanel.TabIndex = 5;
            this.epsPanel.Visible = false;
            // 
            // selectEpsTable
            // 
            this.selectEpsTable.ColumnCount = 2;
            this.selectEpsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectEpsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectEpsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.selectEpsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.selectEpsTable.Controls.Add(this.markEPS, 0, 0);
            this.selectEpsTable.Controls.Add(this.thikEPS, 1, 0);
            this.selectEpsTable.Controls.Add(this.amountEPSlabel, 0, 1);
            this.selectEpsTable.Controls.Add(this.amountEPS, 0, 2);
            this.selectEpsTable.Controls.Add(this.packEPSlabel, 1, 1);
            this.selectEpsTable.Controls.Add(this.packEPS, 1, 2);
            this.selectEpsTable.Location = new System.Drawing.Point(0, 0);
            this.selectEpsTable.Name = "selectEpsTable";
            this.selectEpsTable.RowCount = 3;
            this.selectEpsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.selectEpsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.selectEpsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.selectEpsTable.Size = new System.Drawing.Size(480, 100);
            this.selectEpsTable.TabIndex = 1;
            // 
            // markEPS
            // 
            this.markEPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markEPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.markEPS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markEPS.FormattingEnabled = true;
            this.markEPS.Items.AddRange(new object[] {
            "---марка---",
            "eps s",
            "eps 30",
            "eps 50",
            "eps 60"});
            this.markEPS.Location = new System.Drawing.Point(3, 3);
            this.markEPS.Name = "markEPS";
            this.markEPS.Size = new System.Drawing.Size(234, 31);
            this.markEPS.TabIndex = 0;
            this.markEPS.Tag = "";
            this.markEPS.SelectedIndexChanged += new System.EventHandler(this.markEPS_SelectedIndexChanged);
            // 
            // thikEPS
            // 
            this.thikEPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thikEPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.thikEPS.Enabled = false;
            this.thikEPS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thikEPS.FormattingEnabled = true;
            this.thikEPS.Items.AddRange(new object[] {
            "---товщина---",
            "1",
            "2",
            "3",
            "4",
            "5",
            "8",
            "10",
            "12"});
            this.thikEPS.Location = new System.Drawing.Point(243, 3);
            this.thikEPS.Name = "thikEPS";
            this.thikEPS.Size = new System.Drawing.Size(234, 31);
            this.thikEPS.TabIndex = 1;
            this.thikEPS.SelectedIndexChanged += new System.EventHandler(this.thikEPS_SelectedIndexChanged);
            // 
            // amountEPSlabel
            // 
            this.amountEPSlabel.AutoSize = true;
            this.amountEPSlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amountEPSlabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountEPSlabel.Location = new System.Drawing.Point(3, 37);
            this.amountEPSlabel.Name = "amountEPSlabel";
            this.amountEPSlabel.Size = new System.Drawing.Size(234, 25);
            this.amountEPSlabel.TabIndex = 6;
            this.amountEPSlabel.Text = "кількість";
            this.amountEPSlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amountEPS
            // 
            this.amountEPS.BackColor = System.Drawing.SystemColors.Window;
            this.amountEPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountEPS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountEPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amountEPS.Enabled = false;
            this.amountEPS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountEPS.Location = new System.Drawing.Point(3, 65);
            this.amountEPS.Name = "amountEPS";
            this.amountEPS.Size = new System.Drawing.Size(234, 31);
            this.amountEPS.TabIndex = 2;
            this.amountEPS.Leave += new System.EventHandler(this.amountEPS_Leave);
            // 
            // packEPSlabel
            // 
            this.packEPSlabel.AutoSize = true;
            this.packEPSlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packEPSlabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.packEPSlabel.Location = new System.Drawing.Point(243, 37);
            this.packEPSlabel.Name = "packEPSlabel";
            this.packEPSlabel.Size = new System.Drawing.Size(234, 25);
            this.packEPSlabel.TabIndex = 7;
            this.packEPSlabel.Text = "упаковок";
            this.packEPSlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // packEPS
            // 
            this.packEPS.BackColor = System.Drawing.SystemColors.ControlLight;
            this.packEPS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.packEPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packEPS.Enabled = false;
            this.packEPS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.packEPS.HideSelection = false;
            this.packEPS.Location = new System.Drawing.Point(243, 65);
            this.packEPS.Name = "packEPS";
            this.packEPS.Size = new System.Drawing.Size(234, 31);
            this.packEPS.TabIndex = 3;
            this.packEPS.TabStop = false;
            // 
            // addEpsToOrderButton
            // 
            this.addEpsToOrderButton.Enabled = false;
            this.addEpsToOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addEpsToOrderButton.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEpsToOrderButton.Location = new System.Drawing.Point(40, 110);
            this.addEpsToOrderButton.Name = "addEpsToOrderButton";
            this.addEpsToOrderButton.Size = new System.Drawing.Size(406, 70);
            this.addEpsToOrderButton.TabIndex = 2;
            this.addEpsToOrderButton.Text = "додати в замовлення";
            this.addEpsToOrderButton.UseVisualStyleBackColor = true;
            this.addEpsToOrderButton.Click += new System.EventHandler(this.addEpsToOrderButton_Click);
            // 
            // epsData
            // 
            this.epsData.AllowUserToAddRows = false;
            this.epsData.AllowUserToDeleteRows = false;
            this.epsData.AllowUserToResizeColumns = false;
            this.epsData.AllowUserToResizeRows = false;
            this.epsData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.epsData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.epsData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.epsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.epsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.epsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mark,
            this.thikness,
            this.amount,
            this.pack});
            this.epsData.Location = new System.Drawing.Point(510, 0);
            this.epsData.MultiSelect = false;
            this.epsData.Name = "epsData";
            this.epsData.ReadOnly = true;
            this.epsData.RowHeadersVisible = false;
            this.epsData.RowHeadersWidth = 60;
            this.epsData.RowTemplate.ReadOnly = true;
            this.epsData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.epsData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.epsData.Size = new System.Drawing.Size(242, 300);
            this.epsData.TabIndex = 4;
            this.epsData.Visible = false;
            // 
            // mark
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.mark.DefaultCellStyle = dataGridViewCellStyle15;
            this.mark.DividerWidth = 1;
            this.mark.FillWeight = 50F;
            this.mark.HeaderText = "марка";
            this.mark.MinimumWidth = 50;
            this.mark.Name = "mark";
            this.mark.ReadOnly = true;
            this.mark.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mark.Width = 60;
            // 
            // thikness
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.thikness.DefaultCellStyle = dataGridViewCellStyle16;
            this.thikness.DividerWidth = 1;
            this.thikness.FillWeight = 50F;
            this.thikness.HeaderText = "товщина";
            this.thikness.MinimumWidth = 50;
            this.thikness.Name = "thikness";
            this.thikness.ReadOnly = true;
            this.thikness.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.thikness.Width = 60;
            // 
            // amount
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.amount.DefaultCellStyle = dataGridViewCellStyle17;
            this.amount.DividerWidth = 1;
            this.amount.FillWeight = 50F;
            this.amount.HeaderText = "кількість";
            this.amount.MinimumWidth = 50;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.amount.Width = 60;
            // 
            // pack
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pack.DefaultCellStyle = dataGridViewCellStyle18;
            this.pack.DividerWidth = 1;
            this.pack.FillWeight = 50F;
            this.pack.HeaderText = "упаковок";
            this.pack.MinimumWidth = 50;
            this.pack.Name = "pack";
            this.pack.ReadOnly = true;
            this.pack.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pack.Width = 60;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.tableLayoutPanel2);
            this.headerPanel.Controls.Add(this.addHeadData);
            this.headerPanel.Controls.Add(this.comboBox2);
            this.headerPanel.Controls.Add(this.textBox2);
            this.headerPanel.Controls.Add(this.comboBox1);
            this.headerPanel.Enabled = false;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(753, 150);
            this.headerPanel.TabIndex = 6;
            this.headerPanel.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.headDate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.clientData, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.markData, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.vehicleData, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.adressData, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.driverData, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(748, 76);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // headDate
            // 
            this.headDate.Enabled = false;
            this.headDate.Location = new System.Drawing.Point(3, 3);
            this.headDate.Name = "headDate";
            this.headDate.Size = new System.Drawing.Size(143, 20);
            this.headDate.TabIndex = 8;
            this.headDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // clientData
            // 
            this.clientData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientData.Enabled = false;
            this.clientData.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientData.Location = new System.Drawing.Point(152, 3);
            this.clientData.Name = "clientData";
            this.clientData.Size = new System.Drawing.Size(143, 31);
            this.clientData.TabIndex = 2;
            this.clientData.Text = "---замовник---";
            this.clientData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clientData.Enter += new System.EventHandler(this.clientData_Enter);
            // 
            // markData
            // 
            this.markData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.markData.Enabled = false;
            this.markData.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markData.Location = new System.Drawing.Point(301, 3);
            this.markData.Name = "markData";
            this.markData.Size = new System.Drawing.Size(107, 31);
            this.markData.TabIndex = 9;
            this.markData.Text = "---марка---";
            this.markData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(599, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "кількість";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addHeadData
            // 
            this.addHeadData.Enabled = false;
            this.addHeadData.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addHeadData.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addHeadData.Location = new System.Drawing.Point(46, 85);
            this.addHeadData.Name = "addHeadData";
            this.addHeadData.Size = new System.Drawing.Size(406, 70);
            this.addHeadData.TabIndex = 2;
            this.addHeadData.Text = "зберегти реквізити";
            this.addHeadData.UseVisualStyleBackColor = true;
            this.addHeadData.Click += new System.EventHandler(this.addHeadData_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "---марка---",
            "eps s",
            "eps 30",
            "eps 50",
            "eps 60"});
            this.comboBox2.Location = new System.Drawing.Point(479, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(143, 31);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Tag = "";
            this.comboBox2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(620, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 31);
            this.textBox2.TabIndex = 3;
            this.textBox2.TabStop = false;
            this.textBox2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "---товщина---",
            "1",
            "2",
            "3",
            "4",
            "5",
            "8",
            "10",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(479, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 31);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Visible = false;
            // 
            // vehicleData
            // 
            this.vehicleData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleData.Enabled = false;
            this.vehicleData.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vehicleData.Location = new System.Drawing.Point(450, 3);
            this.vehicleData.Name = "vehicleData";
            this.vehicleData.Size = new System.Drawing.Size(107, 31);
            this.vehicleData.TabIndex = 10;
            this.vehicleData.Text = "---машина---";
            this.vehicleData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adressData
            // 
            this.adressData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adressData.Enabled = false;
            this.adressData.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressData.Location = new System.Drawing.Point(152, 31);
            this.adressData.Name = "adressData";
            this.adressData.Size = new System.Drawing.Size(143, 31);
            this.adressData.TabIndex = 11;
            this.adressData.Text = "---адреса---";
            this.adressData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // driverData
            // 
            this.driverData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverData.Enabled = false;
            this.driverData.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverData.Location = new System.Drawing.Point(301, 31);
            this.driverData.Name = "driverData";
            this.driverData.Size = new System.Drawing.Size(107, 31);
            this.driverData.TabIndex = 12;
            this.driverData.Text = "---водій---";
            this.driverData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "test";
            this.dataSelectionBox.ResumeLayout(false);
            this.radioTable.ResumeLayout(false);
            this.radioTable.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.addPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addData)).EndInit();
            this.epsPanel.ResumeLayout(false);
            this.selectEpsTable.ResumeLayout(false);
            this.selectEpsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epsData)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.GroupBox dataSelectionBox;
        private System.Windows.Forms.RadioButton radioEPS;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.TableLayoutPanel radioTable;
        private System.Windows.Forms.RadioButton radioHead;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel selectEpsTable;
        private System.Windows.Forms.ComboBox markEPS;
        private System.Windows.Forms.TextBox packEPS;
        private System.Windows.Forms.ComboBox thikEPS;
        private System.Windows.Forms.TextBox amountEPS;
        private System.Windows.Forms.Label packEPSlabel;
        private System.Windows.Forms.Label amountEPSlabel;
        private System.Windows.Forms.Button addEpsToOrderButton;
        private System.Windows.Forms.Button downToFile;
        private System.Windows.Forms.DataGridView epsData;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn thikness;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn pack;
        private System.Windows.Forms.Panel epsPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox clientData;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addHeadData;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox meterADD;
        private System.Windows.Forms.ComboBox nameADD;
        private System.Windows.Forms.TextBox amountADD;
        private System.Windows.Forms.Button addAddToOrderButton;
        private System.Windows.Forms.DataGridView addData;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmADD;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtrADD;
        private System.Windows.Forms.DataGridViewTextBoxColumn amADD;
        private System.Windows.Forms.DateTimePicker headDate;
        private System.Windows.Forms.TextBox markData;
        private System.Windows.Forms.TextBox vehicleData;
        private System.Windows.Forms.TextBox adressData;
        private System.Windows.Forms.TextBox driverData;
    }
}

