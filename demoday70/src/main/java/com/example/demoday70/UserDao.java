package com.example.demoday70;

import org.springframework.data.repository.CrudRepository;

public interface UserDao extends CrudRepository<User,Integer> {
}
