package com.example.day62;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class UserService {

    @Autowired
    UserDao userDao;

    public User createUser(User user){
        return userDao.save(user);
    }

    public Iterable allUsers(){
        return userDao.findAll();
    }
}
