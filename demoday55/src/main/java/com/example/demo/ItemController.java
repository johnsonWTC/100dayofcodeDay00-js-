package com.example.demo;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("users")
public class ItemController {

    @Autowired
    ItemService itemService;

    @PostMapping("create")
    public  Item createItem(Item item){
        return itemService.createItem(item);
    }

    @DeleteMapping("delete")
    public void deleteItem(Item item){
        itemService.deleteItem(item);
    }

    @GetMapping("all")
    public void findall(){
        itemService.findAll();
    }
}
