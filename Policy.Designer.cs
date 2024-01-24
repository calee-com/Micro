namespace MICRO
{
    partial class Policy
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Home insurance also known as domestic package provides protection to house plus p" +
        "osessions (building, electronics, furniture, clothes, cell phones etc) if stolen" +
        " or damaged.");
            this.VIEW= new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // VIEW
            // 
            this.VIEW.HideSelection = false;
            this.VIEW.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.VIEW.Location = new System.Drawing.Point(2, 1);
            this.VIEW.Name = "VIEW";
            this.VIEW.Size = new System.Drawing.Size(786, 411);
            this.VIEW.TabIndex = 0;
            this.VIEW.UseCompatibleStateImageBehavior = false;
            this.VIEW.View = System.Windows.Forms.View.Details;
            this.VIEW.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Policy
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VIEW);
            this.Name = "Policy";
            this.Text = "Policy";
            this.Load += new System.EventHandler(this.Policy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView VIEW;
    }
}