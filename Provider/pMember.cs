using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Service.Models;
using T_Service.Data;
using T_Service.Functions;

namespace T_Service.Providers
{
    public class pMember : FunctionsHelper
    {
        public pMember(T_ServiceContext db) : base(db) { }

        public List<mMember> getList(){
            List<cMember> cMemberList = _db.Members.ToList();
            var memberList = cMemberList.Select(x => new mMember(){
                isAdmin = false,
                member = x
            }).ToList();
            // List<mMember> memberList = dataList.

            return memberList;
        }

        public mMember getDetails(string email)
        {
            var cMember = _db.Members.Where(x=>x.email == email).FirstOrDefault();
            var cBook_addressList = _db.MemberBookAddresses.Where(x=>x.member_email == email).ToList();
            mMember member = new mMember(){
                isAdmin = false,
                member = cMember,
                book_addressList = cBook_addressList
            };

            return member;
        }




        // public List<mCustomer> getList(){
        //     var customerList = new List<mCustomer>();
        //     return customerList;
        // }

        // public mCustomer getDetails(long id){
        //     var customer = new mCustomer();
        //     return customer;
        // }

        // public void insertDB(mCustomer customer){

        // }

        // public void updateDB(long id, mCustomer customer){
            
        // }
    }
}