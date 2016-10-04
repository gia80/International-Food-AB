namespace ConsoleApplication1
{
    partial class New
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
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDiscription = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDiscription
            // 
            this.txtDiscription.Location = new System.Drawing.Point(191, 40);
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(151, 36);
            this.txtDiscription.TabIndex = 0;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(191, 110);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(151, 35);
            this.txtCategory.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(191, 186);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 34);
            this.txtName.TabIndex = 2;
            // 
            // lblDiscription
            // 
            this.lblDiscription.AutoSize = true;
            this.lblDiscription.Location = new System.Drawing.Point(79, 59);
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(74, 17);
            this.lblDiscription.TabIndex = 3;
            this.lblDiscription.Text = "Discription";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(79, 123);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(79, 203);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(82, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 345);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblDiscription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtDiscription);
            this.Name = "New";
            this.Text = "New";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDiscription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;



    }
}