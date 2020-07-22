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
            del.innerHTML = "REMOVE FROM CART";
            let count = 0
            countPerItem.innerHTML = " "+ count;
            li.innerHTML = itemName.value;
            list.append(li);
            list.append(more);
            list.append(les);
            list.append(del);
            list.append(countPerItem);

            more.addEventListener("click", function () {
                count++;
                countPerItem.innerHTML = " " +count;
            });
            les.addEventListener("click", function () {
                count--;
                if(count < 0){
                    count = "";
                }
                countPerItem.innerHTML = " "+count;
            })

            del.addEventListener("click", function () {
                let confirmation = confirm(`are you sure you want to remove ${li.innerHTML} from the list`);
                if(confirmation){
                li.remove();
                more.remove();
                les.remove();
                del.remove();
                countPerItem.remove();
            }
            })
        }
    })
</script>