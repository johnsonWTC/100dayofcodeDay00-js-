package com.example.day67java;

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

    @PutMapping("{id}/{newItemName}")
    public Item editItem(@PathVariable("id") Integer itemId, @PathVariable("newItemName") String newItemName){
        return itemService.editByName(itemId,newItemName);
    }

    @DeleteMapping("delete/{id}")
    public  void deleteItem(@PathVariable("id") Integer itemId){
        itemService.deleteItem(itemId);
    }
}
