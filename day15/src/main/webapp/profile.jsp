<div id="itemName">
${name}
</div> was added

<hr>
<div id="list"></div>
<script>
    let list = document.getElementById("list");
    let li = document.createElement("li");
    let itemName = document.getElementById("itemName");
    li.innerHTML = itemName.innerText;
    list.append((li));
</script>