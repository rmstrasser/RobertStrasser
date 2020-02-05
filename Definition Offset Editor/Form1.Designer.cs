namespace Definition_Offset_Editor
{
    partial class frmMain
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
            this.btn_loadXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_make = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_mfc = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.lblCalcOff = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dataGridXml = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTable = new System.Windows.Forms.TabPage();
            this.tabMonitor = new System.Windows.Forms.TabPage();
            this.dataGridMonitor = new System.Windows.Forms.DataGridView();
            this.rbHexAdd = new System.Windows.Forms.RadioButton();
            this.rbManOff = new System.Windows.Forms.RadioButton();
            this.lbl_rowcount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_binLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridXml)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabTable.SuspendLayout();
            this.tabMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_loadXML
            // 
            this.btn_loadXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadXML.Location = new System.Drawing.Point(229, 60);
            this.btn_loadXML.Name = "btn_loadXML";
            this.btn_loadXML.Size = new System.Drawing.Size(86, 26);
            this.btn_loadXML.TabIndex = 1;
            this.btn_loadXML.Text = "Load XML";
            this.btn_loadXML.UseVisualStyleBackColor = true;
            this.btn_loadXML.Click += new System.EventHandler(this.btn_loadXML_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Make:";
            // 
            // lbl_make
            // 
            this.lbl_make.AutoSize = true;
            this.lbl_make.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_make.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_make.Location = new System.Drawing.Point(74, 27);
            this.lbl_make.Name = "lbl_make";
            this.lbl_make.Size = new System.Drawing.Size(41, 16);
            this.lbl_make.TabIndex = 3;
            this.lbl_make.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model:";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.Location = new System.Drawing.Point(76, 50);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(41, 16);
            this.lbl_model.TabIndex = 5;
            this.lbl_model.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manufacturer:";
            // 
            // lbl_mfc
            // 
            this.lbl_mfc.AutoSize = true;
            this.lbl_mfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mfc.Location = new System.Drawing.Point(302, 27);
            this.lbl_mfc.Name = "lbl_mfc";
            this.lbl_mfc.Size = new System.Drawing.Size(41, 16);
            this.lbl_mfc.TabIndex = 7;
            this.lbl_mfc.Text = "None";
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(500, 62);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(243, 22);
            this.txt_input.TabIndex = 8;
            // 
            // btn_calc
            // 
            this.btn_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.Location = new System.Drawing.Point(553, 96);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(120, 26);
            this.btn_calc.TabIndex = 9;
            this.btn_calc.Text = "Offset Selection";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // lblCalcOff
            // 
            this.lblCalcOff.AutoSize = true;
            this.lblCalcOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcOff.Location = new System.Drawing.Point(631, 136);
            this.lblCalcOff.Name = "lblCalcOff";
            this.lblCalcOff.Size = new System.Drawing.Size(15, 16);
            this.lblCalcOff.TabIndex = 13;
            this.lblCalcOff.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Calculated Offset:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.lbl_mfc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_model);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_make);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_loadXML);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 102);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load:";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(331, 60);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(86, 26);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save XML";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dataGridXml
            // 
            this.dataGridXml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridXml.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridXml.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridXml.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridXml.Location = new System.Drawing.Point(29, 26);
            this.dataGridXml.Name = "dataGridXml";
            this.dataGridXml.Size = new System.Drawing.Size(1181, 331);
            this.dataGridXml.TabIndex = 0;
            this.dataGridXml.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridXml_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Enter new address or manual offset:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabTable);
            this.tabControl1.Controls.Add(this.tabMonitor);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(22, 155);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1258, 414);
            this.tabControl1.TabIndex = 17;
            // 
            // tabTable
            // 
            this.tabTable.Controls.Add(this.dataGridXml);
            this.tabTable.Location = new System.Drawing.Point(4, 25);
            this.tabTable.Name = "tabTable";
            this.tabTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTable.Size = new System.Drawing.Size(1250, 385);
            this.tabTable.TabIndex = 0;
            this.tabTable.Text = "Table";
            this.tabTable.UseVisualStyleBackColor = true;
            // 
            // tabMonitor
            // 
            this.tabMonitor.Controls.Add(this.dataGridMonitor);
            this.tabMonitor.Location = new System.Drawing.Point(4, 25);
            this.tabMonitor.Name = "tabMonitor";
            this.tabMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonitor.Size = new System.Drawing.Size(1250, 385);
            this.tabMonitor.TabIndex = 1;
            this.tabMonitor.Text = "Monitor";
            this.tabMonitor.UseVisualStyleBackColor = true;
            // 
            // dataGridMonitor
            // 
            this.dataGridMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMonitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMonitor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridMonitor.Location = new System.Drawing.Point(28, 21);
            this.dataGridMonitor.Name = "dataGridMonitor";
            this.dataGridMonitor.Size = new System.Drawing.Size(1194, 483);
            this.dataGridMonitor.TabIndex = 1;
            // 
            // rbHexAdd
            // 
            this.rbHexAdd.AutoSize = true;
            this.rbHexAdd.Checked = true;
            this.rbHexAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHexAdd.Location = new System.Drawing.Point(490, 20);
            this.rbHexAdd.Name = "rbHexAdd";
            this.rbHexAdd.Size = new System.Drawing.Size(104, 20);
            this.rbHexAdd.TabIndex = 18;
            this.rbHexAdd.TabStop = true;
            this.rbHexAdd.Text = "Hex Address";
            this.rbHexAdd.UseVisualStyleBackColor = true;
            // 
            // rbManOff
            // 
            this.rbManOff.AutoSize = true;
            this.rbManOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManOff.Location = new System.Drawing.Point(624, 20);
            this.rbManOff.Name = "rbManOff";
            this.rbManOff.Size = new System.Drawing.Size(107, 20);
            this.rbManOff.TabIndex = 19;
            this.rbManOff.Text = "Manual Offset";
            this.rbManOff.UseVisualStyleBackColor = true;
            // 
            // lbl_rowcount
            // 
            this.lbl_rowcount.AutoSize = true;
            this.lbl_rowcount.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_rowcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rowcount.Location = new System.Drawing.Point(115, 130);
            this.lbl_rowcount.Name = "lbl_rowcount";
            this.lbl_rowcount.Size = new System.Drawing.Size(15, 16);
            this.lbl_rowcount.TabIndex = 10;
            this.lbl_rowcount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Row Count:";
            // 
            // btn_binLoad
            // 
            this.btn_binLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_binLoad.Location = new System.Drawing.Point(299, 126);
            this.btn_binLoad.Name = "btn_binLoad";
            this.btn_binLoad.Size = new System.Drawing.Size(106, 26);
            this.btn_binLoad.TabIndex = 9;
            this.btn_binLoad.Text = "Load Binary";
            this.btn_binLoad.UseVisualStyleBackColor = true;
            this.btn_binLoad.Click += new System.EventHandler(this.btn_binLoad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(26, 584);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(832, 273);
            this.dataGridView1.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 1041);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_binLoad);
            this.Controls.Add(this.lbl_rowcount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbManOff);
            this.Controls.Add(this.rbHexAdd);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCalcOff);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.txt_input);
            this.Name = "frmMain";
            this.Text = "Definition Offset Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridXml)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabTable.ResumeLayout(false);
            this.tabMonitor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_loadXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_make;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_mfc;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lblCalcOff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridXml;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTable;
        private System.Windows.Forms.TabPage tabMonitor;
        private System.Windows.Forms.RadioButton rbHexAdd;
        private System.Windows.Forms.RadioButton rbManOff;
        private System.Windows.Forms.DataGridView dataGridMonitor;
        private System.Windows.Forms.Label lbl_rowcount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_binLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

