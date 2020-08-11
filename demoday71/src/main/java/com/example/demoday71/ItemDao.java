package com.example.demoday71;

import org.springframework.data.repository.CrudRepository;

public interface ItemDao extends CrudRepository<Item,Integer> {
}
