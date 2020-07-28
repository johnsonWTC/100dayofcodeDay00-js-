package com.example.demovb;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("items")
public class ItemComtroller {

    @Autowired
    ItemService itemService;

    @PostMapping("create")
    public Item createItem(Item item){
        return itemService.createItem(item);
    }

    @GetMapping("all")
    public Iterable findAll(){
        return itemService.findAll();
    }
}
