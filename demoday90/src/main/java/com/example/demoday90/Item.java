package com.example.demoday90;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
public class Item {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    Integer iteID;
    String itemName;

    public Integer getIteID() {
        return iteID;
    }

    public void setIteID(Integer iteID) {
        this.iteID = iteID;
    }

    public String getItemName() {
        return itemName;
    }

    public void setItemName(String itemName) {
        this.itemName = itemName;
    }
}
