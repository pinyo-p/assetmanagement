namespace assetmanagement
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dlPlace = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgAsset = new System.Windows.Forms.DataGridView();
            this.rfid_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asset_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asset_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbStatus);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dlPlace);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ตรวจสอบรายการสินทรัพย์ถาวร";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(78, 71);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 22);
            this.lbStatus.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ตกลง";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(81, 48);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(305, 20);
            this.txtCode.TabIndex = 3;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            this.txtCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RFID CODE";
            // 
            // dlPlace
            // 
            this.dlPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dlPlace.FormattingEnabled = true;
            this.dlPlace.Location = new System.Drawing.Point(81, 20);
            this.dlPlace.Name = "dlPlace";
            this.dlPlace.Size = new System.Drawing.Size(411, 21);
            this.dlPlace.TabIndex = 1;
            this.dlPlace.SelectedIndexChanged += new System.EventHandler(this.dlPlace_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "สถานที่";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.dgAsset);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 353);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รายการสินทรัพย์";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 37);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(690, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgAsset
            // 
            this.dgAsset.AllowUserToAddRows = false;
            this.dgAsset.AllowUserToDeleteRows = false;
            this.dgAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAsset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rfid_code,
            this.asset_code,
            this.asset_name,
            this.status});
            this.dgAsset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAsset.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgAsset.Location = new System.Drawing.Point(3, 16);
            this.dgAsset.MultiSelect = false;
            this.dgAsset.Name = "dgAsset";
            this.dgAsset.ReadOnly = true;
            this.dgAsset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAsset.Size = new System.Drawing.Size(768, 334);
            this.dgAsset.TabIndex = 0;
            this.dgAsset.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAsset_CellClick);
            this.dgAsset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAsset_CellContentClick);
            this.dgAsset.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAsset_CellDoubleClick);
            // 
            // rfid_code
            // 
            this.rfid_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rfid_code.HeaderText = "RFID CODE";
            this.rfid_code.Name = "rfid_code";
            this.rfid_code.ReadOnly = true;
            // 
            // asset_code
            // 
            this.asset_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asset_code.HeaderText = "รหัสสินทรัพย์";
            this.asset_code.Name = "asset_code";
            this.asset_code.ReadOnly = true;
            // 
            // asset_name
            // 
            this.asset_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asset_name.HeaderText = "ชื่อสินทรัพย์";
            this.asset_name.Name = "asset_name";
            this.asset_name.ReadOnly = true;
            // 
            // status
            // 
            this.status.FillWeight = 200F;
            this.status.HeaderText = "สถานะการตรวจสอบ";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 455);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ตรวจสอบสินทรัพย์";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dlPlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgAsset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfid_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn asset_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn asset_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}

