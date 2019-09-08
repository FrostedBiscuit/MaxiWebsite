const express = require(`express`);
const router = express.Router();

const fs = require(`fs`);

// GET

router.get(`/getPosts`, (request, response) => {
    
    let posts = [];

    database.find({}).sort({ Date: -1 }).exec((error, docs) => {
    
        if (error) {
            throw error;
        }

        console.log(docs);

        for (post of docs) {

            const img64 = fs.readFileSync(post.ImagePath, { encoding: 'utf8' });

            delete post.ImagePath;
            post.Image64 = img64;
        }
        
        posts = docs;

        response.json(posts);
    });
});

// POST

// This post route is responsible for recieving new posts and storing them
router.post(`/uploadPost`, (request, response) => {

    const post = request.body;

    // Generate new image dir
    const imgDir = `./images/${++imageNum}.txt`;

    // Generate new file
    fs.writeFile(imgDir, post.Image64, (error) => {

        if (error) {
            throw error;
        }
    });
    
    // Delete encoded image from object
    delete post.Image64;
    // Add a new element that describes the image path
    post.ImagePath = imgDir;

    database.insert(post);

    // End response
    response.end();
});

// PATCH

// This patch route is responsible for handling post updating
router.patch(`/updatePost`, (request, response) => {

    // Cache updated values in a variable
    const updatedPost = request.body;

    // First check if the image of a post was updated or not
    if (updatedPost.Image64 == null) {

        // Seeing it wasn't, we simply update the post's Title and Content based on the post date
        database.update({ Date: updatedPost.Date }, { Title: updatedPost.Title, Content: updatedPost.Content }, {}, (error, numReplaced) => {
            if (error) {
                throw error;
            }
        });
    }
    else {

        // Seeing there is an updated image, we first find the corresponding post
        database.findOne({Date: updatedPost.Date}).exec((error, docs) => {
            if (error) {
                throw error;
            }

            // After the post is found, the data at the directory of the old post is updated
            fs.writeFileSync(docs.ImagePath, updatedPost.Image64, (error) => {
                if (error) {
                    throw error;
                }
            });
        });

        // Then the rest of the post's data is updated
        database.update({ Date: updatedPost.Date }, { Title: updatedPost.Title, Content: updatedPost.Content }, {}, (error, numReplaced) => {
            if (error) {
                throw error;
            }
        });
    }

    response.end();
});

module.exports = router;