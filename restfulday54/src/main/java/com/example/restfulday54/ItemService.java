package com.example.restfulday54;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ItemService {
    @Autowired
    ItemDao itemDao;

    public Item createItem(Item item){
        return itemDao.save(item);
    }

    public void deleteItem(Item item){
        itemDao.delete(item);
    }

    public Item updateItem(Integer itemId, String itemName){
        Item item = itemDao.findById(itemId).orElse(null);
        item.setItemName(itemName);
        return itemDao.save(item);
    }

    public Item findbyId(Integer itemId){
        return itemDao.findById(itemId).orElse(null);
    }
}
