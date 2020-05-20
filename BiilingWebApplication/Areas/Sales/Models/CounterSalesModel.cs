﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using TradeSuiteApp.Web.Areas.Masters.Models;
//using BusinessObject;
//using BiilingWebApplication.Web.Utils;

namespace BiilingWebApplication.Areas.Sales.Models
{
    public class CounterSalesModel
    {
        public long ID { get; set; }
        public string TransNo { get; set; }
        public string TransDate { get; set; }
        public int PatientID { get; set; }
        public string PatientCode { get; set; }
        public string PartyName { get; set; }
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public int WarehouseID { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal DiscountAmt { get; set; }
        public decimal TaxableAmt { get; set; }
        public bool IsDraft { get; set; }
        public decimal SGSTAmount { get; set; }
        public decimal CGSTAmount { get; set; }
        public decimal IGSTAmount { get; set; }
        public decimal RoundOff { get; set; }
        public decimal NetAmount { get; set; }
        public decimal BalanceAmount { get; set; }
        public bool IsCancelled { get; set; }
        public string Remarks { get; set; }
        public DateTime? CancelledDate { get; set; }
        public string WarehouseName { get; set; }
        public decimal PackingPrice { get; set; }
        public int StateID { get; set; }
        public int BatchTypeID { get; set; }
        public string Sex { get; set; }
        public string Status { get; set; }
        public int FullOrLooseID { get; set; }
        public int UnitID { get; set; }
        public int PaymentModeID { get; set; }
        public decimal TotalAmountReceived { get; set; }
        public decimal BalanceToBePaid { get; set; }
        public decimal CessAmount { get; set; }
        public int LocationStateID { get; set; }
        public int SalesCategoryID { get; set; }
        public string SalesCategoryName { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string GSTNo { get; set; }
        public string NetAmountInWords { get; set; }
        public int LocationID { get; set; }
        //public List<CountrSalesItemsModel> Items { get; set; }

        public List<CounterSalesAmountDetails> AmountDetails { get; set; }
        public SelectList CustomerTypeList { get; set; }
        public SelectList ItemCategoryList { get; set; }
        public SelectList WarehouseList { get; set; }
        public SelectList BatchList { get; set; }
        public SelectList FullLooseList { get; set; }
        public SelectList PatientSexList { get; set; }
        public SelectList UnitList { get; set; }
        public SelectList PaymentModeList { get; set; }
        public SelectList SalesCategoryList { get; set; }
        public SelectList LocationList { get; set; }
        public SelectList CounterSalesTypeList { get; set; }
        public SelectList BankList { get; set; }
        //public List<CategoryBO> DiscountPercentageList { get; set; }
        public int BankID { get; set; }
        public int TypeID { get; set; }
        public string Type { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeID { get; set; }
        public string PatientName { get; set; }
        public decimal BalAmount { get; set; }
        public string CashSalesName { get; set; }
        public int DiscountCategoryID { get; set; }
        public string DiscountCategory { get; set; }
        public bool IsCancelable { get; set; }
        public int EmployeeCategoryID { get; set; }

        //      public List<CounterSalesAmountDetailsBO> AmountDetailsBO { get; set; }
    }
    //public class CountrSalesItemsModel : ItemModel
    //{
    //    public int CounterSalesID { get; set; }
    //    public string TransNo { get; set; }
    //    public string FullOrLoose { get; set; }
    //    public int BatchID { get; set; }
    //    public string BatchName { get; set; }
    //    public decimal Qty { get; set; }
    //    public decimal Quantity { get; set; }
    //    public decimal MRP { get; set; }
    //    public decimal GrossAmount { get; set; }
    //    public decimal DiscountPercentage { get; set; }
    //    public decimal TaxableAmount { get; set; }
    //    public decimal GSTPercentage { get; set; }
    //    public decimal SGSTAmount { get; set; }
    //    public decimal CGSTAmount { get; set; }
    //    public decimal IGSTAmount { get; set; }
    //    public decimal NetAmount { get; set; }
    //    public decimal Amount { get; set; }
    //    public int BatchTypeID { get; set; }
    //    public string BatchType { get; set; }
    //    public string Unit { get; set; }
    //    public string BatchNo { get; set; }
    //    public string ExpiryDateString { get; set; }
    //    public int WareHouseID { get; set; }
    //    public decimal CessPercentage { get; set; }
    //    public decimal CessAmount { get; set; }
    //    public decimal BasicPrice { get; set; }
    //    public decimal MinimumSalesQty { get; set; }
    //    public decimal MaximumSalesQty { get; set; }


    //}
    public class CounterSalesAmountDetails
    {
        public string Particulars { get; set; }
        public decimal Percentage { get; set; }
        public decimal Amount { get; set; }
    }
}

