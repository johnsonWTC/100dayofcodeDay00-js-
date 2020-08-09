package com.example.demoday65;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping
public class ItemController {

    @Autowired
    ItemService itemService;

    @GetMapping("all")
    public  Iterable all(){
        return itemService.findAllItems();
    }
}
