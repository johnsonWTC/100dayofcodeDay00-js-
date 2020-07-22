package com.example.restful;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface TicketBookingDoa extends CrudRepository<Ticket,Integer> {
}
