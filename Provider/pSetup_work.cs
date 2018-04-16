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
    public class pSetup_work : IpSetup_work
    {
        protected readonly T_ServiceContext _db;
        public pSetup_work(T_ServiceContext db) 
        {
            _db = db;
        }

        public List<cList_Tservice_type> getServiceList() {
            var list = _db.ListTserviceTypes.ToList();
            return list;
            // return new List<cList_Tservice_type>();
        }

        #region CGUD
        public List<mSetup_work> getList(){
            
            var cSetup_work = _db.SetupWorks.OrderByDescending(x=>x.created_datetime).ToList();
            var setup_workList = cSetup_work.Select(x=> new mSetup_work(){
               setup_work = x 
            }).ToList();

            return setup_workList;
        }

        public mSetup_work getDetails(string email)
        {
            var cSetup_work = _db.SetupWorks.Where(x=>x.member_email == email).FirstOrDefault();
            var setup_productList = _db.SetupProducts.Where(x=>x.setup_work_id == cSetup_work.setup_work_id).Select(x => new mSetup_product(){
                setup_product = x,
                setup_product_accessoryList = new List<cSetup_product_accessory>()
            }).ToList();
            var cSetup_product_accessoryList = _db.SetupAccessoryProducts.Where(x=>x.setup_work_id == cSetup_work.setup_work_id).ToList();

            for (int i = 0; i < setup_productList.Count; i++)
            {
                setup_productList[i].setup_product_accessoryList = cSetup_product_accessoryList.Where(x=>x.setup_work_id == cSetup_work.setup_work_id).ToList();
            }

            // var member = _service._pMember.getDetails(email);

            var setup_work = new mSetup_work() 
            {
                setup_work = cSetup_work,
                setup_productList = setup_productList,
                // member = member.member
            };

            return setup_work;
        }
        public mResult insert(mSetup_work setup) {
            var result = new mResult() 
            {
                isSucceed = true,
                // message = _wording.insertedDB_succeed
            };

            setup.setup_work.created_datetime = DateTime.Now;
            setup.setup_work.updated_datetime = DateTime.Now;
            setup.setup_work.isCancelled = false;
            setup.setup_work.Tservice_type_id = 1; // unfinished
            _db.SetupWorks.Add(setup.setup_work);
           _db.SaveChanges();

            var added_setup_work_id =(_db.SetupWorks.Where(x=>x.member_email == setup.member.email).LastOrDefault() ?? new cSetup_work()).setup_work_id;

            foreach (var setup_product in setup.setup_productList) {
                setup_product.setup_product.setup_work_id = added_setup_work_id;
                setup_product.setup_product.updated_datetime = DateTime.Now;
                setup_product.setup_product.created_datetime = DateTime.Now;
                setup_product.setup_product.isCancelled = false;
                _db.SetupProducts.Add(setup_product.setup_product); 
            }
            _db.SaveChanges();


            var added_setup_productList = _db.SetupProducts.Where(x=>x.setup_work_id == added_setup_work_id).ToList();
            foreach (var setup_product in setup.setup_productList) {
                var setup_product_id = (added_setup_productList.Where(x=>x.product_code == setup_product.setup_product.product_code).FirstOrDefault() ?? new cSetup_product()).setup_product_id;
                foreach (var product_accessory in setup_product.setup_product_accessoryList) {
                    product_accessory.setup_work_id = added_setup_work_id;
                    product_accessory.setup_product_id = setup_product_id;
                    product_accessory.updated_datetime = DateTime.Now;
                    product_accessory.created_datetime = DateTime.Now;
                    product_accessory.isCancelled = false;
                    _db.SetupAccessoryProducts.Add(product_accessory);
                }
            }
            
            try {
                _db.SaveChanges();
            } catch (Exception e) {
                result = new mResult() {
                    isSucceed = false,
                    message = e.Message
                };
            }
            return result;
        } 

        public mResult update(long id, mSetup_work setup) {
            var result = new mResult() 
            {
                isSucceed = true,
                // message = _wording.updatedDB_succeed
            };

            var cSetup_work = _db.SetupWorks.Where(x=>x.setup_work_id == setup.setup_work.setup_work_id).FirstOrDefault();
            if (cSetup_work != null) {
                cSetup_work.isCancelled = setup.setup_work.isCancelled;
                cSetup_work.receipt_number = setup.setup_work.receipt_number;
                cSetup_work.remark_employee = setup.setup_work.remark_employee;
                cSetup_work.remark_member = setup.setup_work.remark_member;
                cSetup_work.setup_appointed_datetime = setup.setup_work.setup_appointed_datetime;
                cSetup_work.setup_finished_datetime = setup.setup_work.setup_finished_datetime;
                cSetup_work.setup_price = setup.setup_work.setup_price;
                cSetup_work.signature_customer_image_url = setup.setup_work.signature_customer_image_url;
                cSetup_work.updated_datetime = DateTime.Now;

                // ---- Update Product List ---
                // ใหม่ ไม่เจอเก่า --> เพิ่มเข้าไป DB
                // เก่า ไม่เจอใหม่ --> ลบ
                // ถ้าเจอ --> อัพเดท
                var cSetup_productList = _db.SetupProducts.Where(x=>x.setup_work_id == cSetup_work.setup_work_id).ToList();
                var cSetup_accessory_productList = _db.SetupAccessoryProducts.Where(x=>x.setup_work_id == cSetup_work.setup_work_id).ToList();
                var alreadyAdded_product_index = new List<int>();
                foreach (var cSetup_product in cSetup_productList) {
                    int index = setup.setup_productList.FindIndex(x=>x.setup_product.product_code == cSetup_product.product_code);
                    alreadyAdded_product_index.Add(index);
                    if (index != -1) { // ถ้าเจอ --> อัพเดท
                        var setup_product = setup.setup_productList[index].setup_product;
                        cSetup_product.isCancelled = setup_product.isCancelled;
                        cSetup_product.nameEN = setup_product.nameEN;
                        cSetup_product.nameTH = setup_product.nameTH;
                        cSetup_product.product_code = setup_product.product_code;
                        cSetup_product.quantity_number = setup_product.quantity_number;
                        cSetup_product.updated_datetime = DateTime.Now;

                        _db.SetupProducts.Update(cSetup_product);
                    }
                    // else 
                    // {
                        
                    // }
                    // if (index == -1) { // ใหม่ ไม่เจอเก่า --> เพิ่มเข้าไป DB
                    //     var remove_cSetup_accessory_productList = cSetup_accessory_productList.Where(x=>x.setup_product_id == cSetup_product.setup_product_id).ToList();
                    //     cSetup_accessory_productList.Except(remove_cSetup_accessory_productList);
                    //     _db.SetupProducts.Remove(cSetup_product);
                    //     _db.SetupAccessoryProducts.RemoveRange(remove_cSetup_accessory_productList);
                    // } 
                    // if () {
                        
                    // }
                    // else 
                    // {
                        
                    // }
                }

                for(int i = 0; i < setup.setup_productList.Count; i++) 
                {
                    if (!alreadyAdded_product_index.Contains(i))
                    {
                        var setup_product = setup.setup_productList[i].setup_product;
                        _db.SetupProducts.Add(setup_product);
                    }
                }

                // ----- Update Product Accessory List --------

                
                // var alreadyAdded_accessory_productList = new List<int>();
                // foreach (var setup_accessory_product in cSetup_accessory_productList)
                // {
                //     int index = setup.
                // }


                try {
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

        public mResult delete(long id) {
            var result = new mResult() 
            {
                isSucceed = true,
                // message = _wording.deletedDB_succeed
            };
            var deliveryWork = _db.DeliveryWorks.Where(x=>x.delivery_work_id == id).FirstOrDefault();
            if (deliveryWork != null) {
                deliveryWork.isCancelled = true;
                try {
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
        #endregion
    
        public List<cList_setup_product_main> getSetupProductMainList(int setup_work_product_type_id = 0)
        {
            var cSetupProductMainList = _db.ListSetupMainProducts.Where(x=>x.setup_product_main_id == setup_work_product_type_id).ToList();
            return cSetupProductMainList;
        }

        public List<cList_setup_product_accessory> getSetupProductAccessoryList(int setup_work_product_type_id = 0) 
        {
            var cSetupAccessoryProductList =  _db.ListSetupAccessoryProducts.Where(x=>x.setup_work_product_type_id == setup_work_product_type_id).ToList();
            return cSetupAccessoryProductList;
        }

    }
}