namespace Act2FormsWindowsApp
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
            label1 = new Label();
            txtEnteredLength = new TextBox();
            lblResult = new Label();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 119);
            label1.Name = "label1";
            label1.Size = new Size(295, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter length (in centimeters) >>>";
            // 
            // txtEnteredLength
            // 
            txtEnteredLength.Location = new Point(472, 119);
            txtEnteredLength.Multiline = true;
            txtEnteredLength.Name = "txtEnteredLength";
            txtEnteredLength.Size = new Size(164, 26);
            txtEnteredLength.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(239, 154);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 25);
            lblResult.TabIndex = 2;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(349, 189);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(102, 40);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "CONVERT";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConvert);
            Controls.Add(lblResult);
            Controls.Add(txtEnteredLength);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEnteredLength;
        private Label lblResult;
        private Button btnConvert;
    }
}
