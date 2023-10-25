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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.orderLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downToFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.epsData = new System.Windows.Forms.DataGridView();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thikness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.packEPS = new System.Windows.Forms.TextBox();
            this.thikEPS = new System.Windows.Forms.ComboBox();
            this.markEPS = new System.Windows.Forms.ComboBox();
            this.amountEPS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epsData)).BeginInit();
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
            this.orderLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.orderLabel.Size = new System.Drawing.Size(760, 60);
            this.orderLabel.TabIndex = 1;
            this.orderLabel.Text = "замовлення";
            this.orderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.downToFile);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "заповнення";
            // 
            // downToFile
            // 
            this.downToFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.downToFile.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downToFile.Location = new System.Drawing.Point(526, 32);
            this.downToFile.Name = "downToFile";
            this.downToFile.Size = new System.Drawing.Size(219, 63);
            this.downToFile.TabIndex = 4;
            this.downToFile.Text = "вивантажити";
            this.downToFile.UseVisualStyleBackColor = true;
            this.downToFile.Click += new System.EventHandler(this.downToFile_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.radioButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 63);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(150, 57);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "реквізити";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton3.Location = new System.Drawing.Point(315, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(151, 57);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "додаткові";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton2.Location = new System.Drawing.Point(159, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(150, 57);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "пінопласт";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
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
            this.splitContainer1.SplitterDistance = 60;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.epsData);
            this.splitContainer2.Panel2.Controls.Add(this.addToOrderButton);
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(754, 520);
            this.splitContainer2.SplitterDistance = 115;
            this.splitContainer2.TabIndex = 3;
            // 
            // epsData
            // 
            this.epsData.AllowUserToAddRows = false;
            this.epsData.AllowUserToDeleteRows = false;
            this.epsData.AllowUserToResizeColumns = false;
            this.epsData.AllowUserToResizeRows = false;
            this.epsData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.epsData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.epsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.epsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mark,
            this.thikness,
            this.amount,
            this.pack});
            this.epsData.Location = new System.Drawing.Point(508, 85);
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
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.mark.DefaultCellStyle = dataGridViewCellStyle33;
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
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.thikness.DefaultCellStyle = dataGridViewCellStyle34;
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
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.amount.DefaultCellStyle = dataGridViewCellStyle35;
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
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pack.DefaultCellStyle = dataGridViewCellStyle36;
            this.pack.DividerWidth = 1;
            this.pack.FillWeight = 50F;
            this.pack.HeaderText = "упаковок";
            this.pack.MinimumWidth = 50;
            this.pack.Name = "pack";
            this.pack.ReadOnly = true;
            this.pack.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pack.Width = 60;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addToOrderButton.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addToOrderButton.Location = new System.Drawing.Point(47, 85);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(406, 70);
            this.addToOrderButton.TabIndex = 2;
            this.addToOrderButton.Text = "додати в замовлення";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.packEPS, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.thikEPS, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.markEPS, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.amountEPS, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(748, 76);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(638, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "упаковок";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(526, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "кількість";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(377, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "товщина";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // packEPS
            // 
            this.packEPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.packEPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packEPS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.packEPS.Location = new System.Drawing.Point(638, 33);
            this.packEPS.Name = "packEPS";
            this.packEPS.Size = new System.Drawing.Size(107, 31);
            this.packEPS.TabIndex = 2;
            this.packEPS.Leave += new System.EventHandler(this.packEPS_Leave);
            // 
            // thikEPS
            // 
            this.thikEPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thikEPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.thikEPS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thikEPS.FormattingEnabled = true;
            this.thikEPS.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "8",
            "10",
            "12"});
            this.thikEPS.Location = new System.Drawing.Point(377, 33);
            this.thikEPS.Name = "thikEPS";
            this.thikEPS.Size = new System.Drawing.Size(143, 31);
            this.thikEPS.TabIndex = 1;
            this.thikEPS.SelectedIndexChanged += new System.EventHandler(this.thikEPS_SelectedIndexChanged);
            // 
            // markEPS
            // 
            this.markEPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markEPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.markEPS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markEPS.FormattingEnabled = true;
            this.markEPS.Items.AddRange(new object[] {
            "",
            "eps s",
            "eps 30",
            "eps 50",
            "eps 60"});
            this.markEPS.Location = new System.Drawing.Point(3, 33);
            this.markEPS.Name = "markEPS";
            this.markEPS.Size = new System.Drawing.Size(368, 31);
            this.markEPS.TabIndex = 0;
            this.markEPS.SelectedIndexChanged += new System.EventHandler(this.markEPS_SelectedIndexChanged);
            // 
            // amountEPS
            // 
            this.amountEPS.BackColor = System.Drawing.SystemColors.ControlLight;
            this.amountEPS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.amountEPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amountEPS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountEPS.HideSelection = false;
            this.amountEPS.Location = new System.Drawing.Point(526, 33);
            this.amountEPS.Name = "amountEPS";
            this.amountEPS.Size = new System.Drawing.Size(106, 31);
            this.amountEPS.TabIndex = 3;
            this.amountEPS.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "марка";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epsData)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox markEPS;
        private System.Windows.Forms.TextBox packEPS;
        private System.Windows.Forms.ComboBox thikEPS;
        private System.Windows.Forms.TextBox amountEPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.Button downToFile;
        private System.Windows.Forms.DataGridView epsData;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn thikness;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn pack;
    }
}

