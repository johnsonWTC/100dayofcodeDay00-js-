package com.example.restful;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ticketBookingService {
    @Autowired
    private  TicketBookingDoa ticketBookingDoa;

    public Ticket createTicket(Ticket ticket){
        return ticketBookingDoa.save(ticket);
    }

    public Ticket getTicketId(Integer ticketId){
        return ticketBookingDoa.findById(ticketId).orElse(null);
    }

}
