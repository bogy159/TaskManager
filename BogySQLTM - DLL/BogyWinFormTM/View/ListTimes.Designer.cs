namespace BogyWinFormTM.View
{
    partial class ListTimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListTimes));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsMainNew = new System.Windows.Forms.ToolStripButton();
            this.tsMainDelete = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMainNew,
            this.tsMainDelete});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(528, 25);
            this.tsMain.TabIndex = 3;
            this.tsMain.Text = "toolStrip1";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(504, 208);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // timeBindingSource
            // 
            this.timeBindingSource.DataSource = typeof(BogyWinFormTM.Entity.Users);
            this.timeBindingSource.CurrentChanged += new System.EventHandler(this.usersBindingSource_CurrentChanged);
            // 
            // ListTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 248);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tsMain);
            this.Name = "ListTimes";
            this.Text = "List of time info";
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsMainNew;
        private System.Windows.Forms.ToolStripButton tsMainDelete;
        private System.Windows.Forms.BindingSource timeBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}