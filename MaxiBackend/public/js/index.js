async function GetPosts() {

    const dataRaw = await fetch(`./getPosts`);
    const data = await dataRaw.json();

    console.log(`Data gotted`);

    for(post of data) {

        const postElement = document.createElement(`div`);
        const postTitle = document.createElement(`p`);
        const postContent = document.createElement(`p`);
        const postImg = document.createElement(`img`);


        postTitle.textContent = post.Title;
        postContent.textContent = post.Content;

        if (post.Image64 != null) {
            postImg.src = post.Image64;
        }

        postElement.appendChild(postTitle);
        postElement.appendChild(postContent);
        postElement.appendChild(postImg);

        document.body.append(postElement);
    }
}

GetPosts();