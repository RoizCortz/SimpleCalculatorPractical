namespace SimpleCalculator
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
            this.LeftCal = new System.Windows.Forms.RichTextBox();
            this.Operation = new System.Windows.Forms.ComboBox();
            this.RightCal = new System.Windows.Forms.RichTextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Calculated = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.justlabel = new System.Windows.Forms.Label();
            this.MsgBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LeftCal
            // 
            this.LeftCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftCal.Location = new System.Drawing.Point(12, 32);
            this.LeftCal.Multiline = false;
            this.LeftCal.Name = "LeftCal";
            this.LeftCal.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LeftCal.Size = new System.Drawing.Size(193, 52);
            this.LeftCal.TabIndex = 0;
            this.LeftCal.Text = "";
            // 
            // Operation
            // 
            this.Operation.FormattingEnabled = true;
            this.Operation.Items.AddRange(new object[] {
            "Addition +",
            "Subtraction -",
            "Multiplication *",
            "Division /"});
            this.Operation.Location = new System.Drawing.Point(211, 47);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(70, 21);
            this.Operation.TabIndex = 1;
            // 
            // RightCal
            // 
            this.RightCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightCal.Location = new System.Drawing.Point(287, 32);
            this.RightCal.Multiline = false;
            this.RightCal.Name = "RightCal";
            this.RightCal.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RightCal.Size = new System.Drawing.Size(186, 52);
            this.RightCal.TabIndex = 2;
            this.RightCal.Text = "";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(376, 135);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(97, 33);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(376, 102);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(97, 33);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Calculated
            // 
            this.Calculated.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculated.Location = new System.Drawing.Point(215, 118);
            this.Calculated.Name = "Calculated";
            this.Calculated.ReadOnly = true;
            this.Calculated.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.Calculated.Size = new System.Drawing.Size(155, 49);
            this.Calculated.TabIndex = 5;
            this.Calculated.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Left Variable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Right Variable";
            // 
            // justlabel
            // 
            this.justlabel.AutoSize = true;
            this.justlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justlabel.Location = new System.Drawing.Point(212, 32);
            this.justlabel.Name = "justlabel";
            this.justlabel.Size = new System.Drawing.Size(68, 13);
            this.justlabel.TabIndex = 8;
            this.justlabel.Text = "Operations";
            // 
            // MsgBox
            // 
            this.MsgBox.AutoSize = true;
            this.MsgBox.Checked = true;
            this.MsgBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MsgBox.Location = new System.Drawing.Point(12, 118);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(127, 17);
            this.MsgBox.TabIndex = 9;
            this.MsgBox.Text = "Display Message Box";
            this.MsgBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Calculated Variables";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(485, 178);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.justlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculated);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.RightCal);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.LeftCal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox LeftCal;
        private System.Windows.Forms.ComboBox Operation;
        private System.Windows.Forms.RichTextBox RightCal;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.RichTextBox Calculated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label justlabel;
        private System.Windows.Forms.CheckBox MsgBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

