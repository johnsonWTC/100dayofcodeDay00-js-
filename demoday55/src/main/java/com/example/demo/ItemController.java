package com.example.demo;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("items")
public class ItemController {

    @Autowired
    ItemService itemService;



    @PostMapping("/create")
    public  Item createItem(Item item){
        return itemService.createItem(item);
    }


    @DeleteMapping("{itemId}")
    public void deleteItem(@PathVariable("itemId") Integer itemId){
        itemService.deleteItem(itemId);
    }

    @GetMapping("/all")
    public Iterable findall(){
       return itemService.findAll();
    }


}
