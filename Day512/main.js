let tagContainer = document.querySelector(".tag-container");
let input = document.querySelector("#input");

function createTag(label) {
    let div = document.createElement("div");
    div.setAttribute("class", "tag")
    let spanInput = document.createElement("span");
    spanInput.innerHTML = label
    let closeBtn = document.createElement("span");
    closeBtn.addEventListener("click", function() {
        div.remove();
    })
    closeBtn.setAttribute("class", "close");
    closeBtn.innerHTML = "x";
    div.append(spanInput);
    div.append(closeBtn);
    return div;
}



input.addEventListener("keyup", function(e) {
    if (e.keyCode == 32 || e.key === ",") {
        tagContainer.prepend(createTag(input.value));
        input.value = "";
    }

})