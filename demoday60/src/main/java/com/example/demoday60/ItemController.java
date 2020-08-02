package com.example.demoday60;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("Users")
public class ItemController {

    @Autowired
    ItemService itemService;

    @PostMapping("create")
    public User createUser(User user){
    return itemService.createUser(user);
    }

    @GetMapping("all")
    public

}
