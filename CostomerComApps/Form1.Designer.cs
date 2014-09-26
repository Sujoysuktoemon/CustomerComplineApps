namespace CostomerComApps
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.txtCustomerDequeueCompline = new System.Windows.Forms.TextBox();
            this.txtCustomerDequeueName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCustomerDequeueId = new System.Windows.Forms.TextBox();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.txtCustomerEnqueueCompline = new System.Windows.Forms.TextBox();
            this.txtCustomerEnqueueName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Compline";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // btnDequeue
            // 
            this.btnDequeue.Location = new System.Drawing.Point(183, 119);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(75, 23);
            this.btnDequeue.TabIndex = 7;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // txtCustomerDequeueCompline
            // 
            this.txtCustomerDequeueCompline.Location = new System.Drawing.Point(78, 93);
            this.txtCustomerDequeueCompline.Name = "txtCustomerDequeueCompline";
            this.txtCustomerDequeueCompline.Size = new System.Drawing.Size(210, 20);
            this.txtCustomerDequeueCompline.TabIndex = 6;
            // 
            // txtCustomerDequeueName
            // 
            this.txtCustomerDequeueName.Location = new System.Drawing.Point(78, 57);
            this.txtCustomerDequeueName.Name = "txtCustomerDequeueName";
            this.txtCustomerDequeueName.Size = new System.Drawing.Size(170, 20);
            this.txtCustomerDequeueName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnDequeue);
            this.groupBox3.Controls.Add(this.txtCustomerDequeueCompline);
            this.groupBox3.Controls.Add(this.txtCustomerDequeueName);
            this.groupBox3.Controls.Add(this.txtCustomerDequeueId);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(403, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 160);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dequeue Customer";
            // 
            // txtCustomerDequeueId
            // 
            this.txtCustomerDequeueId.Location = new System.Drawing.Point(77, 25);
            this.txtCustomerDequeueId.Name = "txtCustomerDequeueId";
            this.txtCustomerDequeueId.Size = new System.Drawing.Size(101, 20);
            this.txtCustomerDequeueId.TabIndex = 4;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "COMPLINE";
            this.columnHeader3.Width = 207;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NAME";
            this.columnHeader2.Width = 188;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(18, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(577, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 102;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(66, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 137);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Waiting Queue";
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Location = new System.Drawing.Point(207, 113);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(75, 23);
            this.btnEnqueue.TabIndex = 4;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = true;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // txtCustomerEnqueueCompline
            // 
            this.txtCustomerEnqueueCompline.Location = new System.Drawing.Point(82, 69);
            this.txtCustomerEnqueueCompline.Name = "txtCustomerEnqueueCompline";
            this.txtCustomerEnqueueCompline.Size = new System.Drawing.Size(228, 20);
            this.txtCustomerEnqueueCompline.TabIndex = 3;
            // 
            // txtCustomerEnqueueName
            // 
            this.txtCustomerEnqueueName.Location = new System.Drawing.Point(82, 32);
            this.txtCustomerEnqueueName.Name = "txtCustomerEnqueueName";
            this.txtCustomerEnqueueName.Size = new System.Drawing.Size(170, 20);
            this.txtCustomerEnqueueName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Compline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnqueue);
            this.groupBox1.Controls.Add(this.txtCustomerEnqueueCompline);
            this.groupBox1.Controls.Add(this.txtCustomerEnqueueName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(66, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enqueue Customer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 494);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.TextBox txtCustomerDequeueCompline;
        private System.Windows.Forms.TextBox txtCustomerDequeueName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCustomerDequeueId;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.TextBox txtCustomerEnqueueCompline;
        private System.Windows.Forms.TextBox txtCustomerEnqueueName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

