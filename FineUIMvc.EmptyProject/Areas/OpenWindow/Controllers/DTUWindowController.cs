﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FineUIMvc.PumpMVC.Controllers;
using FineUIMvc.PumpMVC.DAL;
using FineUIMvc.PumpMVC.Models;
using System.Collections;
using Newtonsoft.Json.Linq;

namespace FineUIMvc.PumpMVC.Areas.OpenWindow.Controllers
{
    [Authorize]
    public class DTUWindowController : Controller
    {
        //
        // GET: /OpenWindow/DTUWindow/
        [MyAuth(MenuPower = "CoreDTUView")]
        public ActionResult Index()
        {
            Hashtable table = Dtu_BaseDal.Search(0, 20, "B_Number", "ASC", " and B_IsUsed=0");
            ViewBag.Grid1DataSource = table["data"];
            ViewBag.Grid1RecordCount = Int32.Parse(table["total"].ToString());
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Grid1_PageIndexChanged(JArray Grid1_fields, int Grid1_pageIndex, int gridPageSize, string searchMessage)
        {
            var Grid1 = UIHelper.Grid("Grid1");

            string sql = " and B_IsUsed=0";

            if (!searchMessage.Equals(""))
            {
                sql = sql + " and B_Number like '%" + searchMessage + "%'";
            }
            Hashtable table = Dtu_BaseDal.Search(Grid1_pageIndex, gridPageSize, "B_Number", "ASC", sql);
            Grid1.DataSource(table["data"], Grid1_fields);
            Grid1.RecordCount(Int32.Parse(table["total"].ToString()));

            return UIHelper.Result();
        }

        private void UpdateGrid(JArray Grid1_fields, int gridIndex, int gridPageSize)
        {
            var Grid1 = UIHelper.Grid("Grid1");
            string sql = " and B_IsUsed=0";

            //sql = sql + " and FDictID = " + Grid1_selectedRows;
            Hashtable table = Dtu_BaseDal.Search(gridIndex, gridPageSize, "B_Number", "ASC", sql);
            Grid1.DataSource(table["data"], Grid1_fields);
            Grid1.RecordCount(Int32.Parse(table["total"].ToString()));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MyCustomPostBack(string type, JArray gridFields, JObject typeParams, int gridIndex, int gridPageSize)
        {
            var Grid1 = UIHelper.Grid("Grid1");
            string sql = " and B_IsUsed=0";
            var ttbSearch = UIHelper.TwinTriggerBox("ttbSearchMessage");
            if (type == "trigger1")
            {
                ttbSearch.Text(" and B_IsUsed=0");
                ttbSearch.ShowTrigger1(false);
            }
            else if (type == "trigger2")
            {
                ttbSearch.ShowTrigger1(true);
                var triggerValue = typeParams.Value<string>("triggerValue");
                sql = " and B_Number like '%" + triggerValue + "%'";
            }

            Hashtable table = Dtu_BaseDal.Search(gridIndex, gridPageSize, "B_Number", "ASC", sql);
            Grid1.DataSource(table["data"], gridFields);
            Grid1.RecordCount(Int32.Parse(table["total"].ToString()));
            Grid1.PageSize(gridPageSize);
            return UIHelper.Result();
        }
	}
}