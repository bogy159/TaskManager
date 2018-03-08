namespace BogyWinFormTM.View
{
    partial class ListUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListUsers));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsMainNew = new System.Windows.Forms.ToolStripButton();
            this.tsMainEdit = new System.Windows.Forms.ToolStripButton();
            this.tsMainDelete = new System.Windows.Forms.ToolStripButton();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(503, 208);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tsMain
            // 
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMainNew,
            this.tsMainEdit,
            this.tsMainDelete});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(529, 25);
            this.tsMain.TabIndex = 1;
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
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(BogyWinFormTM.Entity.Users);
            this.usersBindingSource.CurrentChanged += new System.EventHandler(this.usersBindingSource_CurrentChanged);
            // 
            // ListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 248);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListUsers";
            this.Text = "List of users";
            this.Load += new System.EventHandler(this.ListUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsMainNew;
        private System.Windows.Forms.ToolStripButton tsMainEdit;
        private System.Windows.Forms.ToolStripButton tsMainDelete;

    }
}