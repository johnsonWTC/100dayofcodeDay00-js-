package com.example.restful;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("api/tickets")
public class TickingBookingController {

    @Autowired
    private ticketBookingService ticketBookingService;

    @PostMapping("/create")
    public Ticket createTicket(Ticket ticket){
            return ticketBookingService.createTicket(ticket);
    }

    @GetMapping("/{ticketId}")
    public  Ticket getTicketById(@PathVariable("ticketId") Integer ticketId){
        return ticketBookingService.getTicketId(ticketId);
    }
}
