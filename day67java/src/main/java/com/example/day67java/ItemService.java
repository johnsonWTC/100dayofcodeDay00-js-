package com.example.day67java;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.web.bind.annotation.GetMapping;

@Service
public class ItemService {

    @Autowired
    ItemDao itemDao;

    public Item createItem(Item item){
        return itemDao.save(item);
    }

    public Item findItem(Integer id){
        return itemDao.findById(id).orElse(null);
    }

    public Item editByName(Integer itemId,String newItemName){
        Item item;
        item = itemDao.findById(itemId).orElse(null);
        item.setItemName(newItemName);
        itemDao.save(item);
        return item;
    }
    public void deleteItem(Integer itemId){
        itemDao.deleteById(itemId);
        return;
    }

    @GetMapping("find")
    public Iterable findAll(){
        return itemDao.findAll();
    }
}
