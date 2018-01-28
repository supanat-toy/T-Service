using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;

namespace T_Service.Functions
{
    public class qUser : FunctionsHelper
    {
        public List<mUser> getList(){
            var userList = new List<mUser>();
            return userList;
        }

        public mUser getDetails(long id){
            var user = new mUser();
            return user;
        }

        public void insertDB(mUser customer){

        }

        public void updateDB(long id, mUser customer){

        }
    }
}