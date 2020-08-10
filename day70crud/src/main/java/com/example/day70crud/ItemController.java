package com.example.day70crud;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("items")
public class ItemController {

    @Autowired
    ItemService itemService;

    @PutMapping("edit/{itemID}/{itemName}")
    public Item updateItem(@PathVariable("itemID") Integer itemID, @PathVariable("itemName") String itemName){
        return itemService.updateItem(itemID,itemName);
    }

    @PostMapping("create")
    public Item createItem(Item item){
        return itemService.createItem(item);
    }

    @GetMapping("all")
    public  Iterable findAll(){
        return itemService.findAll();
    }

    @DeleteMapping("delete/{itemID}")
    public void deleteByID(@PathVariable("itemID") Integer itemID){
        itemService.deleteItem(itemID);
    }
}
