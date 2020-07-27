package com.example.crudday55;

import org.springframework.data.repository.CrudRepository;

public interface ItemDao extends CrudRepository<Item,Integer> {
}
