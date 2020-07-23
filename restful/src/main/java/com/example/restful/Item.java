package com.example.restful;

import javax.persistence.*;

@Entity
public class Item {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer itemId;

    public Integer getItemId() {
        return itemId;
    }

    public void setItemId(Integer ticketId) {
        this.itemId = ticketId;
    }

    public String getItemName() {
        return itemName;
    }

    public void setItemName(String passengerName) {
        this.itemName = passengerName;
    }

    private String itemName;
}
