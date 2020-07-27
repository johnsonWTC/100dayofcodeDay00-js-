package com.example.crudday55;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class Itemservice {

    @Autowired
    ItemDao itemDao;

    public Item createItem(Item item){
        return itemDao.save(item);
    }

    public Iterable findAll (){
        return itemDao.findAll();
    }

    public void deleteItem(Integer itemId){
        itemDao.deleteById(itemId);
    }

}
