let div = document.getElementById("div");
fetch("https://localhost:44381/api/PostsAPI/").then(function (res) {
    res.json().then(function (data) {
        for (let i = 0; data.length > i; i++) {
            let post = document.createElement("h2");
            //data[i].postContent;
            post.innerHTML = data[i].postContent
            div.append(post);
        }
    })
})
