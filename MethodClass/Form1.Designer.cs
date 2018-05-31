namespace MethodClass
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxUniversity = new System.Windows.Forms.TextBox();
            this.txtBoxDeprtmnt = new System.Windows.Forms.TextBox();
            this.btnStoreData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(160, 42);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(100, 22);
            this.tBoxName.TabIndex = 1;
            this.tBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "University";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Department";
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(160, 81);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(100, 22);
            this.txtBoxAge.TabIndex = 5;
            // 
            // txtBoxUniversity
            // 
            this.txtBoxUniversity.Location = new System.Drawing.Point(160, 116);
            this.txtBoxUniversity.Name = "txtBoxUniversity";
            this.txtBoxUniversity.Size = new System.Drawing.Size(100, 22);
            this.txtBoxUniversity.TabIndex = 6;
            // 
            // txtBoxDeprtmnt
            // 
            this.txtBoxDeprtmnt.Location = new System.Drawing.Point(160, 150);
            this.txtBoxDeprtmnt.Name = "txtBoxDeprtmnt";
            this.txtBoxDeprtmnt.Size = new System.Drawing.Size(100, 22);
            this.txtBoxDeprtmnt.TabIndex = 7;
            // 
            // btnStoreData
            // 
            this.btnStoreData.Location = new System.Drawing.Point(106, 201);
            this.btnStoreData.Name = "btnStoreData";
            this.btnStoreData.Size = new System.Drawing.Size(104, 27);
            this.btnStoreData.TabIndex = 8;
            this.btnStoreData.Text = "Store Data";
            this.btnStoreData.UseVisualStyleBackColor = true;
            this.btnStoreData.Click += new System.EventHandler(this.btnStoreData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 292);
            this.Controls.Add(this.btnStoreData);
            this.Controls.Add(this.txtBoxDeprtmnt);
            this.Controls.Add(this.txtBoxUniversity);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox txtBoxUniversity;
        private System.Windows.Forms.TextBox txtBoxDeprtmnt;
        private System.Windows.Forms.Button btnStoreData;
    }
}

