const express = require(`express`);
const app = express();
const router = require(`./router`);

const PORT = 3000;

const nedb = require(`nedb`);
global.database = new nedb(`posts.db`);

database.loadDatabase((error) => {
    if (error) {
        throw error;
    }
});

const fs = require(`fs`);
global.imageNum = 0;

// Get the number of saved images 
fs.readdir(`./images`, (error, files) => {

    if (error) {
        throw error;
    }

    imageNum = files.length;
});

app.use(express.static(`public`));
app.use(express.json({limit: '10mb', extended: 'true'}));
app.use(router);

app.listen(PORT, () => {

    console.log(`Listening at port ${PORT}`);
});