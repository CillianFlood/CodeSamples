namespace CodingSample
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
            this.Output = new System.Windows.Forms.Label();
            this.tallestButton = new System.Windows.Forms.Button();
            this.shortestButton = new System.Windows.Forms.Button();
            this.youngestButton = new System.Windows.Forms.Button();
            this.oldestButton = new System.Windows.Forms.Button();
            this.meanAgeButton = new System.Windows.Forms.Button();
            this.healthButton = new System.Windows.Forms.Button();
            this.stateButton = new System.Windows.Forms.Button();
            this.weightLossButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 92);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(434, 20000);
            this.Output.TabIndex = 0;
            // 
            // tallestButton
            // 
            this.tallestButton.Location = new System.Drawing.Point(12, 12);
            this.tallestButton.Name = "tallestButton";
            this.tallestButton.Size = new System.Drawing.Size(75, 23);
            this.tallestButton.TabIndex = 1;
            this.tallestButton.Text = "Tallest";
            this.tallestButton.UseVisualStyleBackColor = true;
            this.tallestButton.Click += new System.EventHandler(this.tallestButton_Click);
            // 
            // shortestButton
            // 
            this.shortestButton.Location = new System.Drawing.Point(102, 12);
            this.shortestButton.Name = "shortestButton";
            this.shortestButton.Size = new System.Drawing.Size(75, 23);
            this.shortestButton.TabIndex = 2;
            this.shortestButton.Text = "Shortest";
            this.shortestButton.UseVisualStyleBackColor = true;
            this.shortestButton.Click += new System.EventHandler(this.shortestButton_Click);
            // 
            // youngestButton
            // 
            this.youngestButton.Location = new System.Drawing.Point(197, 12);
            this.youngestButton.Name = "youngestButton";
            this.youngestButton.Size = new System.Drawing.Size(75, 23);
            this.youngestButton.TabIndex = 3;
            this.youngestButton.Text = "Youngest";
            this.youngestButton.UseVisualStyleBackColor = true;
            this.youngestButton.Click += new System.EventHandler(this.youngestButton_Click);
            // 
            // oldestButton
            // 
            this.oldestButton.Location = new System.Drawing.Point(291, 12);
            this.oldestButton.Name = "oldestButton";
            this.oldestButton.Size = new System.Drawing.Size(75, 23);
            this.oldestButton.TabIndex = 4;
            this.oldestButton.Text = "Oldest";
            this.oldestButton.UseVisualStyleBackColor = true;
            this.oldestButton.Click += new System.EventHandler(this.oldestButton_Click);
            // 
            // meanAgeButton
            // 
            this.meanAgeButton.Location = new System.Drawing.Point(15, 53);
            this.meanAgeButton.Name = "meanAgeButton";
            this.meanAgeButton.Size = new System.Drawing.Size(75, 23);
            this.meanAgeButton.TabIndex = 5;
            this.meanAgeButton.Text = "Mean Age";
            this.meanAgeButton.UseVisualStyleBackColor = true;
            this.meanAgeButton.Click += new System.EventHandler(this.meanAgeButton_Click);
            // 
            // healthButton
            // 
            this.healthButton.Location = new System.Drawing.Point(102, 53);
            this.healthButton.Name = "healthButton";
            this.healthButton.Size = new System.Drawing.Size(75, 23);
            this.healthButton.TabIndex = 6;
            this.healthButton.Text = "Health";
            this.healthButton.UseVisualStyleBackColor = true;
            this.healthButton.Click += new System.EventHandler(this.healthButton_Click);
            // 
            // stateButton
            // 
            this.stateButton.Location = new System.Drawing.Point(197, 53);
            this.stateButton.Name = "stateButton";
            this.stateButton.Size = new System.Drawing.Size(75, 23);
            this.stateButton.TabIndex = 7;
            this.stateButton.Text = "By State";
            this.stateButton.UseVisualStyleBackColor = true;
            this.stateButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // weightLossButton
            // 
            this.weightLossButton.Location = new System.Drawing.Point(291, 53);
            this.weightLossButton.Name = "weightLossButton";
            this.weightLossButton.Size = new System.Drawing.Size(75, 23);
            this.weightLossButton.TabIndex = 8;
            this.weightLossButton.Text = "Weight Loss";
            this.weightLossButton.UseVisualStyleBackColor = true;
            this.weightLossButton.Click += new System.EventHandler(this.weightLossButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(475, 423);
            this.Controls.Add(this.weightLossButton);
            this.Controls.Add(this.stateButton);
            this.Controls.Add(this.healthButton);
            this.Controls.Add(this.meanAgeButton);
            this.Controls.Add(this.oldestButton);
            this.Controls.Add(this.youngestButton);
            this.Controls.Add(this.shortestButton);
            this.Controls.Add(this.tallestButton);
            this.Controls.Add(this.Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button tallestButton;
        private System.Windows.Forms.Button shortestButton;
        private System.Windows.Forms.Button youngestButton;
        private System.Windows.Forms.Button oldestButton;
        private System.Windows.Forms.Button meanAgeButton;
        private System.Windows.Forms.Button healthButton;
        private System.Windows.Forms.Button stateButton;
        private System.Windows.Forms.Button weightLossButton;
    }
}

