package com.example.day60;

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

    @GetMapping("all")
    public  Iterable findall(){
        return itemService.findAll();
    }

    @PutMapping("{itemID}/{newItemName}")
    public  Item updateItem(@PathVariable("itemID") Integer itemID, @PathVariable("newItemName") String newItemName){
        return itemService.editItem(itemID,newItemName);
    }


}
