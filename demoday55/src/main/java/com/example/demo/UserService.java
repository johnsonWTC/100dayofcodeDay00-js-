package com.example.demo;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class UserService {
    @Autowired
    UserDao userDao;

    public User addUser(User user){
       return userDao.save(user);
    }

    public User getUserById(Integer userID) {
        return userDao.findById(userID).orElse(null);
    }
}
