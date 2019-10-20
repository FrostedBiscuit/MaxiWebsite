async function GetPosts() {

    const dataRaw = await fetch(`./getPosts`);
    const data = await dataRaw.json();

    console.log(`Data gotted`);

    const postContainer = document.getElementById(`novice`);

    let index = 0;

    for(post of data) {

        const postElement = document.createElement(`div`);
        const rowDiv = document.createElement(`div`);
        const imageDiv = document.createElement(`div`);
        const textDiv = document.createElement(`div`);

        const image = document.createElement(`img`);

        const postTitle = document.createElement(`h1`);
        const postContent = document.createElement(`p`);

        image.src = post.Image64;

        imageDiv.append(image);
        imageDiv.classList.add(`col-auto`, `col-sm-6`, `col-md-5`, `col-lg-5`, `align-self-stretch`);
        imageDiv.style = `height: 317px;width: 536px;padding-right: 0px;padding-left: 0px;`;

        postTitle.textContent = post.Title;
        postTitle.style = `font-family: Poppins, sans-serif;font-size: 40px;color: rgb(17,45,74);font-weight: normal;margin-top: 8px;`;

        postContent.textContent = post.Content;
        postContent.style = `font-family: Poppins, sans-serif;font-size: 22px;color: rgb(17,45,74);font-weight: normal;`;

        textDiv.append(postTitle);
        textDiv.append(postContent);

        textDiv.classList.add(`col-sm-6`, `col-md-7`, `col-lg-7`);
        textDiv.style = `background-color: rgba(255,255,255,0);`;

        if (index % 2 == 0) {
            rowDiv.append(imageDiv);
            rowDiv.append(textDiv);
        }
        else {
            rowDiv.append(textDiv);
            rowDiv.append(imageDiv);
        }

        rowDiv.className = `row`;
        rowDiv.style = `background-color: #f4f4f4;`;
        
        postElement.append(rowDiv);
        postElement.className = `container`;
        postElement.style = `margin-top: 25px`;
        postElement.setAttribute(`data-aos`, `fade-up`);
        postElement.setAttribute(`data-aos-delay`, `100`);

        postContainer.append(postElement);

        index++;
    }
}

GetPosts();