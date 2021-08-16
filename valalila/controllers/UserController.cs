using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using valalila.Models;

namespace valalila.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        static List<User> userList;
        static UserController()
        {
            userList = new List<User>();
            userList.Add(new User() { id = 123456789, firstName = "Chia", lastName = "Gold",
                address = "Hamem Gimel", email = "77bat7@gmail.com", gender = "female", phone = "0504120718", password = "123456789" });
            userList.Add(new User() { id = 123456789, firstName = "Shilat", lastName = "Kroizer"
                , address = "Har Nof", email = "Shilat@gmail.com", gender = "female", phone = "0504120718", password = "125874963" });
            userList.Add(new User() { id = 123456789, firstName = "Chavi", lastName = "Yudko",
                address = "Panim Mehirot", email = "Chavi@gmail.com", gender = "female", phone = "0504120718", password = "123123123" });
        }
        //[HttpGet("{id}")]
        //public User getUserById(int id)
        //{
        //    foreach (var item in userList)
        //    {
        //        if (item.id == id)
        //            return item;
        //    }
        //    return null;
        //}

        [HttpGet("{name}")]
        public User getUserByName(string name)
        {
            foreach (var item in userList)
            {
                if (item.firstName == name)
                    return item;
            }
            return null;
        }
        //[HttpGet]
        //public List<User> getUsers()
        //{

        //    return userList;
        //}
        [HttpPost("updateUser")]
        public void updateUser(User user)
        {
            foreach (var item in userList)
            {
                if (item.id == user.id) { 
                    item.firstName = user.firstName;
                    item.lastName = user.lastName;
                }
            }
            
        }
        [HttpPost]
        public void addUser(User user)
        {
            userList.Add(user);
        }
    }
}
