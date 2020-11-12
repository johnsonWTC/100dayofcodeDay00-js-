



let div = document.getElementById("div");
let textarea = document.getElementById("textarea");
let addContent = document.getElementById("addContent");

addContent.addEventListener("click", function () {
    fetch("https://localhost:44381/api/PostsAPI/", {
        method: "Post",
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            "postContent": textarea.value
        })
    })
    location.reload();

})


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

window.onload = function () {
    fetch().then(function (res) {
        res.json().then(function (data) {
            for (let i = 0; data.length > i; i++) {
                let post = document.createElement("h2");
                //data[i].postContent;
                post.innerHTML = data[i].postTitle
                div.append(post);
            }
        })
    })
}


