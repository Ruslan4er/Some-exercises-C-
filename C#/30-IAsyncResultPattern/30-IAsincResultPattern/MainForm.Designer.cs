namespace _30_IAsincResultPattern
{
    partial class MainForm
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
            this.IsCompleteButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.CallBackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IsCompleteButton
            // 
            this.IsCompleteButton.Location = new System.Drawing.Point(54, 118);
            this.IsCompleteButton.Name = "IsCompleteButton";
            this.IsCompleteButton.Size = new System.Drawing.Size(78, 33);
            this.IsCompleteButton.TabIndex = 0;
            this.IsCompleteButton.Text = "IsComplete";
            this.IsCompleteButton.UseVisualStyleBackColor = true;
            this.IsCompleteButton.Click += new System.EventHandler(this.IsCompleteButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(147, 118);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(75, 33);
            this.EndButton.TabIndex = 1;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // CallBackButton
            // 
            this.CallBackButton.Location = new System.Drawing.Point(237, 118);
            this.CallBackButton.Name = "CallBackButton";
            this.CallBackButton.Size = new System.Drawing.Size(79, 33);
            this.CallBackButton.TabIndex = 2;
            this.CallBackButton.Text = "Callback";
            this.CallBackButton.UseVisualStyleBackColor = true;
            this.CallBackButton.Click += new System.EventHandler(this.CallBackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 259);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CallBackButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.IsCompleteButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IsCompleteButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button CallBackButton;
        private System.Windows.Forms.Label label1;
    }
}

