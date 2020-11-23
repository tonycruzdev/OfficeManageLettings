
namespace ContractWordClient
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    partial class APCHomeList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.houseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripHomes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseDataGridView)).BeginInit();
            this.contextMenuStripHomes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.txtSearch);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(492, 60);
            this.Panel1.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(5, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(484, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label1.Location = new System.Drawing.Point(4, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(270, 18);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Search By Address or Tenant:";
            // 
            // houseBindingSource
            // 
            this.houseBindingSource.DataSource = typeof(LettingApiLib.Models.House);
            // 
            // houseDataGridView
            // 
            this.houseDataGridView.AllowUserToAddRows = false;
            this.houseDataGridView.AllowUserToDeleteRows = false;
            this.houseDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.houseDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.houseDataGridView.AutoGenerateColumns = false;
            this.houseDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.houseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.houseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7});
            this.houseDataGridView.ContextMenuStrip = this.contextMenuStripHomes;
            this.houseDataGridView.DataSource = this.houseBindingSource;
            this.houseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.houseDataGridView.Location = new System.Drawing.Point(0, 60);
            this.houseDataGridView.Name = "houseDataGridView";
            this.houseDataGridView.ReadOnly = true;
            this.houseDataGridView.RowHeadersVisible = false;
            this.houseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.houseDataGridView.Size = new System.Drawing.Size(492, 681);
            this.houseDataGridView.TabIndex = 14;
            this.houseDataGridView.DoubleClick += new System.EventHandler(this.houseDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Address1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Address";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Tenant1";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tenant";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // contextMenuStripHomes
            // 
            this.contextMenuStripHomes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editHomeToolStripMenuItem});
            this.contextMenuStripHomes.Name = "contextMenuStripHomes";
            this.contextMenuStripHomes.Size = new System.Drawing.Size(181, 48);
            // 
            // editHomeToolStripMenuItem
            // 
            this.editHomeToolStripMenuItem.Name = "editHomeToolStripMenuItem";
            this.editHomeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editHomeToolStripMenuItem.Text = "Edit Home";
            this.editHomeToolStripMenuItem.Click += new System.EventHandler(this.editHomeToolStripMenuItem_Click);
            // 
            // APCHomeList
            // 
            this.Controls.Add(this.houseDataGridView);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "APCHomeList";
            this.Size = new System.Drawing.Size(492, 741);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseDataGridView)).EndInit();
            this.contextMenuStripHomes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.BindingSource houseBindingSource;
        private System.Windows.Forms.DataGridView houseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripHomes;
        private System.Windows.Forms.ToolStripMenuItem editHomeToolStripMenuItem;
    }
}
