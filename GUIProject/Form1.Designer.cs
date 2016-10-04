namespace GUIProject
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReceptNamn = new System.Windows.Forms.Label();
            this.comBox = new System.Windows.Forms.ComboBox();
            this.txtRecept = new System.Windows.Forms.TextBox();
            this.listRecept = new System.Windows.Forms.ListBox();
            this.btRemove = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Search";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(205, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 40);
            this.label3.TabIndex = 44;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 329);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(176, 22);
            this.txtSearch.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(205, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 290);
            this.label2.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 2);
            this.label1.TabIndex = 41;
            // 
            // lblReceptNamn
            // 
            this.lblReceptNamn.AutoSize = true;
            this.lblReceptNamn.Location = new System.Drawing.Point(213, 31);
            this.lblReceptNamn.Name = "lblReceptNamn";
            this.lblReceptNamn.Size = new System.Drawing.Size(53, 17);
            this.lblReceptNamn.TabIndex = 40;
            this.lblReceptNamn.Text = "Recept";
            // 
            // comBox
            // 
            this.comBox.FormattingEnabled = true;
            this.comBox.Location = new System.Drawing.Point(14, 16);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(176, 24);
            this.comBox.TabIndex = 39;
            this.comBox.SelectedIndexChanged += new System.EventHandler(this.comBox_SelectedIndexChanged);
            // 
            // txtRecept
            // 
            this.txtRecept.Location = new System.Drawing.Point(216, 52);
            this.txtRecept.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecept.Multiline = true;
            this.txtRecept.Name = "txtRecept";
            this.txtRecept.Size = new System.Drawing.Size(396, 244);
            this.txtRecept.TabIndex = 38;
            // 
            // listRecept
            // 
            this.listRecept.FormattingEnabled = true;
            this.listRecept.ItemHeight = 16;
            this.listRecept.Location = new System.Drawing.Point(13, 52);
            this.listRecept.Name = "listRecept";
            this.listRecept.Size = new System.Drawing.Size(177, 244);
            this.listRecept.TabIndex = 37;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(485, 318);
            this.btRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(127, 33);
            this.btRemove.TabIndex = 36;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(351, 318);
            this.btSave.Margin = new System.Windows.Forms.Padding(4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(127, 33);
            this.btSave.TabIndex = 35;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(216, 318);
            this.btNew.Margin = new System.Windows.Forms.Padding(4);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(127, 33);
            this.btNew.TabIndex = 34;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 369);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReceptNamn);
            this.Controls.Add(this.comBox);
            this.Controls.Add(this.txtRecept);
            this.Controls.Add(this.listRecept);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btNew);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReceptNamn;
        private System.Windows.Forms.ComboBox comBox;
        private System.Windows.Forms.TextBox txtRecept;
        private System.Windows.Forms.ListBox listRecept;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btNew;
    }
}

