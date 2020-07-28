package com.example.demovb;

import org.springframework.stereotype.Service;

@Service
public class ItemService {

    ItemDao itemDao;

    public Item createItem(Item item){
        return itemDao.save(item);
    }

    public Iterable findAll(){
        return itemDao.findAll();
    }
}
