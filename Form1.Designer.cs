namespace EdgeDetectionFilterApp
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
            image1 = new PictureBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            btnSave = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 239);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "upload";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // image1
            // 
            image1.Location = new Point(12, 21);
            image1.Name = "image1";
            image1.Size = new Size(280, 182);
            image1.SizeMode = PictureBoxSizeMode.Zoom;
            image1.TabIndex = 1;
            image1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(331, 239);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Filter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(331, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(536, 239);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 281);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(12, 303);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(209, 151);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(239, 303);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "blurButton";
            button3.UseVisualStyleBackColor = true;
            //button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 466);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnSave);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(image1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox image1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button btnSave;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button3;
    }
}
