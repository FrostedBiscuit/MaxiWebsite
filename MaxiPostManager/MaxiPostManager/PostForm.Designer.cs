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
            System.Windows.Forms.Label lblContent;
            System.Windows.Forms.Label lbTitle;
            this.TitleInputBox = new System.Windows.Forms.TextBox();
            this.ContentInputBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SelectImgButton = new System.Windows.Forms.Button();
            this.SelectedImgPathLabel = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.NewPostTab = new System.Windows.Forms.TabPage();
            this.ImagePreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.UpdatePostTab = new System.Windows.Forms.TabPage();
            this.SelectUpdatedImageButton = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbContent = new System.Windows.Forms.TextBox();
            TitleLabel = new System.Windows.Forms.Label();
            ContentLabel = new System.Windows.Forms.Label();
            lblContent = new System.Windows.Forms.Label();
            lbTitle = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.NewPostTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviewPictureBox)).BeginInit();
            this.UpdatePostTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
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
            ContentLabel.TabIndex = 0;
            ContentLabel.Text = "Content :";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblContent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblContent.Location = new System.Drawing.Point(3, 87);
            lblContent.Name = "lblContent";
            lblContent.Size = new System.Drawing.Size(99, 25);
            lblContent.TabIndex = 6;
            lblContent.Text = "Content :";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.CausesValidation = false;
            lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbTitle.Location = new System.Drawing.Point(3, 27);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(65, 25);
            lbTitle.TabIndex = 4;
            lbTitle.Text = "Title :";
            lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.SubmitButton.Location = new System.Drawing.Point(626, 397);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(158, 40);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SelectImgButton
            // 
            this.SelectImgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectImgButton.Location = new System.Drawing.Point(13, 397);
            this.SelectImgButton.Name = "SelectImgButton";
            this.SelectImgButton.Size = new System.Drawing.Size(158, 40);
            this.SelectImgButton.TabIndex = 4;
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
            this.Tabs.Location = new System.Drawing.Point(0, 1);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1181, 469);
            this.Tabs.TabIndex = 1;
            this.Tabs.Click += new System.EventHandler(this.Tabs_Click);
            // 
            // NewPostTab
            // 
            this.NewPostTab.Controls.Add(this.ImagePreviewPictureBox);
            this.NewPostTab.Controls.Add(this.SelectImgButton);
            this.NewPostTab.Controls.Add(this.SubmitButton);
            this.NewPostTab.Controls.Add(ContentLabel);
            this.NewPostTab.Controls.Add(this.ContentInputBox);
            this.NewPostTab.Controls.Add(TitleLabel);
            this.NewPostTab.Controls.Add(this.TitleInputBox);
            this.NewPostTab.Location = new System.Drawing.Point(4, 22);
            this.NewPostTab.Name = "NewPostTab";
            this.NewPostTab.Padding = new System.Windows.Forms.Padding(3);
            this.NewPostTab.Size = new System.Drawing.Size(1173, 443);
            this.NewPostTab.TabIndex = 0;
            this.NewPostTab.Text = "New Post";
            this.NewPostTab.UseVisualStyleBackColor = true;
            // 
            // ImagePreviewPictureBox
            // 
            this.ImagePreviewPictureBox.Location = new System.Drawing.Point(790, 31);
            this.ImagePreviewPictureBox.Name = "ImagePreviewPictureBox";
            this.ImagePreviewPictureBox.Size = new System.Drawing.Size(377, 357);
            this.ImagePreviewPictureBox.TabIndex = 6;
            this.ImagePreviewPictureBox.TabStop = false;
            // 
            // UpdatePostTab
            // 
            this.UpdatePostTab.Controls.Add(this.SelectUpdatedImageButton);
            this.UpdatePostTab.Controls.Add(this.pbPicture);
            this.UpdatePostTab.Controls.Add(this.tbTitle);
            this.UpdatePostTab.Controls.Add(this.cbTitle);
            this.UpdatePostTab.Controls.Add(this.btnUpdate);
            this.UpdatePostTab.Controls.Add(lblContent);
            this.UpdatePostTab.Controls.Add(this.tbContent);
            this.UpdatePostTab.Controls.Add(lbTitle);
            this.UpdatePostTab.Location = new System.Drawing.Point(4, 22);
            this.UpdatePostTab.Name = "UpdatePostTab";
            this.UpdatePostTab.Padding = new System.Windows.Forms.Padding(3);
            this.UpdatePostTab.Size = new System.Drawing.Size(1173, 443);
            this.UpdatePostTab.TabIndex = 1;
            this.UpdatePostTab.Text = "Update Post";
            this.UpdatePostTab.UseVisualStyleBackColor = true;
            // 
            // SelectUpdatedImageButton
            // 
            this.SelectUpdatedImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectUpdatedImageButton.Location = new System.Drawing.Point(8, 395);
            this.SelectUpdatedImageButton.Name = "SelectUpdatedImageButton";
            this.SelectUpdatedImageButton.Size = new System.Drawing.Size(158, 40);
            this.SelectUpdatedImageButton.TabIndex = 13;
            this.SelectUpdatedImageButton.Text = "Select image...";
            this.SelectUpdatedImageButton.UseVisualStyleBackColor = true;
            this.SelectUpdatedImageButton.Click += new System.EventHandler(this.SelectUpdatedImageButton_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(790, 27);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(377, 357);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 12;
            this.pbPicture.TabStop = false;
            // 
            // tbTitle
            // 
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(8, 55);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(771, 29);
            this.tbTitle.TabIndex = 11;
            // 
            // cbTitle
            // 
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(8, 3);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(771, 21);
            this.cbTitle.TabIndex = 10;
            this.cbTitle.SelectedIndexChanged += new System.EventHandler(this.cbTitle_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(621, 395);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 40);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbContent
            // 
            this.tbContent.AcceptsReturn = true;
            this.tbContent.AcceptsTab = true;
            this.tbContent.AllowDrop = true;
            this.tbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContent.Location = new System.Drawing.Point(8, 115);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(771, 269);
            this.tbContent.TabIndex = 7;
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 470);
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
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviewPictureBox)).EndInit();
            this.UpdatePostTab.ResumeLayout(false);
            this.UpdatePostTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
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
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.PictureBox ImagePreviewPictureBox;
        private System.Windows.Forms.Button SelectUpdatedImageButton;
    }
}