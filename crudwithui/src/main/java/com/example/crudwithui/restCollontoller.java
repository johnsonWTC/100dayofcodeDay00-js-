//package com.example.crudwithui;
//
//import org.springframework.web.bind.annotation.*;
//
//@RestController
//public class restCollontoller {
//
//    UserService userService;
//
//    @PostMapping("create")
//    public User createUser(User user){
//
//        return userService.createUser(user);
//    }
//
//    @GetMapping("{userId}")
//    public User getUserById(@PathVariable("userId") Integer userId){
//
//        return userService.findUser(userId);
//    }
//}