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
            this.label4.Location = new System.Drawing.Point(10, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Search";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(154, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 32);
            this.label3.TabIndex = 44;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 267);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(133, 20);
            this.txtSearch.TabIndex = 43;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(154, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 236);
            this.label2.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(10, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 2);
            this.label1.TabIndex = 41;
            // 
            // lblReceptNamn
            // 
            this.lblReceptNamn.AutoSize = true;
            this.lblReceptNamn.Location = new System.Drawing.Point(160, 25);
            this.lblReceptNamn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceptNamn.Name = "lblReceptNamn";
            this.lblReceptNamn.Size = new System.Drawing.Size(42, 13);
            this.lblReceptNamn.TabIndex = 40;
            this.lblReceptNamn.Text = "Recept";
            // 
            // comBox
            // 
            this.comBox.FormattingEnabled = true;
            this.comBox.Location = new System.Drawing.Point(10, 13);
            this.comBox.Margin = new System.Windows.Forms.Padding(2);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(133, 21);
            this.comBox.TabIndex = 39;
            this.comBox.SelectedIndexChanged += new System.EventHandler(this.comBox_SelectedIndexChanged);
            // 
            // txtRecept
            // 
            this.txtRecept.Location = new System.Drawing.Point(162, 42);
            this.txtRecept.Multiline = true;
            this.txtRecept.Name = "txtRecept";
            this.txtRecept.Size = new System.Drawing.Size(298, 199);
            this.txtRecept.TabIndex = 38;
            // 
            // listRecept
            // 
            this.listRecept.FormattingEnabled = true;
            this.listRecept.Location = new System.Drawing.Point(10, 42);
            this.listRecept.Margin = new System.Windows.Forms.Padding(2);
            this.listRecept.Name = "listRecept";
            this.listRecept.Size = new System.Drawing.Size(134, 199);
            this.listRecept.TabIndex = 37;
            this.listRecept.SelectedIndexChanged += new System.EventHandler(this.listRecept_SelectedIndexChanged);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(364, 258);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(95, 27);
            this.btRemove.TabIndex = 36;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(263, 258);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(95, 27);
            this.btSave.TabIndex = 35;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(162, 258);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(95, 27);
            this.btNew.TabIndex = 34;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 300);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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

