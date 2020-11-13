let div = document.getElementById("div");
let textarea = document.getElementById("textarea");
let addContent = document.getElementById("addContent");
let PostViews = document.getElementById("PostViews");
let postTitle = document.getElementById("postTitle");



addContent.addEventListener("click", function () {
    fetch("https://localhost:44381/api/commentsAPI", {
        method: "Post",
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            "postTitle": commentArea.valued,
            "postContent": commentArea.valued,
            "postLike": commentArea.valued,
            "numberofviews": commentArea.valued,
            "commentContent": commentArea.valued,
        })
    })
})









window.onload = function () {
    let div = document.getElementById("div");
    let PostViews = document.getElementById("PostViews");
    let views = 0;



    fetch("https://localhost:44381/api/PostsAPI/").then(function (res) {
        res.json().then(function (data) {
            for (let i = 0; data.length > i; i++) {
                let postTitle = document.createElement("h2");
                let postContent = document.createElement("p");
                postContent.spellcheck = "true";
                postContent.innerHTML = data[i].postContent;
                let viewComment = document.createElement("button");

                // post from db
                div.append(postTitle)
                div.append(postContent)
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




