package com.example.daycrud63;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("Users")
public class UserController {

    UserService userService;

    @PostMapping("create")
    public User createUser(User user){
        return userService.createUser(user);
    }

    public Iterable all(){
        return userService.users();
    }
}
