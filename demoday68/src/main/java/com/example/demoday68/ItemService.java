package com.example.demoday68;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ItemService {

    @Autowired
    private ItemDao itemDao;

    public Item createItem(Item item){
        return itemDao.save(item);
    }

    public Item updateItem(Integer itemID,String newItemName){
        Item item = itemDao.findById(itemID).orElse(null);
        item.setName(newItemName);
      return   itemDao.save(item);
    }

    public  void deleteItem(Integer itemID){
        itemDao.deleteById(itemID);
    }
}
