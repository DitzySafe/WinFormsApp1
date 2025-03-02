namespace WinFormsApp1
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
            lblName = new Label();
            lblAge = new Label();
            lblBloodGroup = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtBloodGroup = new TextBox();
            btnSubmit = new Button();
            pbxDisplay = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxDisplay).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(66, 371);
            button1.Name = "button1";
            button1.Size = new Size(286, 57);
            button1.TabIndex = 0;
            button1.Text = "Click Me adi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(198, 32);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(198, 64);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(31, 15);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age:";
            lblAge.Click += label2_Click;
            // 
            // lblBloodGroup
            // 
            lblBloodGroup.AutoSize = true;
            lblBloodGroup.Location = new Point(198, 95);
            lblBloodGroup.Name = "lblBloodGroup";
            lblBloodGroup.Size = new Size(77, 15);
            lblBloodGroup.TabIndex = 3;
            lblBloodGroup.Text = "Blood Group:";
            lblBloodGroup.Click += label3_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(278, 24);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(278, 58);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 5;
            // 
            // txtBloodGroup
            // 
            txtBloodGroup.Location = new Point(278, 87);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.Size = new Size(100, 23);
            txtBloodGroup.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(433, 23);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(275, 87);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Generate Image";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // pbxDisplay
            // 
            pbxDisplay.Location = new Point(368, 150);
            pbxDisplay.Name = "pbxDisplay";
            pbxDisplay.Size = new Size(576, 278);
            pbxDisplay.TabIndex = 9;
            pbxDisplay.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 450);
            Controls.Add(pbxDisplay);
            Controls.Add(btnSubmit);
            Controls.Add(txtBloodGroup);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(lblBloodGroup);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbxDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblName;
        private Label lblAge;
        private Label lblBloodGroup;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtBloodGroup;
        private Button btnSubmit;
        private PictureBox pbxDisplay;
    }
}
