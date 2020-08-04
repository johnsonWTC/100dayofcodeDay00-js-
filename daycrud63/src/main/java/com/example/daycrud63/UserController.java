package com.example.daycrud63;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("Users")
public class UserController {

    UserService userService;

    @GetMapping("create")
    public createUser(User user){
        return userService.createUser(user);
    }
}
