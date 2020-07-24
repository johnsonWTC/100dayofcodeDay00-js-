package com.example.restfulday54;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
public class ItemController {

    @Autowired
    ItemService itemService;

    @GetMapping("{itemId}")
    public Item findItemById(@PathVariable("itemId") Integer itemId){
        return itemService.findbyId(itemId);
    }

    @PutMapping("{itemID}/{newItemName}")
    public Item updateItemById(@PathVariable("itemID") Integer itemID, @PathVariable("newItemName") String newItemName){
        return itemService.updateItem(itemID,newItemName);
    }

    @PostMapping("create")
    public  Item createItem(Item item){
        return itemService.createItem(item);
    }


}
