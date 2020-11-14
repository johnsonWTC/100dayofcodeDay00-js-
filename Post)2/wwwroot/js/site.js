let div = document.getElementById("div");
let commentArea = document.getElementById("textarea");
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
            "postTitle": "Title",
            "postContent": "Post Content",
            "postLike": 0,
            "numberofviews": 0,
            "commentContent": commentArea.valued,
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
                postContentFromDb.spellcheck = "true";
                postContentFromDb.innerHTML = data[i].postContent;
                postContentFromDb.innerHTML = data[i].postContent;
                postContentFromDb.innerHTML = data[i].postContent;
                postContentFromDb.innerHTML = data[i].postContent;
                let viewComment = document.createElement("button");

                // post from db
                div.append(postTitleFromDb)
                div.append(PostViewsFromDb)
                div.append(postContentFromDb)
                div.append(viewComment)
 


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

    setTimeout(callfetch, 1000);
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




