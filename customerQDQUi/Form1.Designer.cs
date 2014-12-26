namespace customerQDQUi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.waitgroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameEntextBox = new System.Windows.Forms.TextBox();
            this.complainEntextBox = new System.Windows.Forms.TextBox();
            this.slNotextBox = new System.Windows.Forms.TextBox();
            this.nameDetextBox = new System.Windows.Forms.TextBox();
            this.complainDetextBox = new System.Windows.Forms.TextBox();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.complainlistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.waitgroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enqueueButton);
            this.groupBox1.Controls.Add(this.complainEntextBox);
            this.groupBox1.Controls.Add(this.nameEntextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enqueue Customer";
            // 
            // waitgroupBox
            // 
            this.waitgroupBox.Controls.Add(this.dequeueButton);
            this.waitgroupBox.Controls.Add(this.complainDetextBox);
            this.waitgroupBox.Controls.Add(this.nameDetextBox);
            this.waitgroupBox.Controls.Add(this.slNotextBox);
            this.waitgroupBox.Controls.Add(this.label5);
            this.waitgroupBox.Controls.Add(this.label4);
            this.waitgroupBox.Controls.Add(this.label3);
            this.waitgroupBox.Location = new System.Drawing.Point(360, 27);
            this.waitgroupBox.Name = "waitgroupBox";
            this.waitgroupBox.Size = new System.Drawing.Size(431, 118);
            this.waitgroupBox.TabIndex = 1;
            this.waitgroupBox.TabStop = false;
            this.waitgroupBox.Text = "De-Queue Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Complain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "SL NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Complain";
            // 
            // nameEntextBox
            // 
            this.nameEntextBox.Location = new System.Drawing.Point(66, 25);
            this.nameEntextBox.Name = "nameEntextBox";
            this.nameEntextBox.Size = new System.Drawing.Size(100, 20);
            this.nameEntextBox.TabIndex = 2;
            // 
            // complainEntextBox
            // 
            this.complainEntextBox.Location = new System.Drawing.Point(66, 68);
            this.complainEntextBox.Name = "complainEntextBox";
            this.complainEntextBox.Size = new System.Drawing.Size(193, 20);
            this.complainEntextBox.TabIndex = 3;
            // 
            // slNotextBox
            // 
            this.slNotextBox.Location = new System.Drawing.Point(78, 25);
            this.slNotextBox.Name = "slNotextBox";
            this.slNotextBox.Size = new System.Drawing.Size(163, 20);
            this.slNotextBox.TabIndex = 4;
            // 
            // nameDetextBox
            // 
            this.nameDetextBox.Location = new System.Drawing.Point(78, 51);
            this.nameDetextBox.Name = "nameDetextBox";
            this.nameDetextBox.Size = new System.Drawing.Size(163, 20);
            this.nameDetextBox.TabIndex = 5;
            // 
            // complainDetextBox
            // 
            this.complainDetextBox.Location = new System.Drawing.Point(78, 77);
            this.complainDetextBox.Name = "complainDetextBox";
            this.complainDetextBox.Size = new System.Drawing.Size(248, 20);
            this.complainDetextBox.TabIndex = 6;
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(80, 116);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 4;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(323, 25);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 7;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.complainlistView);
            this.groupBox3.Location = new System.Drawing.Point(38, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(730, 133);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Waiting";
            // 
            // complainlistView
            // 
            this.complainlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.complainlistView.Location = new System.Drawing.Point(6, 19);
            this.complainlistView.Name = "complainlistView";
            this.complainlistView.Size = new System.Drawing.Size(705, 97);
            this.complainlistView.TabIndex = 0;
            this.complainlistView.UseCompatibleStateImageBehavior = false;
            this.complainlistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Complain";
            this.columnHeader3.Width = 140;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 399);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.waitgroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.waitgroupBox.ResumeLayout(false);
            this.waitgroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.TextBox complainEntextBox;
        private System.Windows.Forms.TextBox nameEntextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox waitgroupBox;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.TextBox complainDetextBox;
        private System.Windows.Forms.TextBox nameDetextBox;
        private System.Windows.Forms.TextBox slNotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView complainlistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

