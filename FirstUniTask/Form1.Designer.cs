
namespace FirstUniTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtSub4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSub3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSub2 = new System.Windows.Forms.TextBox();
            this.txtSub1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.totalSub = new System.Windows.Forms.Label();
            this.Percentage = new System.Windows.Forms.Label();
            this.PercentageAns = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPinsert = new System.Windows.Forms.Button();
            this.btnPSearch = new System.Windows.Forms.Button();
            this.btnPDelete = new System.Windows.Forms.Button();
            this.btnPUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roll No.";
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(80, 41);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(120, 23);
            this.txtRollNo.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 23);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(80, 323);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtSub4
            // 
            this.txtSub4.Location = new System.Drawing.Point(80, 186);
            this.txtSub4.Name = "txtSub4";
            this.txtSub4.Size = new System.Drawing.Size(120, 23);
            this.txtSub4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sub 4";
            // 
            // txtSub3
            // 
            this.txtSub3.Location = new System.Drawing.Point(80, 157);
            this.txtSub3.Name = "txtSub3";
            this.txtSub3.Size = new System.Drawing.Size(120, 23);
            this.txtSub3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sub 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sub 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sub 2";
            // 
            // txtSub2
            // 
            this.txtSub2.Location = new System.Drawing.Point(80, 128);
            this.txtSub2.Name = "txtSub2";
            this.txtSub2.Size = new System.Drawing.Size(120, 23);
            this.txtSub2.TabIndex = 9;
            // 
            // txtSub1
            // 
            this.txtSub1.Location = new System.Drawing.Point(80, 99);
            this.txtSub1.Name = "txtSub1";
            this.txtSub1.Size = new System.Drawing.Size(120, 23);
            this.txtSub1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total =";
            // 
            // totalSub
            // 
            this.totalSub.AutoSize = true;
            this.totalSub.Location = new System.Drawing.Point(80, 235);
            this.totalSub.Name = "totalSub";
            this.totalSub.Size = new System.Drawing.Size(0, 15);
            this.totalSub.TabIndex = 12;
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.Location = new System.Drawing.Point(25, 275);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(35, 15);
            this.Percentage.TabIndex = 13;
            this.Percentage.Text = "Per =";
            // 
            // PercentageAns
            // 
            this.PercentageAns.AutoSize = true;
            this.PercentageAns.Location = new System.Drawing.Point(80, 275);
            this.PercentageAns.Name = "PercentageAns";
            this.PercentageAns.Size = new System.Drawing.Size(0, 15);
            this.PercentageAns.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(248, 44);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(248, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(248, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(248, 131);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPinsert
            // 
            this.btnPinsert.Location = new System.Drawing.Point(248, 170);
            this.btnPinsert.Name = "btnPinsert";
            this.btnPinsert.Size = new System.Drawing.Size(75, 23);
            this.btnPinsert.TabIndex = 19;
            this.btnPinsert.Text = "P_Insert";
            this.btnPinsert.UseVisualStyleBackColor = true;
            this.btnPinsert.Click += new System.EventHandler(this.btnPinsert_Click);
            // 
            // btnPSearch
            // 
            this.btnPSearch.Location = new System.Drawing.Point(248, 199);
            this.btnPSearch.Name = "btnPSearch";
            this.btnPSearch.Size = new System.Drawing.Size(75, 23);
            this.btnPSearch.TabIndex = 20;
            this.btnPSearch.Text = "P_Search";
            this.btnPSearch.UseVisualStyleBackColor = true;
            this.btnPSearch.Click += new System.EventHandler(this.btnPSearch_Click);
            // 
            // btnPDelete
            // 
            this.btnPDelete.Location = new System.Drawing.Point(248, 228);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(75, 23);
            this.btnPDelete.TabIndex = 21;
            this.btnPDelete.Text = "P_Delete";
            this.btnPDelete.UseVisualStyleBackColor = true;
            this.btnPDelete.Click += new System.EventHandler(this.btnPDelete_Click);
            // 
            // btnPUpdate
            // 
            this.btnPUpdate.Location = new System.Drawing.Point(248, 257);
            this.btnPUpdate.Name = "btnPUpdate";
            this.btnPUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnPUpdate.TabIndex = 22;
            this.btnPUpdate.Text = "P_Update";
            this.btnPUpdate.UseVisualStyleBackColor = true;
            this.btnPUpdate.Click += new System.EventHandler(this.btnPUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 385);
            this.Controls.Add(this.btnPUpdate);
            this.Controls.Add(this.btnPDelete);
            this.Controls.Add(this.btnPSearch);
            this.Controls.Add(this.btnPinsert);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.PercentageAns);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.totalSub);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSub1);
            this.Controls.Add(this.txtSub2);
            this.Controls.Add(this.txtSub4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSub3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Students Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtSub4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSub3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSub2;
        private System.Windows.Forms.TextBox txtSub1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalSub;
        private System.Windows.Forms.Label Percentage;
        private System.Windows.Forms.Label PercentageAns;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPinsert;
        private System.Windows.Forms.Button btnPSearch;
        private System.Windows.Forms.Button btnPDelete;
        private System.Windows.Forms.Button btnPUpdate;
    }
}

