const express = require(`express`);
const app = express();

const PORT = 3000;

const fs = require(`fs`);
let imageNum = 0;

// Get the number of saved images 
fs.readdir(`./images`, (error, files) => {

    if (error) {
        throw error;
    }

    imageNum = files.length;
});

app.use(express.static(`/public`));
app.use(express.json({limit: '10mb', extended: 'true'}));

// This post route is responsible for recieving the image of a newly added post
app.post(`/uploadImage`, (request, response) => {

    // Generate new image dir
    const dir = `./images/${++imageNum}.txt`;

    // Generate new file
    fs.writeFile(dir, request.body.image64, (error) => {

        if (error) {
            throw error;
        }
    });

    // Send response with new image dir to store it in the database
    response.json({
        serverImgDir: dir
    });
});

app.get(`/api`, (request, response) => {
    response.send("Hello");
});

app.listen(PORT, () => {

    console.log(`Listening at port ${PORT}`);
});