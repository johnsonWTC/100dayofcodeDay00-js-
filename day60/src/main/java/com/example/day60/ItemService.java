package com.example.day60;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ItemService {

    @Autowired
    ItemDoa itemDoa;

    public Item createItem(Item item){
        return itemDoa.save(item);
    }

    public Item editItem(Integer itemID, String oldItamName){
        Item item = itemDoa.findById(itemID).orElse(null);
        item.setItemName(oldItamName);
        return itemDoa.save(item);
    }

    public Iterable findAll(){
        return itemDoa.findAll();
    }
}
