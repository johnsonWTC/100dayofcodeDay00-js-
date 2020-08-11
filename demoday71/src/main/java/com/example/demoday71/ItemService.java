package com.example.demoday71;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ItemService {

    @Autowired
    private ItemDao itemDao;

    public  Item createItem(Item item){
        return itemDao.save(item);
    }

    public Iterable findItemsByID(){
        return itemDao.findAll();
    }



}
