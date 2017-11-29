namespace tiny_card
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblCard1 = new System.Windows.Forms.Label();
            this.lblCard2 = new System.Windows.Forms.Label();
            this.lblCard3 = new System.Windows.Forms.Label();
            this.lblCard4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtStage = new System.Windows.Forms.TextBox();
            this.picBox4 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-140, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "tinycards";
            // 
            // lblCard1
            // 
            this.lblCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCard1.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Bold);
            this.lblCard1.Location = new System.Drawing.Point(28, 12);
            this.lblCard1.Name = "lblCard1";
            this.lblCard1.Size = new System.Drawing.Size(152, 167);
            this.lblCard1.TabIndex = 1;
            this.lblCard1.Text = "1";
            this.lblCard1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCard2
            // 
            this.lblCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCard2.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Bold);
            this.lblCard2.Location = new System.Drawing.Point(203, 12);
            this.lblCard2.Name = "lblCard2";
            this.lblCard2.Size = new System.Drawing.Size(152, 167);
            this.lblCard2.TabIndex = 1;
            this.lblCard2.Text = "2";
            this.lblCard2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCard3
            // 
            this.lblCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCard3.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Bold);
            this.lblCard3.Location = new System.Drawing.Point(28, 238);
            this.lblCard3.Name = "lblCard3";
            this.lblCard3.Size = new System.Drawing.Size(152, 167);
            this.lblCard3.TabIndex = 1;
            this.lblCard3.Text = "3";
            this.lblCard3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCard4
            // 
            this.lblCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCard4.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Bold);
            this.lblCard4.Location = new System.Drawing.Point(203, 238);
            this.lblCard4.Name = "lblCard4";
            this.lblCard4.Size = new System.Drawing.Size(152, 167);
            this.lblCard4.TabIndex = 1;
            this.lblCard4.Text = "4";
            this.lblCard4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(28, 439);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(280, 439);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtStage
            // 
            this.txtStage.Location = new System.Drawing.Point(171, 437);
            this.txtStage.Name = "txtStage";
            this.txtStage.Size = new System.Drawing.Size(38, 25);
            this.txtStage.TabIndex = 4;
            this.txtStage.Text = "0";
            this.txtStage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBox4
            // 
            this.picBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox4.Image = ((System.Drawing.Image)(resources.GetObject("picBox4.Image")));
            this.picBox4.InitialImage = global::tiny_card.Properties.Resources.card_back;
            this.picBox4.Location = new System.Drawing.Point(203, 238);
            this.picBox4.Name = "picBox4";
            this.picBox4.Size = new System.Drawing.Size(152, 167);
            this.picBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox4.TabIndex = 2;
            this.picBox4.TabStop = false;
            this.picBox4.Click += new System.EventHandler(this.picBox4_Click);
            // 
            // picBox2
            // 
            this.picBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox2.Image = ((System.Drawing.Image)(resources.GetObject("picBox2.Image")));
            this.picBox2.InitialImage = global::tiny_card.Properties.Resources.card_back;
            this.picBox2.Location = new System.Drawing.Point(203, 12);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(152, 167);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 2;
            this.picBox2.TabStop = false;
            this.picBox2.Click += new System.EventHandler(this.picBox2_Click);
            // 
            // picBox3
            // 
            this.picBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox3.Image = ((System.Drawing.Image)(resources.GetObject("picBox3.Image")));
            this.picBox3.InitialImage = global::tiny_card.Properties.Resources.card_back;
            this.picBox3.Location = new System.Drawing.Point(28, 238);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(152, 167);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox3.TabIndex = 2;
            this.picBox3.TabStop = false;
            this.picBox3.Click += new System.EventHandler(this.picBox3_Click);
            // 
            // picBox1
            // 
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox1.Image = ((System.Drawing.Image)(resources.GetObject("picBox1.Image")));
            this.picBox1.InitialImage = global::tiny_card.Properties.Resources.card_back;
            this.picBox1.Location = new System.Drawing.Point(28, 12);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(152, 167);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 2;
            this.picBox1.TabStop = false;
            this.picBox1.Click += new System.EventHandler(this.picBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(379, 474);
            this.Controls.Add(this.txtStage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picBox4);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.lblCard4);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.lblCard3);
            this.Controls.Add(this.lblCard2);
            this.Controls.Add(this.lblCard1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "mn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCard1;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Label lblCard2;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Label lblCard3;
        private System.Windows.Forms.Label lblCard4;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.PictureBox picBox4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtStage;
    }
}

