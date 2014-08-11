namespace GestaoBuffer
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
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnChange = new System.Windows.Forms.Button();
			this.btnListPages = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLoad
			// 
			this.btnLoad.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.btnLoad.Location = new System.Drawing.Point(12, 12);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnSave
			// 
			this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.btnSave.Location = new System.Drawing.Point(12, 41);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnChange
			// 
			this.btnChange.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.btnChange.Location = new System.Drawing.Point(12, 70);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(75, 23);
			this.btnChange.TabIndex = 2;
			this.btnChange.Text = "Change";
			this.btnChange.UseVisualStyleBackColor = true;
			// 
			// btnListPages
			// 
			this.btnListPages.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.btnListPages.Location = new System.Drawing.Point(12, 99);
			this.btnListPages.Name = "btnListPages";
			this.btnListPages.Size = new System.Drawing.Size(75, 23);
			this.btnListPages.TabIndex = 3;
			this.btnListPages.Text = "List Pages";
			this.btnListPages.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnListPages);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnLoad);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.Button btnListPages;
    }
}

