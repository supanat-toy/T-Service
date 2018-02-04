using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;
using T_Service.Data;

namespace T_Service.Functions
{
    public class qCelebrity : FunctionsHelper
    {
        public qCelebrity(T_ServiceContext db) : base(db) { }

        public List<cMember> getList(){
            var memberList = new List<cMember>();
            memberList = _db.Members.ToList();
            return memberList;
        }

        // public mCelebrity getDetails(long id){
        //     var celebrity = new mCelebrity();
        //     return celebrity;
        // }

        // public void insertDB(mCelebrity celebrity){

        // }

        // public void updateDB(long id, mCelebrity celebrity){

        // }
    }
}