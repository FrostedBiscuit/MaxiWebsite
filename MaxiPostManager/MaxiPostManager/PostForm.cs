using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaxiPostManager {

    public partial class PostForm : Form {
        #region Variables
        public int selectedID;
        private string selectedImgPath = "";
        #endregion

        public PostForm() {

            InitializeComponent();

            PostManager.RegisterOnPostsLoadCallback(loadPostComboBox);
        }

        void loadPostComboBox() {

            cbTitle.DataSource = PostManager.posts.ToList();
            cbTitle.ValueMember = "ID";
            cbTitle.DisplayMember = "Title";

            PostManager.UnregisterOnPostsLoadCallback(loadPostComboBox);
        }
        void clearInputForm() {

            TitleInputBox.Text = "";
            ContentInputBox.Text = "";
            selectedImgPath = "";
            MessageBox.Show("Posted successfully");
        }

        #region  Events
        private void SubmitButton_Click(object sender, EventArgs e) {

            if (TitleInputBox.Text == "") {

                Console.Error.WriteLine("ERROR: Cannot submit a post without a title!!!");

                MessageBox.Show("Cannot submit a post without a title!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (ContentInputBox.Text == "") {

                Console.Error.WriteLine("ERROR: Cannot submit a post without content!!!");

                MessageBox.Show("Cannot submit a post without content!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (selectedImgPath == "") {

                Console.Error.WriteLine("ERROR: Cannot submit a post without image!!!");

                MessageBox.Show("Cannot submit a post without an image!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // Waaaaaaaaay tooo hacky for my liking
            string imgExtension = Path.GetExtension(selectedImgPath).ToLower();
            string img64 = $"data:image/{imgExtension};base64,{Convert.ToBase64String(File.ReadAllBytes(selectedImgPath))}";

            Post newPost = new Post(TitleInputBox.Text, ContentInputBox.Text, img64);

            PostManager.AddPost(newPost);
            PostManager.RefreshPosts();
            clearInputForm();

        }

        private void SelectImgButton_Click(object sender, EventArgs e) {

            OpenFileDialog openImg = new OpenFileDialog {

                InitialDirectory = @"C:\",
                Title = "Select image",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpeg",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF",
                FilterIndex = 2,

                RestoreDirectory = true
            };

            if (openImg.ShowDialog() == DialogResult.OK) {

                Console.WriteLine($"Opened image: {openImg.FileName}");

                SelectedImgPathLabel.Text = openImg.FileName;

                selectedImgPath = openImg.FileName;
            }
            else {

                selectedImgPath = "";
            }
        }
        #endregion

        private void cbTitle_SelectedIndexChanged(object sender, EventArgs e) {

            Post selectedPost = (Post)cbTitle.SelectedItem;

            tbTitle.Text = selectedPost.Title;
            tbContent.Text = selectedPost.Content;
            selectedID = selectedPost.ID;
            string rawImg64 = selectedPost.Image64.Substring(selectedPost.Image64.IndexOf(",") + 1);

            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(rawImg64))) {
                pbPicture.Image = System.Drawing.Image.FromStream(ms);

            }

            Console.WriteLine(selectedPost.Image64 == null ? $"No image on post {selectedPost.ID}" : $"Yes image, post: {selectedPost.ID}");
        }

        private void Tabs_Click(object sender, EventArgs e) {
            if (Tabs.SelectedIndex == 1) {
                loadPostComboBox();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e) {

            Console.WriteLine("update btn clicked");

            Post updatedPost = PostManager.posts[cbTitle.SelectedIndex];

            updatedPost.Title = tbTitle.Text;
            updatedPost.Content = tbContent.Text;

            if (selectedImgPath != "") {

                string imgExtension = Path.GetExtension(selectedImgPath).ToLower();
                string img64 = $"data:image/{imgExtension};base64,{Convert.ToBase64String(File.ReadAllBytes(selectedImgPath))}";

                updatedPost.Image64 = img64;
            }

            PostManager.UpdatePost(updatedPost);
        }
    }
}
