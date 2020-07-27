package com.example.crudday55;

import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("items")
public class ItemController {

    Itemservice itemservice;

    @PostMapping("create")
    public Item createId(Item item){
        return itemservice.createItem(item);
    }
}
