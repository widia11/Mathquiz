namespace MathQuiz
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            plusLeftLabel = new Label();
            label3 = new Label();
            plusRightLabel = new Label();
            label5 = new Label();
            jumlah = new NumericUpDown();
            minusLeftLabel = new Label();
            timesLeftLabel = new Label();
            dividedLeftLabel = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            minusRightLabel = new Label();
            timesRightLabel = new Label();
            dividedRightLabel = new Label();
            perbedaan = new NumericUpDown();
            produk = new NumericUpDown();
            quotient = new NumericUpDown();
            label4 = new Label();
            label11 = new Label();
            label14 = new Label();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)jumlah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)perbedaan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(167, 10);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 1;
            label2.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusLeftLabel.Location = new Point(50, 75);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(130, 75);
            label3.Name = "label3";
            label3.Size = new Size(60, 50);
            label3.TabIndex = 3;
            label3.Text = "+";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusRightLabel.Location = new Point(206, 79);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 4;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            plusRightLabel.Click += plusRightLabel_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(272, 75);
            label5.Name = "label5";
            label5.Size = new Size(60, 50);
            label5.TabIndex = 5;
            label5.Text = "=";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // jumlah
            // 
            jumlah.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            jumlah.Location = new Point(349, 86);
            jumlah.Name = "jumlah";
            jumlah.Size = new Size(100, 39);
            jumlah.TabIndex = 1;
            jumlah.ValueChanged += jumlah_ValueChanged;
            jumlah.Click += answer_Enter;
            jumlah.Enter += answer_Enter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minusLeftLabel.Location = new Point(50, 125);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(60, 50);
            minusLeftLabel.TabIndex = 7;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            minusLeftLabel.Click += label4_Click;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timesLeftLabel.Location = new Point(50, 175);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 50);
            timesLeftLabel.TabIndex = 8;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dividedLeftLabel.Location = new Point(50, 225);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 50);
            dividedLeftLabel.TabIndex = 9;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            dividedLeftLabel.Click += label7_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(130, 125);
            label8.Name = "label8";
            label8.Size = new Size(60, 50);
            label8.TabIndex = 10;
            label8.Text = "-";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(130, 175);
            label9.Name = "label9";
            label9.Size = new Size(60, 50);
            label9.TabIndex = 11;
            label9.Text = "×";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(130, 225);
            label10.Name = "label10";
            label10.Size = new Size(60, 50);
            label10.TabIndex = 12;
            label10.Text = "÷";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minusRightLabel.Location = new Point(206, 125);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(60, 50);
            minusRightLabel.TabIndex = 13;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timesRightLabel.Location = new Point(206, 175);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 50);
            timesRightLabel.TabIndex = 14;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dividedRightLabel.Location = new Point(206, 225);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(60, 50);
            dividedRightLabel.TabIndex = 15;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // perbedaan
            // 
            perbedaan.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            perbedaan.Location = new Point(349, 136);
            perbedaan.Name = "perbedaan";
            perbedaan.Size = new Size(100, 39);
            perbedaan.TabIndex = 2;
            perbedaan.ValueChanged += perbedaan_ValueChanged;
            perbedaan.Click += answer_Enter;
            perbedaan.Enter += answer_Enter;
            // 
            // produk
            // 
            produk.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            produk.Location = new Point(349, 182);
            produk.Name = "produk";
            produk.Size = new Size(100, 39);
            produk.TabIndex = 3;
            produk.Click += answer_Enter;
            produk.Enter += answer_Enter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            quotient.Location = new Point(349, 232);
            quotient.Name = "quotient";
            quotient.Size = new Size(100, 39);
            quotient.TabIndex = 4;
            quotient.Click += answer_Enter;
            quotient.Enter += answer_Enter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(272, 125);
            label4.Name = "label4";
            label4.Size = new Size(60, 50);
            label4.TabIndex = 22;
            label4.Text = "=";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(272, 175);
            label11.Name = "label11";
            label11.Size = new Size(60, 50);
            label11.TabIndex = 23;
            label11.Text = "=";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(272, 225);
            label14.Name = "label14";
            label14.Size = new Size(60, 50);
            label14.TabIndex = 24;
            label14.Text = "=";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location = new Point(167, 296);
            startButton.Name = "startButton";
            startButton.Size = new Size(140, 35);
            startButton.TabIndex = 0;
            startButton.Text = "Start The Quiz";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(272, 10);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 25;
            timeLabel.Click += timeLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(timeLabel);
            Controls.Add(startButton);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(quotient);
            Controls.Add(produk);
            Controls.Add(perbedaan);
            Controls.Add(dividedRightLabel);
            Controls.Add(timesRightLabel);
            Controls.Add(minusRightLabel);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dividedLeftLabel);
            Controls.Add(timesLeftLabel);
            Controls.Add(minusLeftLabel);
            Controls.Add(jumlah);
            Controls.Add(label5);
            Controls.Add(plusRightLabel);
            Controls.Add(label3);
            Controls.Add(plusLeftLabel);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Kuis Matematika";
            ((System.ComponentModel.ISupportInitialize)jumlah).EndInit();
            ((System.ComponentModel.ISupportInitialize)perbedaan).EndInit();
            ((System.ComponentModel.ISupportInitialize)produk).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label plusLeftLabel;
        private Label label3;
        private Label plusRightLabel;
        private Label label5;
        private NumericUpDown jumlah;
        private Label minusLeftLabel;
        private Label timesLeftLabel;
        private Label dividedLeftLabel;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label minusRightLabel;
        private Label timesRightLabel;
        private Label dividedRightLabel;
        private NumericUpDown perbedaan;
        private NumericUpDown produk;
        private NumericUpDown quotient;
        private Label label4;
        private Label label11;
        private Label label14;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
        private Label timeLabel;
    }
}