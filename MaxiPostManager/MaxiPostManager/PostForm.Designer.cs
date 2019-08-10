namespace MaxiPostManager {
    partial class PostForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.Label TitleLabel;
            System.Windows.Forms.Label ContentLabel;
            this.TitleInputBox = new System.Windows.Forms.TextBox();
            this.ContentInputBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SelectImgButton = new System.Windows.Forms.Button();
            this.SelectedImgPathLabel = new System.Windows.Forms.Label();
            TitleLabel = new System.Windows.Forms.Label();
            ContentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.CausesValidation = false;
            TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TitleLabel.Location = new System.Drawing.Point(12, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new System.Drawing.Size(65, 25);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Title :";
            // 
            // ContentLabel
            // 
            ContentLabel.AutoSize = true;
            ContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ContentLabel.Location = new System.Drawing.Point(14, 69);
            ContentLabel.Name = "ContentLabel";
            ContentLabel.Size = new System.Drawing.Size(99, 25);
            ContentLabel.TabIndex = 2;
            ContentLabel.Text = "Content :";
            // 
            // TitleInputBox
            // 
            this.TitleInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleInputBox.Location = new System.Drawing.Point(17, 37);
            this.TitleInputBox.Name = "TitleInputBox";
            this.TitleInputBox.Size = new System.Drawing.Size(771, 29);
            this.TitleInputBox.TabIndex = 1;
            // 
            // ContentInputBox
            // 
            this.ContentInputBox.AcceptsReturn = true;
            this.ContentInputBox.AcceptsTab = true;
            this.ContentInputBox.AllowDrop = true;
            this.ContentInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentInputBox.Location = new System.Drawing.Point(17, 97);
            this.ContentInputBox.Multiline = true;
            this.ContentInputBox.Name = "ContentInputBox";
            this.ContentInputBox.Size = new System.Drawing.Size(771, 299);
            this.ContentInputBox.TabIndex = 3;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(618, 457);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(170, 36);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SelectImgButton
            // 
            this.SelectImgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectImgButton.Location = new System.Drawing.Point(19, 403);
            this.SelectImgButton.Name = "SelectImgButton";
            this.SelectImgButton.Size = new System.Drawing.Size(158, 40);
            this.SelectImgButton.TabIndex = 5;
            this.SelectImgButton.Text = "Select image...";
            this.SelectImgButton.UseVisualStyleBackColor = true;
            this.SelectImgButton.Click += new System.EventHandler(this.SelectImgButton_Click);
            // 
            // SelectedImgPathLabel
            // 
            this.SelectedImgPathLabel.AutoSize = true;
            this.SelectedImgPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedImgPathLabel.Location = new System.Drawing.Point(184, 416);
            this.SelectedImgPathLabel.Name = "SelectedImgPathLabel";
            this.SelectedImgPathLabel.Size = new System.Drawing.Size(0, 20);
            this.SelectedImgPathLabel.TabIndex = 6;
            this.SelectedImgPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.SelectedImgPathLabel);
            this.Controls.Add(this.SelectImgButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ContentInputBox);
            this.Controls.Add(ContentLabel);
            this.Controls.Add(this.TitleInputBox);
            this.Controls.Add(TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maxi post manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleInputBox;
        private System.Windows.Forms.TextBox ContentInputBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button SelectImgButton;
        private System.Windows.Forms.Label SelectedImgPathLabel;
    }
}