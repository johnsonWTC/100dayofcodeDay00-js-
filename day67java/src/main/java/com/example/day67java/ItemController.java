package com.example.day67java;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("items")
public class ItemController {

    ItemService itemService;

    @GetMapping("create")
    public Item createItem(Item item){
        return itemService.createItem();
    }
}
