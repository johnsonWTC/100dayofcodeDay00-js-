package com.example.crudwithui;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.servlet.ModelAndView;


@RestController
@RequestMapping("home")
public class UserController {

    @Autowired
    UserService userService;

    public String UserHomePage(){
        return ("index.html");
    }

    @PostMapping("create")
    public User createUser(User user){
        return userService.createUser(user);
    }

    @GetMapping("{userId}")
    public User getUserById(@PathVariable("userId") Integer userId){
        return userService.findUser(userId);
    }
}
