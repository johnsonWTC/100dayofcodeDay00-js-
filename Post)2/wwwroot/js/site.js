



let div = document.getElementById("div");
let textarea = document.getElementById("textarea");
let addContent = document.getElementById("addContent");






window.onload = function () {
    let div = document.getElementById("div");
    let textarea = document.getElementById("textarea");
    let addContent = document.getElementById("addContent");
    let span = document.getElementById("PostViews");
    span.innerHTML = "hello";

    fetch("https://localhost:44381/api/PostsAPI/").then(function (res) {
        res.json().then(function (data) {
            for (let i = 0; data.length > i; i++) {
                let post = document.createElement("h2");
               
                post.innerHTML = data[i].postTitle;
                
                div.append(post);
            }      
        })
    })
    fetch("https://localhost:44381/apipageViews").then(function (res) {
        res.json().then(function (data) {
            for (let i = 0; data.length > i; i++) {
                let post = document.createElement("h2");

                post.innerHTML = data[i].postTitle;

                div.append(post);
            }
        })
    })


}


