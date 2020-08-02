package com.example.demoday60;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ItemService {


    @Autowired
    ItemDao itemDao;

    public User createUser(User user){
        return itemDao.save(user);
    }

    public Iterable findAll(){
        return itemDao.findAll();
    }

}
