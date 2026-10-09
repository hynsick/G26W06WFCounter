namespace G26W06WFCounter
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
            button1 = new Button();
            labelCount = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(82, 434);
            button1.Name = "button1";
            button1.Size = new Size(628, 79);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.BackColor = SystemColors.Info;
            labelCount.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            labelCount.Location = new Point(211, 202);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(327, 128);
            labelCount.TabIndex = 2;
            labelCount.Text = "label1";
            labelCount.TextAlign = ContentAlignment.MiddleCenter;
            labelCount.Click += labelCount_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 621);
            Controls.Add(labelCount);
            Controls.Add(button1);
            Name = "Form1";
            Text = "카운터";
            Load += Form1_Load;
            Click += OnAdd;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label labelCount;
    }
}
