using System;
using System.IO;
using System.Windows.Forms;

namespace MaxiPostManager {

    public partial class PostForm : Form {

        public PostForm() {
            InitializeComponent();
        }

        private string selectedImgPath = "";

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
    }
}
