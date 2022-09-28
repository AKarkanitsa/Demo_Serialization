namespace SerializeDepartment
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serializationTextBox = new System.Windows.Forms.TextBox();
            this.originalTextBox = new System.Windows.Forms.TextBox();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.deserializedPictureBox = new System.Windows.Forms.PictureBox();
            this.deserializedTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deserializedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.serializationTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 237);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Serialization";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Deserialized Data";
            // 
            // serializationTextBox
            // 
            this.serializationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serializationTextBox.Location = new System.Drawing.Point(189, 23);
            this.serializationTextBox.Multiline = true;
            this.serializationTextBox.Name = "serializationTextBox";
            this.serializationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.serializationTextBox.Size = new System.Drawing.Size(180, 211);
            this.serializationTextBox.TabIndex = 1;
            this.serializationTextBox.WordWrap = false;
            // 
            // originalTextBox
            // 
            this.originalTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalTextBox.Location = new System.Drawing.Point(0, 0);
            this.originalTextBox.Multiline = true;
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.originalTextBox.Size = new System.Drawing.Size(180, 133);
            this.originalTextBox.TabIndex = 0;
            this.originalTextBox.WordWrap = false;
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalPictureBox.Location = new System.Drawing.Point(0, 0);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(180, 74);
            this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originalPictureBox.TabIndex = 3;
            this.originalPictureBox.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 23);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.originalPictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.originalTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(180, 211);
            this.splitContainer1.SplitterDistance = 74;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(375, 23);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.deserializedPictureBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.deserializedTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(182, 211);
            this.splitContainer2.SplitterDistance = 77;
            this.splitContainer2.TabIndex = 2;
            // 
            // deserializedPictureBox
            // 
            this.deserializedPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deserializedPictureBox.Location = new System.Drawing.Point(0, 0);
            this.deserializedPictureBox.Name = "deserializedPictureBox";
            this.deserializedPictureBox.Size = new System.Drawing.Size(182, 77);
            this.deserializedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deserializedPictureBox.TabIndex = 3;
            this.deserializedPictureBox.TabStop = false;
            // 
            // deserializedTextBox
            // 
            this.deserializedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deserializedTextBox.Location = new System.Drawing.Point(0, 0);
            this.deserializedTextBox.Multiline = true;
            this.deserializedTextBox.Name = "deserializedTextBox";
            this.deserializedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.deserializedTextBox.Size = new System.Drawing.Size(182, 130);
            this.deserializedTextBox.TabIndex = 0;
            this.deserializedTextBox.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "SerializeDepartment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deserializedPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox serializationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox deserializedPictureBox;
        private System.Windows.Forms.TextBox deserializedTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.TextBox originalTextBox;
    }
}

