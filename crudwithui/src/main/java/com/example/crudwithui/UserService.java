package com.example.crudwithui;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class UserService {

    @Autowired
    UserDao userDao;

    public User createUser(User user){

        return userDao.save(user);
    }

    public  User findUser(Integer userId){

        return userDao.findById(userId).orElse(null);
    }


}
