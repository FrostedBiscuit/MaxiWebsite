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

module.exports = router;