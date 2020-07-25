package com.example.crudday54;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class ItemController {
    ItemService itemService;

    @GetMapping("create")
    public Item createItem(Item item){
        return  itemService.createItem(item);
    }
}
