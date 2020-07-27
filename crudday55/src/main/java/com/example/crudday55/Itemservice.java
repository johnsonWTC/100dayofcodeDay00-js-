package com.example.crudday55;

import org.springframework.stereotype.Service;

@Service
public class Itemservice {

    ItemDao itemDao;

    public Item createItem(Item item){
        return itemDao.save(item);
    }

    public Iterable findAll (){
        return itemDao.findAll();
    }

}
