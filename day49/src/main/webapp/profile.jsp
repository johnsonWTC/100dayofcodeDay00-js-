<h1>Hello ${name}</h1>
<input placeholder="item name" id="itemName" >
<button id="add" onclick="addItems()">ADD ITEM</button>
<div id="suggestions"></div>
<hr>
<div id="list"></div>
<script>
 let itemName = document.getElementById("itemName");
 let add = document.getElementById("add");
 let items = [];
 let list = document.getElementById("list");

 function  addItems() {
     if(itemName.value.length == 0){
         alert(("item name is required"));
         add.focus();
     }else{
         let li = document.createElement(li);
         li.innerText = itemName.value;

     }
 }

</script>

