package com.example.day70crud;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ServiceItem {

    @Autowired
    private  ItemDao itemDao;

    public Item createItem(Item item){
        return itemDao.save(item);
    }

    public void deleteItem(Integer itemID){
        itemDao.deleteById(itemID);
    }

    public Iterable findAll(){
        return itemDao.findAll();
    }

    public Item updateItem(Integer itemID, String newItemName){
        Item item = itemDao.findById(itemID).orElse(null);
        item.setItemName(newItemName);
        return itemDao.save(item);

    }
}
