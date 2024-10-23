namespace Form_2024_Week_1_1
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
            radius_text = new TextBox();
            btn_Area_Calculate = new Button();
            btn_Perimeter_Calculate = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lbl_r = new Label();
            btn_Exit = new Button();
            lbl_area = new Label();
            lbl_perimeter = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // radius_text
            // 
            radius_text.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            radius_text.Location = new Point(257, 60);
            radius_text.Margin = new Padding(3, 4, 3, 4);
            radius_text.Multiline = true;
            radius_text.Name = "radius_text";
            radius_text.Size = new Size(182, 56);
            radius_text.TabIndex = 0;
            radius_text.TextChanged += radius_text_TextChanged;
            // 
            // btn_Area_Calculate
            // 
            btn_Area_Calculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Area_Calculate.Location = new Point(121, 176);
            btn_Area_Calculate.Margin = new Padding(3, 4, 3, 4);
            btn_Area_Calculate.Name = "btn_Area_Calculate";
            btn_Area_Calculate.Size = new Size(111, 76);
            btn_Area_Calculate.TabIndex = 1;
            btn_Area_Calculate.Text = "Calculate Area";
            btn_Area_Calculate.UseVisualStyleBackColor = true;
            btn_Area_Calculate.Click += btn_Area_Calculate_Click;
            // 
            // btn_Perimeter_Calculate
            // 
            btn_Perimeter_Calculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Perimeter_Calculate.Location = new Point(257, 176);
            btn_Perimeter_Calculate.Margin = new Padding(3, 4, 3, 4);
            btn_Perimeter_Calculate.Name = "btn_Perimeter_Calculate";
            btn_Perimeter_Calculate.Size = new Size(107, 76);
            btn_Perimeter_Calculate.TabIndex = 2;
            btn_Perimeter_Calculate.Text = "Calculate Perimeter";
            btn_Perimeter_Calculate.UseVisualStyleBackColor = true;
            btn_Perimeter_Calculate.Click += btn_Perimeter_Calculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(56, 64);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 3;
            label1.Text = "Please enter radius";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Custom_Icon_Design_Flatastic_6_Circle_512;
            pictureBox1.Location = new Point(549, 64);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lbl_r
            // 
            lbl_r.AutoSize = true;
            lbl_r.Location = new Point(627, 151);
            lbl_r.Name = "lbl_r";
            lbl_r.Size = new Size(24, 20);
            lbl_r.TabIndex = 5;
            lbl_r.Text = "r=";
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_Exit.Location = new Point(383, 176);
            btn_Exit.Margin = new Padding(3, 4, 3, 4);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(105, 76);
            btn_Exit.TabIndex = 6;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // lbl_area
            // 
            lbl_area.AutoSize = true;
            lbl_area.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_area.Location = new Point(142, 295);
            lbl_area.Name = "lbl_area";
            lbl_area.Size = new Size(0, 28);
            lbl_area.TabIndex = 7;
            // 
            // lbl_perimeter
            // 
            lbl_perimeter.AutoSize = true;
            lbl_perimeter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_perimeter.Location = new Point(279, 295);
            lbl_perimeter.Name = "lbl_perimeter";
            lbl_perimeter.Size = new Size(0, 28);
            lbl_perimeter.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 395);
            Controls.Add(lbl_perimeter);
            Controls.Add(lbl_area);
            Controls.Add(btn_Exit);
            Controls.Add(lbl_r);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btn_Perimeter_Calculate);
            Controls.Add(btn_Area_Calculate);
            Controls.Add(radius_text);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Calculate Area-Perimeter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox radius_text;
        private Button btn_Area_Calculate;
        private Button btn_Perimeter_Calculate;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lbl_r;
        private Button btn_Exit;
        private Label lbl_area;
        private Label lbl_perimeter;
    }
}
