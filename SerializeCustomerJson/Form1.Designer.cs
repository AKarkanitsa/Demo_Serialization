namespace SerializeCustomerJson
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
            this.deserializedTextBox = new System.Windows.Forms.TextBox();
            this.serializationTextBox = new System.Windows.Forms.TextBox();
            this.originalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.deserializedTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.serializationTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.originalTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 292);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // deserializedTextBox
            // 
            this.deserializedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deserializedTextBox.Location = new System.Drawing.Point(502, 29);
            this.deserializedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deserializedTextBox.Multiline = true;
            this.deserializedTextBox.Name = "deserializedTextBox";
            this.deserializedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.deserializedTextBox.Size = new System.Drawing.Size(241, 259);
            this.deserializedTextBox.TabIndex = 4;
            this.deserializedTextBox.WordWrap = false;
            // 
            // serializationTextBox
            // 
            this.serializationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serializationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serializationTextBox.Location = new System.Drawing.Point(253, 29);
            this.serializationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serializationTextBox.Multiline = true;
            this.serializationTextBox.Name = "serializationTextBox";
            this.serializationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.serializationTextBox.Size = new System.Drawing.Size(241, 259);
            this.serializationTextBox.TabIndex = 3;
            // 
            // originalTextBox
            // 
            this.originalTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalTextBox.Location = new System.Drawing.Point(4, 29);
            this.originalTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.originalTextBox.Multiline = true;
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.originalTextBox.Size = new System.Drawing.Size(241, 259);
            this.originalTextBox.TabIndex = 2;
            this.originalTextBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Serialization";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Deserialized Customer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 321);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "SerializeCustomerJson";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox deserializedTextBox;
        private System.Windows.Forms.TextBox serializationTextBox;
        private System.Windows.Forms.TextBox originalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

