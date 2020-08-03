package com.example.day62;

import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("users")
public class UserController {

    UserService userService;

    @PostMapping("create")
    public User createUser(User user){
        return userService.createUser(user);
    }
}
