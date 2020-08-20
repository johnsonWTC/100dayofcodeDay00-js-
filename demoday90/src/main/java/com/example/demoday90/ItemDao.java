package com.example.demoday90;

import org.springframework.data.repository.CrudRepository;

public interface ItemDao extends CrudRepository<Item,Integer> {
}
