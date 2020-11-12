



let div = document.getElementById("div");
let textarea = document.getElementById("textarea");
let addContent = document.getElementById("addContent");
let PostViews = document.getElementById("PostViews");








window.onload = function () {
    let div = document.getElementById("div");
    let textarea = document.getElementById("textarea");
    let addContent = document.getElementById("addContent");
    let PostViews = document.getElementById("PostViews");
    
    let views = 0;

    fetch("https://localhost:44381/api/PostsAPI/").then(function (res) {
        res.json().then(function (data) {
            for (let i = 0; data.length > i; i++) {
                let post = document.createElement("h2");
               
                post.innerHTML = data[i].postTitle;
                
                div.append(post);
            }      
        })
    })
  

fetch("https://localhost:44381/api/pageViews").then(function (res) {
    res.json().then(function (data) {
        for (let i = 0; data.length > i; i++) {
            views = data[i].views
        }
        views++
        PostViews.innerHTML = views;
    })
})

fetch(`https://localhost:44381/api/pageViews/1/${views}`, {
            method: "Put",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },

        })
}




