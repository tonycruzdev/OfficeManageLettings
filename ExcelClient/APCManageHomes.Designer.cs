
namespace ExcelClient
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    partial class APCManageHomes
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
            this.buttonLoadHomes = new System.Windows.Forms.Button();
            this.buttonLoadLandlords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadHomes
            // 
            this.buttonLoadHomes.Location = new System.Drawing.Point(3, 14);
            this.buttonLoadHomes.Name = "buttonLoadHomes";
            this.buttonLoadHomes.Size = new System.Drawing.Size(370, 40);
            this.buttonLoadHomes.TabIndex = 0;
            this.buttonLoadHomes.Text = "Load Homes";
            this.buttonLoadHomes.UseVisualStyleBackColor = true;
            this.buttonLoadHomes.Click += new System.EventHandler(this.buttonLoadHomes_Click);
            // 
            // buttonLoadLandlords
            // 
            this.buttonLoadLandlords.Location = new System.Drawing.Point(3, 60);
            this.buttonLoadLandlords.Name = "buttonLoadLandlords";
            this.buttonLoadLandlords.Size = new System.Drawing.Size(370, 40);
            this.buttonLoadLandlords.TabIndex = 1;
            this.buttonLoadLandlords.Text = "Load Landlords";
            this.buttonLoadLandlords.UseVisualStyleBackColor = true;
            this.buttonLoadLandlords.Click += new System.EventHandler(this.buttonLoadLandlords_Click);
            // 
            // APCManageHomes
            // 
            this.Controls.Add(this.buttonLoadLandlords);
            this.Controls.Add(this.buttonLoadHomes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "APCManageHomes";
            this.Size = new System.Drawing.Size(376, 806);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadHomes;
        private System.Windows.Forms.Button buttonLoadLandlords;
    }
}
