package com.example.demoday90;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("items")
public class itemController {

    @Autowired
    private ItemService itemService;
    @PostMapping("create")
    public  Item createItem(Item item){
        return itemService.createItem(item);
    }

    @GetMapping("all")
    public Iterable all(){
        return itemService.findAll();
    }

    @DeleteMapping("delete/{itemID}")
    public void deleteItemById(@PathVariable("itemID") Integer itemID){
        itemService.deleteItemById(itemID);
    }

    @PutMapping("{itemID}/{newItemName}")
    public Item updateItem(@PathVariable("itemID") Integer itemID,@PathVariable("newItemName") String newItemName){
        return  itemService.updateItem(itemID,newItemName);
    }


}
