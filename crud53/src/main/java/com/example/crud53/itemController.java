package com.example.crud53;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
public class itemController {

    @Autowired
    ItemService itemService;

    @GetMapping("{itemID}")
    public Item getItemByID(@PathVariable("itemID") Integer itemID ){
        return itemService.findItemById(itemID);
    }

    @PostMapping("create")
    public Item createItem(Item item){
        return itemService.createItem(item);
    }

    @PutMapping("{itemId}/{newItemName}")
    public Item updateItem(@PathVariable("itemId") Integer itemId, @PathVariable("newItemName") String newItemName){
        return  itemService.updateItemByID(itemId,newItemName);
    }

}
