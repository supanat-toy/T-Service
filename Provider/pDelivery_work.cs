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
    public class pDelivery_work : FunctionsHelper
    {
        public List<mDelivery_work> getList()
        {
            var cDelivery_workList = _db.DeliveryWorks.OrderByDescending(x=>x.created_datetime).ToList();
            var delivery_workList = cDelivery_workList.Select(x=> new mDelivery_work(){
                delivery_work = x,
            }).ToList();

            return delivery_workList;
        }

        public mDelivery_work getDetails(string email)
        {
            var cDelivery_work = _db.DeliveryWorks.Where(x=>x.member_email == email).FirstOrDefault();
            var delivery_productList = _db.DeliveryProducts.Where(x=>x.delivery_work_id == cDelivery_work.delivery_work_id).ToList();
            // var member = _service._pMember.getDetails(email);
            var delivery_work = new mDelivery_work()
            {
                delivery_work = cDelivery_work,
                delivery_productList = delivery_productList,
                // member = member.member
            };

            return delivery_work;
        }

        public mResult insert(mDelivery_work delivery) {
            var result = new mResult() 
            {
                isSucceed = true,
                message = _wording.insertedDB_succeed
            };

            delivery.delivery_work.created_datetime = DateTime.Now;
            delivery.delivery_work.updated_datetime = DateTime.Now;
            delivery.delivery_work.isCancelled = false;
            delivery.delivery_work.Tservice_type_id = 1; // unfinished
            _db.DeliveryWorks.Add(delivery.delivery_work);
            
            foreach (var delivery_product in delivery.delivery_productList) {
                delivery_product.updated_datetime = DateTime.Now;
                delivery_product.created_datetime = DateTime.Now;
                delivery_product.isCancelled = false;
                _db.DeliveryProducts.Add(delivery_product);
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

        public mResult update(long id, mDelivery_work delivery) {
            var result = new mResult() 
            {
                isSucceed = true,
                message = _wording.updatedDB_succeed
            };

            var cDelivery_work = _db.DeliveryWorks.Where(x=>x.delivery_work_id == id).FirstOrDefault();
            if (cDelivery_work != null) {
                cDelivery_work.delivery_address_amphur_id = delivery.delivery_work.delivery_address_amphur_id;
                cDelivery_work.delivery_address_details = delivery.delivery_work.delivery_address_details;
                cDelivery_work.delivery_address_district_id = delivery.delivery_work.delivery_address_district_id;
                cDelivery_work.delivery_address_map_google_url = delivery.delivery_work.delivery_address_map_google_url;
                cDelivery_work.delivery_address_map_image_url = delivery.delivery_work.delivery_address_map_image_url;
                cDelivery_work.delivery_address_phone_number = delivery.delivery_work.delivery_address_phone_number;
                cDelivery_work.delivery_address_place_name = delivery.delivery_work.delivery_address_place_name;
                cDelivery_work.delivery_address_province_id = delivery.delivery_work.delivery_address_province_id;
                cDelivery_work.delivery_address_receiver_name = delivery.delivery_work.delivery_address_receiver_name;
                cDelivery_work.delivery_address_zip_code = delivery.delivery_work.delivery_address_zip_code;
                cDelivery_work.delivery_appointed_datetime = delivery.delivery_work.delivery_appointed_datetime;
                cDelivery_work.delivery_distance_kilometre = delivery.delivery_work.delivery_distance_kilometre;
                cDelivery_work.delivery_finished_datetime = delivery.delivery_work.delivery_finished_datetime;
                cDelivery_work.isCancelled = delivery.delivery_work.isCancelled;
                cDelivery_work.receipt_number = delivery.delivery_work.receipt_number;
                cDelivery_work.signature_customer_image_url = delivery.delivery_work.signature_customer_image_url;
                cDelivery_work.Tservice_work_status_id = delivery.delivery_work.Tservice_work_status_id;
                cDelivery_work.updated_datetime = DateTime.Now;

                // ---- Update Product List ---

                var cDelivery_productList = _db.DeliveryProducts.Where(x=>x.delivery_work_id == cDelivery_work.delivery_work_id).ToList();
                var alreadyAdded_deliveryProduct_index = new List<int>();
                foreach (var cDelivery_product in cDelivery_productList) {
                    int index = delivery.delivery_productList.FindIndex(x=>x.delivery_work_id == cDelivery_work.delivery_work_id && x.product_code == cDelivery_product.product_code);
                    alreadyAdded_deliveryProduct_index.Add(index);
                    if (index != -1) {
                        _db.DeliveryProducts.Remove(cDelivery_product);
                    } 
                    else 
                    {
                        var delivery_product = delivery.delivery_productList[index];
                        cDelivery_product.isCancelled = delivery_product.isCancelled;
                        cDelivery_product.nameEN = delivery_product.nameEN;
                        cDelivery_product.nameTH = delivery_product.nameTH;
                        cDelivery_product.product_code = delivery_product.product_code;
                        cDelivery_product.quantity_number = delivery_product.quantity_number;
                        cDelivery_product.updated_datetime = DateTime.Now;
                    }
                }

                for(int i = 0; i < delivery.delivery_productList.Count; i++) 
                {
                    if (!alreadyAdded_deliveryProduct_index.Contains(i))
                    {
                        var delivery_product = delivery.delivery_productList[i];
                        _db.DeliveryProducts.Add(delivery_product);
                    }
                }

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
                message = _wording.deletedDB_succeed
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
    }
}