package com.example.day70crud;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ServiceItem {

    @Autowired
    private  ItemDao itemDa;

    public Item createItem(Item item){

    }
}
