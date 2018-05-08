namespace Demo1
{
    partial class customCourseLearning
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customCourseLearning));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableCourseLearning = new System.Windows.Forms.DataGridView();
            this.level1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outcome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.add = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCourseLearning)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.tableCourseLearning);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 670);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 0;
            this.btnBack.ButtonText = "Back";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBack.Iconimage")));
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 70D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(474, 619);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.btnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBack.Padding = new System.Windows.Forms.Padding(6);
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(110, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 70D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(345, 619);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableCourseLearning
            // 
            this.tableCourseLearning.AllowUserToAddRows = false;
            this.tableCourseLearning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableCourseLearning.BackgroundColor = System.Drawing.Color.White;
            this.tableCourseLearning.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableCourseLearning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCourseLearning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.level1,
            this.level2,
            this.level3,
            this.level4,
            this.Outcome,
            this.qualification,
            this.edit,
            this.delete,
            this.add});
            this.tableCourseLearning.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.tableCourseLearning.Location = new System.Drawing.Point(0, 0);
            this.tableCourseLearning.Name = "tableCourseLearning";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableCourseLearning.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableCourseLearning.Size = new System.Drawing.Size(899, 614);
            this.tableCourseLearning.TabIndex = 2;
            this.tableCourseLearning.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableCourseLearning_CellClick);
            this.tableCourseLearning.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableCourseLearning_CellContentClick);
            this.tableCourseLearning.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableCourseLearning_CellDoubleClick);
            this.tableCourseLearning.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tableCourseLearning_DataBindingComplete);
            // 
            // level1
            // 
            this.level1.FillWeight = 22.84264F;
            this.level1.Frozen = true;
            this.level1.HeaderText = "";
            this.level1.Name = "level1";
            this.level1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.level1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.level1.Width = 30;
            // 
            // level2
            // 
            this.level2.FillWeight = 22.84264F;
            this.level2.Frozen = true;
            this.level2.HeaderText = "";
            this.level2.Name = "level2";
            this.level2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.level2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.level2.Width = 30;
            // 
            // level3
            // 
            this.level3.FillWeight = 22.84264F;
            this.level3.Frozen = true;
            this.level3.HeaderText = "";
            this.level3.Name = "level3";
            this.level3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.level3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.level3.Width = 30;
            // 
            // level4
            // 
            this.level4.FillWeight = 315.0504F;
            this.level4.Frozen = true;
            this.level4.HeaderText = "";
            this.level4.Name = "level4";
            this.level4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.level4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.level4.Width = 30;
            // 
            // Outcome
            // 
            this.Outcome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Outcome.FillWeight = 450.5344F;
            this.Outcome.HeaderText = "Chuẩn đầu ra";
            this.Outcome.Name = "Outcome";
            this.Outcome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // qualification
            // 
            this.qualification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qualification.DefaultCellStyle = dataGridViewCellStyle1;
            this.qualification.FillWeight = 14.34823F;
            this.qualification.HeaderText = "Trình độ năng lực";
            this.qualification.Name = "qualification";
            this.qualification.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qualification.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.qualification.Width = 140;
            // 
            // edit
            // 
            this.edit.HeaderText = "Edit";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.Width = 50;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Width = 52;
            // 
            // add
            // 
            this.add.HeaderText = "Insert";
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.add.Name = "add";
            this.add.Width = 50;
            // 
            // customCourseLearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "customCourseLearning";
            this.Size = new System.Drawing.Size(900, 670);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableCourseLearning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView tableCourseLearning;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn level1;
        private System.Windows.Forms.DataGridViewTextBoxColumn level2;
        private System.Windows.Forms.DataGridViewTextBoxColumn level3;
        private System.Windows.Forms.DataGridViewTextBoxColumn level4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outcome;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualification;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewImageColumn add;

    }
}
