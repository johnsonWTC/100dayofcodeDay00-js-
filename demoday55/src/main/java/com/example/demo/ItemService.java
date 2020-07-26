package com.example.demo;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ItemService {

    @Autowired
    ItemDao itemDao;

    public void deleteItem(Item item){
        itemDao.delete(item);
    }

    public Item createItem(Item item){
        return  itemDao.save(item);
    }

    public  Item findItem(Integer itemID){
        return itemDao.findById(itemID).orElse(null);
    }

    public Iterable findAll(){
       return itemDao.findAll();
    }

}
