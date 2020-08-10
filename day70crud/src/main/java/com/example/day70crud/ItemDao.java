package com.example.day70crud;

import org.springframework.data.repository.CrudRepository;

public interface ItemDao extends CrudRepository<Item,Integer> {
}
