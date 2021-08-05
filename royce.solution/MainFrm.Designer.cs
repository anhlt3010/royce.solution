
namespace royce.solution
{
    partial class MainFrm
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
            this.loadbypass_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadbypass_btn
            // 
            this.loadbypass_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.loadbypass_btn.Location = new System.Drawing.Point(12, 12);
            this.loadbypass_btn.Name = "loadbypass_btn";
            this.loadbypass_btn.Size = new System.Drawing.Size(274, 57);
            this.loadbypass_btn.TabIndex = 0;
            this.loadbypass_btn.Text = "Bypass";
            this.loadbypass_btn.UseVisualStyleBackColor = true;
            this.loadbypass_btn.Click += new System.EventHandler(this.loadbypass_btn_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 89);
            this.Controls.Add(this.loadbypass_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[royce.solution]";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadbypass_btn;
    }
}

