package com.example.restful;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ticketBookingService {
    @Autowired
    private  TicketBookingDoa ticketBookingDoa;

    public Item createItem(Item item){
        return ticketBookingDoa.save(item);
    }

    public Item getItemById(Integer itemId){
        return ticketBookingDoa.findById(itemId).orElse(null);
    }
    public void deleteItemById(Integer itemId){
        ticketBookingDoa.deleteById(itemId);
    }

    public Iterable getAllItems(){
       return ticketBookingDoa.findAll();
    }
}
