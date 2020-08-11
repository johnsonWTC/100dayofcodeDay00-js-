package com.example.demoday71;


import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
public class Item {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    Integer itemID;
    String userName;
    String primaryRole;
    String BusinessUnitName;
    String PracticeName;

    public Integer getItemID() {
        return itemID;
    }

    public void setItemID(Integer itemID) {
        this.itemID = itemID;
    }

    public String getUserName() {
        return userName;
    }

    public void setUserName(String userName) {
        this.userName = userName;
    }

    public String getPrimaryRole() {
        return primaryRole;
    }

    public void setPrimaryRole(String primaryRole) {
        this.primaryRole = primaryRole;
    }

    public String getBusinessUnitName() {
        return BusinessUnitName;
    }

    public void setBusinessUnitName(String businessUnitName) {
        BusinessUnitName = businessUnitName;
    }

    public String getPracticeName() {
        return PracticeName;
    }

    public void setPracticeName(String practiceName) {
        PracticeName = practiceName;
    }
}
