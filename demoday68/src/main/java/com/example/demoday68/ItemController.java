package com.example.demoday68;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("items")
public class ItemController {

    @Autowired
    ItemService itemService;

    @PostMapping("create")
    public Item createItem(Item item){
        return itemService.createItem(item);
    }

    @PutMapping("{itemID}/{newItemName}")
    public Item editItem(@PathVariable("itemID") Integer itemID, @PathVariable("newItemName") String newItemName){
        return itemService.updateItem(itemID,newItemName);
    }

    @DeleteMapping("delete/{itemId}")
    public void deleteItem(@PathVariable("itemId") Integer itemId){
         itemService.deleteItem(itemId);

    }

    @GetMapping("all")
    public Iterable allItem(){
        return itemService.findAllItems();
    }


}
