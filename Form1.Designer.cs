namespace Final_Project
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
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            name = new TextBox();
            WeightTB = new TextBox();
            last_name = new TextBox();
            HeightTB = new TextBox();
            age = new TextBox();
            groupBox1 = new GroupBox();
            label13 = new Label();
            BMILabel = new Label();
            scrip = new Label();
            label12 = new Label();
            label10 = new Label();
            LevelLabel = new Label();
            DisplayPicture = new PictureBox();
            label6 = new Label();
            button3 = new Button();
            label7 = new Label();
            gender = new ComboBox();
            button1 = new Button();
            dataView = new DataGridView();
            n1 = new DataGridViewTextBoxColumn();
            n2 = new DataGridViewTextBoxColumn();
            n3 = new DataGridViewTextBoxColumn();
            n4 = new DataGridViewTextBoxColumn();
            n5 = new DataGridViewTextBoxColumn();
            n6 = new DataGridViewTextBoxColumn();
            n7 = new DataGridViewTextBoxColumn();
            n8 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(556, 451);
            button2.Name = "button2";
            button2.Size = new Size(84, 37);
            button2.TabIndex = 1;
            button2.Text = "คำนวณ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 122);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 2;
            label1.Text = "ชื่อ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 161);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "นามสกุล";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(438, 320);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 4;
            label3.Text = "น้ำหนัก/กิโลกรัม";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 261);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 5;
            label4.Text = "อายุ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(438, 376);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 6;
            label5.Text = "ส่วนสูง/เซนติเมตร";
            // 
            // name
            // 
            name.Location = new Point(526, 119);
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 7;
            // 
            // WeightTB
            // 
            WeightTB.Location = new Point(526, 317);
            WeightTB.Name = "WeightTB";
            WeightTB.Size = new Size(100, 23);
            WeightTB.TabIndex = 8;
            // 
            // last_name
            // 
            last_name.Location = new Point(526, 161);
            last_name.Name = "last_name";
            last_name.Size = new Size(100, 23);
            last_name.TabIndex = 9;
            // 
            // HeightTB
            // 
            HeightTB.Location = new Point(526, 372);
            HeightTB.Name = "HeightTB";
            HeightTB.Size = new Size(100, 23);
            HeightTB.TabIndex = 10;
            // 
            // age
            // 
            age.Location = new Point(526, 261);
            age.Name = "age";
            age.Size = new Size(100, 23);
            age.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(BMILabel);
            groupBox1.Controls.Add(scrip);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(LevelLabel);
            groupBox1.Controls.Add(DisplayPicture);
            groupBox1.Location = new Point(15, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 453);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "แสดงค่า";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Leelawadee UI", 10F);
            label13.Location = new Point(139, 186);
            label13.Name = "label13";
            label13.Size = new Size(34, 19);
            label13.TabIndex = 8;
            label13.Text = "BMI";
            // 
            // BMILabel
            // 
            BMILabel.AutoSize = true;
            BMILabel.Font = new Font("Leelawadee UI", 10F);
            BMILabel.Location = new Point(209, 186);
            BMILabel.Name = "BMILabel";
            BMILabel.Size = new Size(34, 19);
            BMILabel.TabIndex = 8;
            BMILabel.Text = "BMI";
            // 
            // scrip
            // 
            scrip.AutoSize = true;
            scrip.Location = new Point(6, 296);
            scrip.Name = "scrip";
            scrip.Size = new Size(16, 15);
            scrip.TabIndex = 7;
            scrip.Text = "...";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Leelawadee UI", 15F);
            label12.Location = new Point(6, 257);
            label12.Name = "label12";
            label12.Size = new Size(84, 28);
            label12.TabIndex = 4;
            label12.Text = "คำอธิบาย";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Leelawadee UI", 15F);
            label10.Location = new Point(113, 215);
            label10.Name = "label10";
            label10.Size = new Size(60, 28);
            label10.TabIndex = 3;
            label10.Text = "เกณฑ์";
            // 
            // LevelLabel
            // 
            LevelLabel.AutoSize = true;
            LevelLabel.Font = new Font("Leelawadee UI", 15F);
            LevelLabel.Location = new Point(179, 215);
            LevelLabel.Name = "LevelLabel";
            LevelLabel.Size = new Size(28, 28);
            LevelLabel.TabIndex = 3;
            LevelLabel.Text = "....";
            // 
            // DisplayPicture
            // 
            DisplayPicture.Location = new Point(139, 22);
            DisplayPicture.Name = "DisplayPicture";
            DisplayPicture.Size = new Size(148, 152);
            DisplayPicture.SizeMode = PictureBoxSizeMode.Zoom;
            DisplayPicture.TabIndex = 0;
            DisplayPicture.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Leelawadee UI", 35F);
            label6.Location = new Point(224, 9);
            label6.Name = "label6";
            label6.Size = new Size(309, 62);
            label6.TabIndex = 13;
            label6.Text = "คํานวณค่า BMI";
            // 
            // button3
            // 
            button3.Location = new Point(427, 452);
            button3.Name = "button3";
            button3.Size = new Size(84, 36);
            button3.TabIndex = 14;
            button3.Text = "ล้างข้อมูล";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(442, 220);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 15;
            label7.Text = "เพศ";
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "ชาย", "หญิง" });
            gender.Location = new Point(526, 212);
            gender.Name = "gender";
            gender.Size = new Size(100, 23);
            gender.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(1031, 514);
            button1.Name = "button1";
            button1.Size = new Size(84, 36);
            button1.TabIndex = 0;
            button1.Text = "บันทึก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataView
            // 
            dataView.BackgroundColor = Color.Snow;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Columns.AddRange(new DataGridViewColumn[] { n1, n2, n3, n4, n5, n6, n7, n8 });
            dataView.Location = new Point(689, 97);
            dataView.Name = "dataView";
            dataView.Size = new Size(824, 379);
            dataView.TabIndex = 17;
            // 
            // n1
            // 
            n1.HeaderText = "ชื่อ";
            n1.Name = "n1";
            // 
            // n2
            // 
            n2.HeaderText = "นามสกุล";
            n2.Name = "n2";
            // 
            // n3
            // 
            n3.HeaderText = "เพศ";
            n3.Name = "n3";
            // 
            // n4
            // 
            n4.HeaderText = "อายุ";
            n4.Name = "n4";
            // 
            // n5
            // 
            n5.HeaderText = "น้ำหนัก";
            n5.Name = "n5";
            // 
            // n6
            // 
            n6.HeaderText = "ส่วนสูง";
            n6.Name = "n6";
            // 
            // n7
            // 
            n7.HeaderText = "ค่าBMI";
            n7.Name = "n7";
            // 
            // n8
            // 
            n8.HeaderText = "เกณฑ์";
            n8.Name = "n8";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Leelawadee UI", 20F);
            label8.Location = new Point(689, 57);
            label8.Name = "label8";
            label8.Size = new Size(201, 37);
            label8.TabIndex = 18;
            label8.Text = "ข้อมูลการแสดงผล";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1525, 651);
            Controls.Add(label8);
            Controls.Add(dataView);
            Controls.Add(gender);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(age);
            Controls.Add(HeightTB);
            Controls.Add(last_name);
            Controls.Add(WeightTB);
            Controls.Add(name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox name;
        private TextBox WeightTB;
        private TextBox last_name;
        private TextBox HeightTB;
        private TextBox age;
        private GroupBox groupBox1;
        private Label label6;
        private Button button3;
        private Label label7;
        private ComboBox gender;
        private PictureBox DisplayPicture;
        private Button button1;
        private DataGridView dataView;
        private Label label12;
        private Label LevelLabel;
        private Label BMILabel;
        private Label scrip;
        private Label label13;
        private Label label10;
        private Label label8;
        private DataGridViewTextBoxColumn n1;
        private DataGridViewTextBoxColumn n2;
        private DataGridViewTextBoxColumn n3;
        private DataGridViewTextBoxColumn n4;
        private DataGridViewTextBoxColumn n5;
        private DataGridViewTextBoxColumn n6;
        private DataGridViewTextBoxColumn n7;
        private DataGridViewTextBoxColumn n8;
    }
}
