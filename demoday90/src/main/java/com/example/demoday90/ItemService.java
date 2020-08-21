package com.example.demoday90;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ItemService {

    @Autowired
    private ItemDao itemDao;

    public Item createItem(Item item) {
        return itemDao.save(item);
    }

    public  Iterable findAll(){
        return itemDao.findAll();
    }

    public void deleteItemById(Integer itemID){
        itemDao.deleteById(itemID);
    }

    public Item updateItem(Integer itemID,String ItemName){
        Item item = itemDao.findById(itemID).orElse(null);

    }

}
