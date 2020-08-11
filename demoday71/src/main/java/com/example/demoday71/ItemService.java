package com.example.demoday71;

import org.springframework.stereotype.Service;

@Service
public class ItemService {

    private ItemDao itemDao;

    public  Item createItem(Item item){
        return itemDao.save(item);
    }

    public Iterable findItemsByID(){
        return itemDao.findAll();
    }



}
