namespace Demo1
{
    partial class customLessonPlant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customLessonPlant));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLessonPlant = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outcome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.add = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLessonPlant)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.tableLessonPlant);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 640);
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
            this.btnBack.Location = new System.Drawing.Point(474, 589);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.btnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBack.Padding = new System.Windows.Forms.Padding(6);
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(110, 40);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnSave.Location = new System.Drawing.Point(345, 589);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLessonPlant
            // 
            this.tableLessonPlant.AllowUserToAddRows = false;
            this.tableLessonPlant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLessonPlant.BackgroundColor = System.Drawing.Color.White;
            this.tableLessonPlant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(232)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableLessonPlant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableLessonPlant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLessonPlant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.level1,
            this.level2,
            this.level3,
            this.level4,
            this.Outcome,
            this.qualification,
            this.kind,
            this.plant,
            this.edit,
            this.delete,
            this.add});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableLessonPlant.DefaultCellStyle = dataGridViewCellStyle10;
            this.tableLessonPlant.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.tableLessonPlant.Location = new System.Drawing.Point(0, 0);
            this.tableLessonPlant.Name = "tableLessonPlant";
            this.tableLessonPlant.Size = new System.Drawing.Size(899, 583);
            this.tableLessonPlant.TabIndex = 5;
            this.tableLessonPlant.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableLessonPlant_CellClick);
            this.tableLessonPlant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableLessonPlant_CellContentClick);
            this.tableLessonPlant.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableLessonPlant_CellDoubleClick);
            this.tableLessonPlant.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tableLessonPlant_DataBindingComplete);
            // 
            // ID
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.FillWeight = 22.84264F;
            this.ID.Frozen = true;
            this.ID.HeaderText = "STT";
            this.ID.Name = "ID";
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 32;
            // 
            // level1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.level1.DefaultCellStyle = dataGridViewCellStyle3;
            this.level1.FillWeight = 22.84264F;
            this.level1.Frozen = true;
            this.level1.HeaderText = "Mã học phần";
            this.level1.Name = "level1";
            this.level1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.level1.Width = 95;
            // 
            // level2
            // 
            this.level2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.level2.FillWeight = 22.84264F;
            this.level2.HeaderText = "Tên học phần";
            this.level2.Name = "level2";
            this.level2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // level3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.level3.DefaultCellStyle = dataGridViewCellStyle4;
            this.level3.FillWeight = 22.84264F;
            this.level3.HeaderText = "Số TC";
            this.level3.Name = "level3";
            this.level3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.level3.Width = 40;
            // 
            // level4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.level4.DefaultCellStyle = dataGridViewCellStyle5;
            this.level4.FillWeight = 315.0504F;
            this.level4.HeaderText = "Số tiết      Lý thuyết";
            this.level4.Name = "level4";
            this.level4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.level4.Width = 72;
            // 
            // Outcome
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Outcome.DefaultCellStyle = dataGridViewCellStyle6;
            this.Outcome.FillWeight = 450.5344F;
            this.Outcome.HeaderText = "Số tiết Thực hành";
            this.Outcome.Name = "Outcome";
            this.Outcome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Outcome.Width = 70;
            // 
            // qualification
            // 
            this.qualification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qualification.DefaultCellStyle = dataGridViewCellStyle7;
            this.qualification.FillWeight = 14.34823F;
            this.qualification.HeaderText = "Số tiết Bài tập";
            this.qualification.Name = "qualification";
            this.qualification.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.qualification.Width = 60;
            // 
            // kind
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kind.DefaultCellStyle = dataGridViewCellStyle8;
            this.kind.HeaderText = "Loại học phần";
            this.kind.Name = "kind";
            this.kind.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.kind.Width = 75;
            // 
            // plant
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.plant.DefaultCellStyle = dataGridViewCellStyle9;
            this.plant.HeaderText = "Kế hoạch giảng dạy";
            this.plant.Name = "plant";
            this.plant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.plant.Width = 80;
            // 
            // edit
            // 
            this.edit.HeaderText = "Edit";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.Width = 40;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Width = 50;
            // 
            // add
            // 
            this.add.HeaderText = "Insert";
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.add.Name = "add";
            this.add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.add.Width = 50;
            // 
            // customLessonPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "customLessonPlant";
            this.Size = new System.Drawing.Size(900, 640);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableLessonPlant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        public System.Windows.Forms.DataGridView tableLessonPlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn level1;
        private System.Windows.Forms.DataGridViewTextBoxColumn level2;
        private System.Windows.Forms.DataGridViewTextBoxColumn level3;
        private System.Windows.Forms.DataGridViewTextBoxColumn level4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outcome;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn plant;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewImageColumn add;
    }
}
