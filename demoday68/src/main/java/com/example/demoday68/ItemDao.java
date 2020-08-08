package com.example.demoday68;

import org.springframework.data.repository.CrudRepository;

public interface ItemDao extends CrudRepository<Item,Integer> {
}
