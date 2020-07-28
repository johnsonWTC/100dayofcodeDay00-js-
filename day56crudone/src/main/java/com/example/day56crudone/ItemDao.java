package com.example.day56crudone;

import org.springframework.data.repository.CrudRepository;

public interface ItemDao extends CrudRepository <Item,Integer> {
}
