package com.example.day60;

import javax.persistence.Entity;
import javax.persistence.Id;

@Entity
public class Item {

    @Id
    Integer itemID;
    String itemName;

}
