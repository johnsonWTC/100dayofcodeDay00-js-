package com.example.demoday60;

import org.springframework.data.repository.CrudRepository;

public interface ItemDao extends CrudRepository<User,Integer> {
}
