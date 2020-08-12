package com.example.demoday75;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class UserService {

    @Autowired
    private UserDao userDao;

    public User createUser(User user){
        return userDao.save();
    }
}
