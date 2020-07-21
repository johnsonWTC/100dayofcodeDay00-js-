<h2>${shopItem}</h2> Shop online
<br><br>
<input type="text" placeholder="item name" id="itemName"><button id="addToCart">Add To Chart</button>
<div id="list"></div>

<script>
    let itemName = document.getElementById("itemName");
    let addToCart = document.getElementById("addToCart");
    let itemsOnCart = [];
    let list = document.getElementById("list");


    addToCart.addEventListener("click",function () {
        if(itemName.value.length == 0){
            alert("Item name is required");
        }else{
            itemsOnCart.push(itemName.value);
            let li = document.createElement("li");
            let more = document.createElement("button");
            let les = document.createElement("button");
            let del = document.createElement("button");
            let countPerItem = document.createElement("span");
            more.innerHTML = "MORE";
            les.innerHTML = "LESS";
            del.innerHTML = "DELETE"
            let count = 0
            countPerItem.innerHTML = " "+ count;
            li.innerHTML = itemName.value;
            list.append(li);
            list.append(more);
            list.append(les);
            list.append(countPerItem);
        }
    })
</script>