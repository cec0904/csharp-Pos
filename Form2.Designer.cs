namespace Pos
{
    partial class Form2
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
            this.btnTable1 = new System.Windows.Forms.Button();
            this.btnTable2 = new System.Windows.Forms.Button();
            this.btnTable3 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.table1ListBox = new System.Windows.Forms.ListBox();
            this.table2ListBox = new System.Windows.Forms.ListBox();
            this.table3ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTable1
            // 
            this.btnTable1.Location = new System.Drawing.Point(43, 49);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(168, 120);
            this.btnTable1.TabIndex = 0;
            this.btnTable1.Text = "1번 테이블";
            this.btnTable1.UseVisualStyleBackColor = true;
            this.btnTable1.Click += new System.EventHandler(this.btnTable1_Click);
            // 
            // btnTable2
            // 
            this.btnTable2.Location = new System.Drawing.Point(300, 49);
            this.btnTable2.Name = "btnTable2";
            this.btnTable2.Size = new System.Drawing.Size(168, 120);
            this.btnTable2.TabIndex = 1;
            this.btnTable2.Text = "2번 테이블";
            this.btnTable2.UseVisualStyleBackColor = true;
            this.btnTable2.Click += new System.EventHandler(this.btnTable2_Click);
            // 
            // btnTable3
            // 
            this.btnTable3.Location = new System.Drawing.Point(557, 49);
            this.btnTable3.Name = "btnTable3";
            this.btnTable3.Size = new System.Drawing.Size(168, 120);
            this.btnTable3.TabIndex = 2;
            this.btnTable3.Text = "3번 테이블";
            this.btnTable3.UseVisualStyleBackColor = true;
            this.btnTable3.Click += new System.EventHandler(this.btnTable3_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(43, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "돌아가기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // table1ListBox
            // 
            this.table1ListBox.FormattingEnabled = true;
            this.table1ListBox.ItemHeight = 15;
            this.table1ListBox.Location = new System.Drawing.Point(43, 175);
            this.table1ListBox.Name = "table1ListBox";
            this.table1ListBox.Size = new System.Drawing.Size(168, 64);
            this.table1ListBox.TabIndex = 4;
            this.table1ListBox.SelectedIndexChanged += new System.EventHandler(this.table1ListBox_SelectedIndexChanged);
            // 
            // table2ListBox
            // 
            this.table2ListBox.FormattingEnabled = true;
            this.table2ListBox.ItemHeight = 15;
            this.table2ListBox.Location = new System.Drawing.Point(300, 175);
            this.table2ListBox.Name = "table2ListBox";
            this.table2ListBox.Size = new System.Drawing.Size(168, 64);
            this.table2ListBox.TabIndex = 5;
            // 
            // table3ListBox
            // 
            this.table3ListBox.FormattingEnabled = true;
            this.table3ListBox.ItemHeight = 15;
            this.table3ListBox.Location = new System.Drawing.Point(557, 175);
            this.table3ListBox.Name = "table3ListBox";
            this.table3ListBox.Size = new System.Drawing.Size(168, 64);
            this.table3ListBox.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.table3ListBox);
            this.Controls.Add(this.table2ListBox);
            this.Controls.Add(this.table1ListBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTable3);
            this.Controls.Add(this.btnTable2);
            this.Controls.Add(this.btnTable1);
            this.Name = "Form2";
            this.Text = "영업중";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTable1;
        private System.Windows.Forms.Button btnTable2;
        private System.Windows.Forms.Button btnTable3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox table1ListBox;
        private System.Windows.Forms.ListBox table2ListBox;
        private System.Windows.Forms.ListBox table3ListBox;
    }
}