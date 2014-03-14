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
            this.label1 = new System.Windows.Forms.Label();
            this.nCubesBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nAntsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nMaxTimeBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 594);
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
    }
}

