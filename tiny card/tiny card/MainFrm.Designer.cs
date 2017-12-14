namespace tiny_card
{
    partial class MainFrm
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
            this.cmbAlbum = new System.Windows.Forms.ComboBox();
            this.btnHoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAlbum
            // 
            this.cmbAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlbum.DropDownWidth = 400;
            this.cmbAlbum.FormattingEnabled = true;
            this.cmbAlbum.Items.AddRange(new object[] {
            "animal",
            "flower",
            "job"});
            this.cmbAlbum.Location = new System.Drawing.Point(12, 12);
            this.cmbAlbum.Name = "cmbAlbum";
            this.cmbAlbum.Size = new System.Drawing.Size(273, 21);
            this.cmbAlbum.TabIndex = 0;
            this.cmbAlbum.SelectedIndexChanged += new System.EventHandler(this.cmbAlbum_SelectedIndexChanged);
            // 
            // btnHoc
            // 
            this.btnHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoc.Location = new System.Drawing.Point(64, 140);
            this.btnHoc.Name = "btnHoc";
            this.btnHoc.Size = new System.Drawing.Size(169, 47);
            this.btnHoc.TabIndex = 1;
            this.btnHoc.Text = "Học";
            this.btnHoc.UseVisualStyleBackColor = true;
            this.btnHoc.Click += new System.EventHandler(this.btnHoc_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 265);
            this.Controls.Add(this.btnHoc);
            this.Controls.Add(this.cmbAlbum);
            this.Name = "MainFrm";
            this.Text = "MainFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAlbum;
        private System.Windows.Forms.Button btnHoc;
    }
}