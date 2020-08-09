package com.example.demoday65;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ItemService {

    @Autowired
    private ItemDao itemDao;

    public Item createItem(Item item){
        return itemDao.save(item);
    }

    public Iterable findAllItems(){
        return itemDao.findAll();
    }

    public void deleteItem(Integer itemID){
        itemDao.deleteById(itemID);
    }

    public Item updateItem(Integer itemId, String newItemName){

    }
}
