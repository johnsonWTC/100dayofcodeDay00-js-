package com.example.daycrud63;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class UserService {

    @Autowired
    UserDao userDao;

    public User createUser(User user){
        userDao.save(user);
    }
}
