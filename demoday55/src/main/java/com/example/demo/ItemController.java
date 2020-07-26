package com.example.demo;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("items")
public class ItemController {

    @Autowired
    ItemService itemService;

    @RequestMapping("index")
    public String index(){
        return "index.html";
    }

    @PostMapping("create")
    public  Item createItem(Item item){
        return itemService.createItem(item);
    }

    @DeleteMapping("delete")
    public void deleteItem(Item item){
        itemService.deleteItem(item);
    }

    @GetMapping("all")
    public Iterable findall(){
       return itemService.findAll();
    }


}
