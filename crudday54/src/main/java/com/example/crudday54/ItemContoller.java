package com.example.crudday54;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("item")
public class ItemContoller {

    @Autowired
    ItemService itemService;

    @PostMapping("create")
    public  Item createItem(Item item){
        return itemService.createItem(item);
    }

    @GetMapping("all")
    public Iterable findAll(){
        return itemService.all();
    }
}
