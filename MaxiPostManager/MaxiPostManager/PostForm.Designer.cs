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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.NewPostTab = new System.Windows.Forms.TabPage();
            this.UpdatePostTab = new System.Windows.Forms.TabPage();
            TitleLabel = new System.Windows.Forms.Label();
            ContentLabel = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.NewPostTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.CausesValidation = false;
            TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TitleLabel.Location = new System.Drawing.Point(8, 3);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new System.Drawing.Size(65, 25);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Title :";
            // 
            // ContentLabel
            // 
            ContentLabel.AutoSize = true;
            ContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ContentLabel.Location = new System.Drawing.Point(8, 63);
            ContentLabel.Name = "ContentLabel";
            ContentLabel.Size = new System.Drawing.Size(99, 25);
            ContentLabel.TabIndex = 2;
            ContentLabel.Text = "Content :";
            // 
            // TitleInputBox
            // 
            this.TitleInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleInputBox.Location = new System.Drawing.Point(13, 31);
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
            this.ContentInputBox.Location = new System.Drawing.Point(13, 89);
            this.ContentInputBox.Multiline = true;
            this.ContentInputBox.Name = "ContentInputBox";
            this.ContentInputBox.Size = new System.Drawing.Size(771, 299);
            this.ContentInputBox.TabIndex = 3;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(13, 394);
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
            this.SelectImgButton.Location = new System.Drawing.Point(630, 436);
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
            // Tabs
            // 
            this.Tabs.Controls.Add(this.NewPostTab);
            this.Tabs.Controls.Add(this.UpdatePostTab);
            this.Tabs.Location = new System.Drawing.Point(0, -1);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(802, 509);
            this.Tabs.TabIndex = 7;
            // 
            // NewPostTab
            // 
            this.NewPostTab.Controls.Add(this.SelectImgButton);
            this.NewPostTab.Controls.Add(this.SubmitButton);
            this.NewPostTab.Controls.Add(ContentLabel);
            this.NewPostTab.Controls.Add(this.ContentInputBox);
            this.NewPostTab.Controls.Add(TitleLabel);
            this.NewPostTab.Controls.Add(this.TitleInputBox);
            this.NewPostTab.Location = new System.Drawing.Point(4, 22);
            this.NewPostTab.Name = "NewPostTab";
            this.NewPostTab.Padding = new System.Windows.Forms.Padding(3);
            this.NewPostTab.Size = new System.Drawing.Size(794, 483);
            this.NewPostTab.TabIndex = 0;
            this.NewPostTab.Text = "New Post";
            this.NewPostTab.UseVisualStyleBackColor = true;
            // 
            // UpdatePostTab
            // 
            this.UpdatePostTab.Location = new System.Drawing.Point(4, 22);
            this.UpdatePostTab.Name = "UpdatePostTab";
            this.UpdatePostTab.Padding = new System.Windows.Forms.Padding(3);
            this.UpdatePostTab.Size = new System.Drawing.Size(794, 483);
            this.UpdatePostTab.TabIndex = 1;
            this.UpdatePostTab.Text = "Update Post";
            this.UpdatePostTab.UseVisualStyleBackColor = true;
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.SelectedImgPathLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maxi post manager";
            this.Tabs.ResumeLayout(false);
            this.NewPostTab.ResumeLayout(false);
            this.NewPostTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleInputBox;
        private System.Windows.Forms.TextBox ContentInputBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button SelectImgButton;
        private System.Windows.Forms.Label SelectedImgPathLabel;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage NewPostTab;
        private System.Windows.Forms.TabPage UpdatePostTab;
    }
}