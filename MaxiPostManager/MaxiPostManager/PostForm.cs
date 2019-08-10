using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxiPostManager {

    public partial class PostForm : Form {

        public PostForm() {
            InitializeComponent();
        }

        private string selectedImgPath;

        private async void SubmitButton_Click(object sender, EventArgs e) {

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

            string serverImgDir = await ImageUploader.PostImage(selectedImgPath);

            Post newPost = new Post(TitleInputBox.Text, ContentInputBox.Text, serverImgDir);

            PostManager.InsertPost(newPost);
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
        }
    }
}
