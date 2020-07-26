package com.example.demo;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("users")
public class UserController {

    @Autowired
    UserService userService;

    @PostMapping("add")
    public User addUser(User user){
        return userService.addUser(user);
    }

    @GetMapping("{userID}")
    public  User getUserById(@PathVariable("userID") Integer userID){
        return userService.getUserById(userID);
    }
}
