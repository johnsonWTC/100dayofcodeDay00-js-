package com.example.day62;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;

@Entity
public class User {


    @Id
            @GeneratedValue
    Integer userID;
    String userName;
    String Name;
    String Surname;

}
