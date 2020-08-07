package com.example.day67java;

import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("items")
public class ItemController {

    ItemService itemService;

    @PostMapping("create")
    public Item createItem(Item item){
        return itemService.createItem(item);
    }

    @PutMapping("{id}/{newItemName}")
    public Item editItem(@PathVariable("id") Integer itemId, @PathVariable("newItemName") String newItemName){
        return itemService.editByName(itemId,newItemName);
    }
}
