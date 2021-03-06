package com.example.crud52;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ItemService {

    @Autowired
    ItemDao itemDao;

    public Item geItemByID(Integer itemID){
        return itemDao.findById(itemID).orElse(null);
    }

    public void deleteItemByID(Integer itemID){
        itemDao.deleteById(itemID);
    }
    public Item saveItem(Item item){
       return itemDao.save(item);
    }

    public  Item UpdateById(Integer itemId, String newItemName){
        Item item = itemDao.findById(itemId).orElse(null);
        item.setItemName(newItemName);
        return itemDao.save(item);

    }


}
