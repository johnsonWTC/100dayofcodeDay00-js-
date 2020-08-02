package com.example.demoday60;


import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("Users")
public class ItemController {

    ItemService itemService;
}
