package com.example.restful;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class TickingBookingController {

    @Autowired
    private ticketBookingService ticketBookingService;
    public Ticket createTicket(Ticket ticket){
            return ticketBookingService.createTicket(ticket);
    }
}
