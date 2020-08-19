package com.example.demosoon;


import org.springframework.stereotype.Service;

@Service
public class UserService {

    private  UserDao userDao;

    public  User CreateUser(User user){
        return userDao.save(user);
    }
}
