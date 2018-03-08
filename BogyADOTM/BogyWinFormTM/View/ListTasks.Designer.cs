namespace BogyWinFormTM.View
{
    partial class ListTasks
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListTasks));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsMainNew = new System.Windows.Forms.ToolStripButton();
            this.tsMainEdit = new System.Windows.Forms.ToolStripButton();
            this.tsMainDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tasksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatorUN = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Executive = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.estTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTasksBindingSource)).BeginInit();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.creatorDataGridViewTextBoxColumn,
            this.CreatorUN,
            this.Executive,
            this.estTimeDataGridViewTextBoxColumn,
            this.assignedDataGridViewTextBoxColumn,
            this.creTimeDataGridViewTextBoxColumn,
            this.finalDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.mTasksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(705, 195);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mTasksBindingSource
            // 
            this.mTasksBindingSource.DataSource = typeof(BogyWinFormTM.Entity.MTasks);
            // 
            // tsMain
            // 
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMainNew,
            this.tsMainEdit,
            this.tsMainDelete,
            this.toolStripButton3});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(728, 25);
            this.tsMain.TabIndex = 2;
            this.tsMain.Text = "toolStrip1";
            this.tsMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsMain_ItemClicked);
            // 
            // tsMainNew
            // 
            this.tsMainNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMainNew.Image = ((System.Drawing.Image)(resources.GetObject("tsMainNew.Image")));
            this.tsMainNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMainNew.Name = "tsMainNew";
            this.tsMainNew.Size = new System.Drawing.Size(35, 22);
            this.tsMainNew.Text = "New";
            this.tsMainNew.Click += new System.EventHandler(this.tsMainNew_Click);
            // 
            // tsMainEdit
            // 
            this.tsMainEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMainEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsMainEdit.Image")));
            this.tsMainEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMainEdit.Name = "tsMainEdit";
            this.tsMainEdit.Size = new System.Drawing.Size(31, 22);
            this.tsMainEdit.Text = "Edit";
            this.tsMainEdit.Click += new System.EventHandler(this.tsMainEdit_Click);
            // 
            // tsMainDelete
            // 
            this.tsMainDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMainDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsMainDelete.Image")));
            this.tsMainDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMainDelete.Name = "tsMainDelete";
            this.tsMainDelete.Size = new System.Drawing.Size(44, 22);
            this.tsMainDelete.Text = "Delete";
            this.tsMainDelete.Click += new System.EventHandler(this.tsMainDelete_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(42, 22);
            this.toolStripButton3.Text = "Finish";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(12, 226);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(82, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(35, 22);
            this.toolStripButton1.Text = "New";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton2.Text = "Delete";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 254);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(504, 172);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(BogyWinFormTM.Entity.Users);
            this.usersBindingSource.CurrentChanged += new System.EventHandler(this.usersBindingSource_CurrentChanged);
            // 
            // timeBindingSource
            // 
            this.timeBindingSource.DataSource = typeof(BogyWinFormTM.Entity.Users);
            // 
            // taskIdDataGridViewTextBoxColumn
            // 
            this.taskIdDataGridViewTextBoxColumn.DataPropertyName = "TaskId";
            this.taskIdDataGridViewTextBoxColumn.HeaderText = "Task Id";
            this.taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
            this.taskIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creatorDataGridViewTextBoxColumn
            // 
            this.creatorDataGridViewTextBoxColumn.DataPropertyName = "Creator";
            this.creatorDataGridViewTextBoxColumn.HeaderText = "Creator";
            this.creatorDataGridViewTextBoxColumn.Name = "creatorDataGridViewTextBoxColumn";
            this.creatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.creatorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.creatorDataGridViewTextBoxColumn.Visible = false;
            // 
            // CreatorUN
            // 
            this.CreatorUN.DataPropertyName = "Creator";
            this.CreatorUN.DataSource = this.usersBindingSource;
            this.CreatorUN.DisplayMember = "Username";
            this.CreatorUN.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.CreatorUN.HeaderText = "CreatorUN";
            this.CreatorUN.Name = "CreatorUN";
            this.CreatorUN.ReadOnly = true;
            this.CreatorUN.ValueMember = "UserId";
            // 
            // Executive
            // 
            this.Executive.DataPropertyName = "Assigned";
            this.Executive.DataSource = this.usersBindingSource;
            this.Executive.DisplayMember = "Username";
            this.Executive.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Executive.HeaderText = "Executive";
            this.Executive.Name = "Executive";
            this.Executive.ReadOnly = true;
            this.Executive.ValueMember = "UserId";
            // 
            // estTimeDataGridViewTextBoxColumn
            // 
            this.estTimeDataGridViewTextBoxColumn.DataPropertyName = "EstTime";
            this.estTimeDataGridViewTextBoxColumn.HeaderText = "EstTime";
            this.estTimeDataGridViewTextBoxColumn.Name = "estTimeDataGridViewTextBoxColumn";
            this.estTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assignedDataGridViewTextBoxColumn
            // 
            this.assignedDataGridViewTextBoxColumn.DataPropertyName = "Assigned";
            this.assignedDataGridViewTextBoxColumn.HeaderText = "Assigned";
            this.assignedDataGridViewTextBoxColumn.Name = "assignedDataGridViewTextBoxColumn";
            this.assignedDataGridViewTextBoxColumn.ReadOnly = true;
            this.assignedDataGridViewTextBoxColumn.Visible = false;
            // 
            // creTimeDataGridViewTextBoxColumn
            // 
            this.creTimeDataGridViewTextBoxColumn.DataPropertyName = "CreTime";
            this.creTimeDataGridViewTextBoxColumn.HeaderText = "CreTime";
            this.creTimeDataGridViewTextBoxColumn.Name = "creTimeDataGridViewTextBoxColumn";
            this.creTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalDataGridViewCheckBoxColumn
            // 
            this.finalDataGridViewCheckBoxColumn.DataPropertyName = "Final";
            this.finalDataGridViewCheckBoxColumn.HeaderText = "Final";
            this.finalDataGridViewCheckBoxColumn.Name = "finalDataGridViewCheckBoxColumn";
            this.finalDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ListTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 437);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListTasks";
            this.Text = "List of tasks";
            this.Load += new System.EventHandler(this.ListTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTasksBindingSource)).EndInit();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsMainNew;
        private System.Windows.Forms.ToolStripButton tsMainEdit;
        private System.Windows.Forms.ToolStripButton tsMainDelete;
        private System.Windows.Forms.BindingSource tasksBindingSource1;
        private System.Windows.Forms.BindingSource mTasksBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource timeBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CreatorUN;
        private System.Windows.Forms.DataGridViewComboBoxColumn Executive;
        private System.Windows.Forms.DataGridViewTextBoxColumn estTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finalDataGridViewCheckBoxColumn;

    }
}