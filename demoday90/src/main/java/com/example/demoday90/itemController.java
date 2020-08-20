package com.example.demoday90;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("")
public class itemController {

    @Autowired
    private ItemService itemService;
    @PostMapping("create")
    public  Item createItem(Item item){
        return itemService.createItem(item);
    }

    public Iterable all(){

    }
}
