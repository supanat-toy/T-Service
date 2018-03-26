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
    public class pMemberBookAddress : FunctionsHelper
    {
        public pMemberBookAddress(T_ServiceContext db) : base(db) { }

        public mResult insertDB(cMember_book_address memberBookAddress) 
        {
            var result = new mResult()
            {
                isSucceed = true,
                message = _wording.insertedDB_succeed
            };

            if (TryValidateModel(memberBookAddress))
            {
                try {
                    _db.MemberBookAddresses.Add(memberBookAddress);
                    _db.SaveChanges();
                } catch (Exception e) {
                    result = new mResult() 
                    {
                        isSucceed = false,
                        message = e.Message
                    };
                }
            }
            return result;
        } 
    }
}