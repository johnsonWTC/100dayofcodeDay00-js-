package com.example.crudday54;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class ItemController {
    @Autowired
    ItemService itemService;

    @PostMapping ("create")
    public Item createItem(Item item){
        return  itemService.createItem(item);
    }
}
