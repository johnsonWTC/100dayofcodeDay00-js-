

let div = document.getElementById("div");
let postContent = document.getElementById("textarea");
let addContent = document.getElementById("addContent");
let PostViews = document.getElementById("PostViews");
let postTitle = document.getElementById("postTitle");



addContent.addEventListener("click", function () {
    fetch("https://localhost:44381/api/PostsAPI", {
        method: "Post",
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            "postTitle": postTitle.value,
            "postContent": postContent.value,
            "postLike": 0,
            "numberofviews": 0,
        })
    })
})









window.onload = function () {
    let div = document.getElementById("div");
    let PostViews = document.getElementById("PostViews");
    let views = 0;
    let PostViewsFromDb = document.getElementById("PostViews");
    let postTitleFromDb = document.getElementById("postTitle");


    fetch("https://localhost:44381/api/PostsAPI/").then(function (res) {
        res.json().then(function (data) {
            for (let i = 0; data.length > i; i++) {
                // get post from db
                let postTitleFromDb = document.createElement("h2");
                let PostViewsFromDb = document.createElement("span");
                let postContentFromDb = document.createElement("p");
                let postLike = document.createElement("p");
                let hr = document.createElement("hr");
                postContentFromDb.spellcheck = "true";
                postContent.classList.add("content");
                PostViewsFromDb.classList.add("view");
                postTitleFromDb.classList.add("title");
                postLike.classList.add("postlikes");
                postContentFromDb.innerHTML = data[i].postContent;
                postTitleFromDb.innerHTML = data[i].postTitle;
                PostViewsFromDb.innerHTML ="Post Views "+  data[i].numberofviews;
                postLike.innerHTML = "Post Like "+ data[i].postLike;
                let viewComment = document.createElement("button");

                // post from db
                div.append(postTitleFromDb);
                div.append(postContentFromDb);
                div.append(PostViewsFromDb);
                div.append(postLike);
                div.append(viewComment);
                div.append(hr);

                // to view and add comment
                viewComment.innerHTML = "Comments";
                viewComment.addEventListener("click", function () {
                    // to add comment
                    let commentDiv = document.createElement("div");
                    let commentArea = document.createElement("textarea");
                    let commentButton = document.createElement("button");
                    commentButton.innerHTML = "Add comment"
                    div.append(commentDiv);
                    commentDiv.append(commentArea);
                    commentDiv.append(commentButton);
                    commentButton.addEventListener("click", function () {
                        fetch("https://localhost:44381/api/commentsAPI", {
                            method: "Post",
                            headers: {
                                'Accept': 'application/json',
                                'Content-Type': 'application/json'
                            },
                            body: JSON.stringify({
                                "commentContent": commentArea.value,
                                "postID": data[i].postID,
                            })
                        })
                    })

                })
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

  //  setTimeout(callfetch, 1000);
    function callfetch() {

        fetch(`https://localhost:44381/api/pageViews/1/${views}`, {
            method: "Put",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
        })
    }
}




