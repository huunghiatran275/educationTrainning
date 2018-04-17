namespace Demo1
{
    partial class customMatrix
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customMatrix));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChange = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableMatrix = new System.Windows.Forms.DataGridView();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnResetColor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnResetColor);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.tableMatrix);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 640);
            this.panel1.TabIndex = 0;
            // 
            // btnChange
            // 
            this.btnChange.Activecolor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChange.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChange.BorderRadius = 0;
            this.btnChange.ButtonText = "Change";
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.DisabledColor = System.Drawing.Color.Gray;
            this.btnChange.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChange.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChange.Iconimage")));
            this.btnChange.Iconimage_right = null;
            this.btnChange.Iconimage_right_Selected = null;
            this.btnChange.Iconimage_Selected = null;
            this.btnChange.IconMarginLeft = 0;
            this.btnChange.IconMarginRight = 0;
            this.btnChange.IconRightVisible = true;
            this.btnChange.IconRightZoom = 0D;
            this.btnChange.IconVisible = true;
            this.btnChange.IconZoom = 65D;
            this.btnChange.IsTab = false;
            this.btnChange.Location = new System.Drawing.Point(345, 591);
            this.btnChange.Name = "btnChange";
            this.btnChange.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnChange.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.btnChange.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChange.selected = false;
            this.btnChange.Size = new System.Drawing.Size(110, 40);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "Change";
            this.btnChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChange.Textcolor = System.Drawing.Color.White;
            this.btnChange.TextFont = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
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
            this.btnBack.Location = new System.Drawing.Point(474, 591);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.btnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBack.Padding = new System.Windows.Forms.Padding(6);
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(110, 40);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tableMatrix
            // 
            this.tableMatrix.AllowUserToAddRows = false;
            this.tableMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tableMatrix.BackgroundColor = System.Drawing.Color.White;
            this.tableMatrix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableMatrix.ColumnHeadersVisible = false;
            this.tableMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit,
            this.delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableMatrix.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableMatrix.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.tableMatrix.Location = new System.Drawing.Point(0, 0);
            this.tableMatrix.Name = "tableMatrix";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableMatrix.RowHeadersWidth = 40;
            this.tableMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableMatrix.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableMatrix.Size = new System.Drawing.Size(900, 586);
            this.tableMatrix.TabIndex = 0;
            this.tableMatrix.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMatrix_CellClick);
            this.tableMatrix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMatrix_CellContentClick);
            this.tableMatrix.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tableMatrix_DataBindingComplete);
            // 
            // edit
            // 
            this.edit.HeaderText = "edit";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit.Name = "edit";
            this.edit.Width = 5;
            // 
            // delete
            // 
            this.delete.HeaderText = "detele";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.Width = 5;
            // 
            // btnResetColor
            // 
            this.btnResetColor.Activecolor = System.Drawing.SystemColors.MenuHighlight;
            this.btnResetColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnResetColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetColor.BorderRadius = 0;
            this.btnResetColor.ButtonText = "resetColor";
            this.btnResetColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetColor.DisabledColor = System.Drawing.Color.Gray;
            this.btnResetColor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnResetColor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnResetColor.Iconimage")));
            this.btnResetColor.Iconimage_right = null;
            this.btnResetColor.Iconimage_right_Selected = null;
            this.btnResetColor.Iconimage_Selected = null;
            this.btnResetColor.IconMarginLeft = 0;
            this.btnResetColor.IconMarginRight = 0;
            this.btnResetColor.IconRightVisible = true;
            this.btnResetColor.IconRightZoom = 0D;
            this.btnResetColor.IconVisible = true;
            this.btnResetColor.IconZoom = 70D;
            this.btnResetColor.IsTab = false;
            this.btnResetColor.Location = new System.Drawing.Point(613, 591);
            this.btnResetColor.Name = "btnResetColor";
            this.btnResetColor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnResetColor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.btnResetColor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnResetColor.Padding = new System.Windows.Forms.Padding(6);
            this.btnResetColor.selected = false;
            this.btnResetColor.Size = new System.Drawing.Size(131, 40);
            this.btnResetColor.TabIndex = 13;
            this.btnResetColor.Text = "resetColor";
            this.btnResetColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResetColor.Textcolor = System.Drawing.Color.White;
            this.btnResetColor.TextFont = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetColor.Click += new System.EventHandler(this.btnResetColor_Click);
            // 
            // customMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "customMatrix";
            this.Size = new System.Drawing.Size(900, 640);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView tableMatrix;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        public Bunifu.Framework.UI.BunifuFlatButton btnChange;
        private Bunifu.Framework.UI.BunifuFlatButton btnResetColor;
    }
}
