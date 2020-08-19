package com.example.demosoon;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class UserService {

    @Autowired
    private  UserDao userDao;

    public  User CreateUser(User user){
        return userDao.save(user);
    }

    public  Iterable findAll(){
        return userDao.findAll();
    }
}
