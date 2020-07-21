<h2>${shopItem}</h2> Shop online
<br><br>
<input type="text" placeholder="item name" id="itemName"><button id="addToCart">Add To Chart</button>

<script>
    let itemName = document.getElementById("itemName");
    let addToCart = document.getElementById("addToCart");


    addToCart.addEventListener("click",function () {
        if(itemName.value.length == 0){
            alert("Item name is required");
        }
    })
</script>