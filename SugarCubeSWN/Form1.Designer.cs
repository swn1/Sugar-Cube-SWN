namespace SugarCubeSWN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nCubesBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nAntsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nMaxTimeBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AverageField = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StdDevField = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.ProgressField = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nThreadsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of cubes to simulate";
            // 
            // nCubesBox
            // 
            this.nCubesBox.Location = new System.Drawing.Point(174, 16);
            this.nCubesBox.Name = "nCubesBox";
            this.nCubesBox.Size = new System.Drawing.Size(100, 20);
            this.nCubesBox.TabIndex = 1;
            this.nCubesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ants per cube";
            // 
            // nAntsBox
            // 
            this.nAntsBox.Location = new System.Drawing.Point(174, 41);
            this.nAntsBox.Name = "nAntsBox";
            this.nAntsBox.Size = new System.Drawing.Size(100, 20);
            this.nAntsBox.TabIndex = 3;
            this.nAntsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maximum steps";
            // 
            // nMaxTimeBox
            // 
            this.nMaxTimeBox.Location = new System.Drawing.Point(174, 65);
            this.nMaxTimeBox.Name = "nMaxTimeBox";
            this.nMaxTimeBox.Size = new System.Drawing.Size(100, 20);
            this.nMaxTimeBox.TabIndex = 5;
            this.nMaxTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(348, 19);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(467, 19);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 7;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Average time (mean of means)";
            // 
            // AverageField
            // 
            this.AverageField.AutoSize = true;
            this.AverageField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageField.Location = new System.Drawing.Point(216, 192);
            this.AverageField.Name = "AverageField";
            this.AverageField.Size = new System.Drawing.Size(0, 25);
            this.AverageField.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Standard Deviation of sample means";
            // 
            // StdDevField
            // 
            this.StdDevField.AutoSize = true;
            this.StdDevField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdDevField.Location = new System.Drawing.Point(542, 203);
            this.StdDevField.Name = "StdDevField";
            this.StdDevField.Size = new System.Drawing.Size(0, 25);
            this.StdDevField.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Progress";
            // 
            // ProgressField
            // 
            this.ProgressField.AutoSize = true;
            this.ProgressField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressField.Location = new System.Drawing.Point(380, 94);
            this.ProgressField.Name = "ProgressField";
            this.ProgressField.Size = new System.Drawing.Size(0, 16);
            this.ProgressField.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Threads";
            // 
            // nThreadsBox
            // 
            this.nThreadsBox.Location = new System.Drawing.Point(174, 94);
            this.nThreadsBox.Name = "nThreadsBox";
            this.nThreadsBox.Size = new System.Drawing.Size(100, 20);
            this.nThreadsBox.TabIndex = 15;
            this.nThreadsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 594);
            this.Controls.Add(this.nThreadsBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProgressField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StdDevField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AverageField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.nMaxTimeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nAntsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nCubesBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sugar Cube SWN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nCubesBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nAntsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nMaxTimeBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AverageField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StdDevField;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ProgressField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nThreadsBox;
    }
}

