package com.example.crud53;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ItemService {

    @Autowired
    Itemdao itemdao;

    public Item createItem(Item item){
        return itemdao.save(item);
    }

    public Item findItemById(Integer itemId){
        return  itemdao.findById(itemId).orElse(null);
    }

    public Item updateItemByID(Integer itemId, String newItemName){
        Item item = itemdao.findById(itemId).orElse(null);
        item.setItemName(newItemName);
        return  itemdao.save(item);
    }
}
