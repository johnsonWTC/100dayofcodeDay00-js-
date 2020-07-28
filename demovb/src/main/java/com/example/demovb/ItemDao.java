package com.example.demovb;

import org.springframework.data.repository.CrudRepository;

public interface ItemDao  extends CrudRepository<Item,Integer> {
}
