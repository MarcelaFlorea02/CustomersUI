namespace CustomersUI
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button_get = new System.Windows.Forms.Button();
            button_update = new System.Windows.Forms.Button();
            button_insert = new System.Windows.Forms.Button();
            button_delete = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(49, 50);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(871, 664);
            dataGridView1.TabIndex = 0;
            // 
            // button_get
            // 
            button_get.Location = new System.Drawing.Point(1039, 88);
            button_get.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            button_get.Name = "button_get";
            button_get.Size = new System.Drawing.Size(180, 56);
            button_get.TabIndex = 1;
            button_get.Text = "Get Data";
            button_get.UseVisualStyleBackColor = true;
            button_get.Click += button_get_Click;
            // 
            // button_update
            // 
            button_update.Location = new System.Drawing.Point(1039, 209);
            button_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            button_update.Name = "button_update";
            button_update.Size = new System.Drawing.Size(180, 58);
            button_update.TabIndex = 2;
            button_update.Text = "Update Data";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_insert
            // 
            button_insert.Location = new System.Drawing.Point(1039, 344);
            button_insert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            button_insert.Name = "button_insert";
            button_insert.Size = new System.Drawing.Size(180, 55);
            button_insert.TabIndex = 3;
            button_insert.Text = "Insert Data";
            button_insert.UseVisualStyleBackColor = true;
            button_insert.Click += button_insert_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new System.Drawing.Point(1039, 489);
            button_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            button_delete.Name = "button_delete";
            button_delete.Size = new System.Drawing.Size(180, 61);
            button_delete.TabIndex = 4;
            button_delete.Text = "Delete Data";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(1052, 595);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Hello";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1322, 775);
            Controls.Add(button1);
            Controls.Add(button_delete);
            Controls.Add(button_insert);
            Controls.Add(button_update);
            Controls.Add(button_get);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_get;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button1;
    }
}
