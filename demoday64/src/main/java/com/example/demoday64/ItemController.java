package com.example.demoday64;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("Items")
public class ItemController {

    @Autowired
    ItemService itemService;

    @PostMapping("create")
    public  Item createItem(Item item){

    }

}
