package com.example.demoday65;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping
public class ItemController {

    @Autowired
    ItemService itemService;

    @GetMapping("all")
    public  Iterable all(){
        return itemService.findAllItems();
    }

    @PostMapping("create")
    public Item createItem(Item item){
        return itemService.createItem(item);
    }

    @DeleteMapping("delete/{itemID}")
    public  void deleteItem(Integer itemId){
        itemService.deleteItem(itemId);
    }

    @PutMapping("{itemId}/{newItemName}")

}
