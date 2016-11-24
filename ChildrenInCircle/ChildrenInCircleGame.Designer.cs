namespace ChildrenInCircle
{
    partial class ChildrenInCircleGame
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
            this.TotalNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultButton = new System.Windows.Forms.Button();
            this.Numberofchildren = new System.Windows.Forms.NumericUpDown();
            this.Eliminationindex = new System.Windows.Forms.NumericUpDown();
            this.Results = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Numberofchildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eliminationindex)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalNumber
            // 
            this.TotalNumber.AutoSize = true;
            this.TotalNumber.Location = new System.Drawing.Point(31, 74);
            this.TotalNumber.Name = "TotalNumber";
            this.TotalNumber.Size = new System.Drawing.Size(290, 25);
            this.TotalNumber.TabIndex = 0;
            this.TotalNumber.Text = "Enter the Number of Children";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the Elimination Index";
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(271, 280);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(213, 45);
            this.ResultButton.TabIndex = 4;
            this.ResultButton.Text = "Find the Winner!";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // Numberofchildren
            // 
            this.Numberofchildren.Location = new System.Drawing.Point(585, 72);
            this.Numberofchildren.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Numberofchildren.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Numberofchildren.Name = "Numberofchildren";
            this.Numberofchildren.Size = new System.Drawing.Size(120, 31);
            this.Numberofchildren.TabIndex = 6;
            this.Numberofchildren.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Eliminationindex
            // 
            this.Eliminationindex.Location = new System.Drawing.Point(585, 152);
            this.Eliminationindex.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Eliminationindex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Eliminationindex.Name = "Eliminationindex";
            this.Eliminationindex.Size = new System.Drawing.Size(120, 31);
            this.Eliminationindex.TabIndex = 7;
            this.Eliminationindex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Results
            // 
            this.Results.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Results.Location = new System.Drawing.Point(36, 398);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(687, 96);
            this.Results.TabIndex = 8;
            this.Results.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(36, 398);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(687, 96);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // ChildrenInCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(764, 553);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.Eliminationindex);
            this.Controls.Add(this.Numberofchildren);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalNumber);
            this.Name = "ChildrenInCircle";
            this.Text = "ChildrenInCircle";
            ((System.ComponentModel.ISupportInitialize)(this.Numberofchildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eliminationindex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.NumericUpDown Numberofchildren;
        private System.Windows.Forms.NumericUpDown Eliminationindex;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox Results;
    }
}

