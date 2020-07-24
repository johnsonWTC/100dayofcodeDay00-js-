package com.example.restfulday54;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RestController;

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

    }
}
