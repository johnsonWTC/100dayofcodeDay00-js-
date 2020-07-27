package com.example.crudday55;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("items")
public class ItemController {

    @Autowired
    Itemservice itemservice;

    @PostMapping("create")
    public Item createId(Item item){
        return itemservice.createItem(item);
    }

    @GetMapping("all")
    public Iterable findItems (){
        return itemservice.findAll();
    }

    @DeleteMapping("delete/{itemID}")
    public void deleteItem(@PathVariable("itemID") Integer itemID){
        itemservice.deleteItem(itemID);
    }

    @PutMapping("edit/{itemID}/{newItemName}")
    public Item updateItem(@PathVariable("itemID") Integer itemID, @PathVariable("newItemName") String newItemName){
       return itemservice.editItem(itemID,newItemName);
    }
}
