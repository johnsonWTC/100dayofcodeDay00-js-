package com.example.myapi;


import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@Repository
public class ItemDoa extends CrudRepository <item, Integer>{
}
