﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Busskort.Models
{
    public class DropdownList
    {
        public List<SelectListItem> GetYearDropDown()
        {
            // Creating list with values
            List<SelectListItem> dropdownList = new List<SelectListItem>()
            {
                new SelectListItem { Text = "1", Value = "1" },
                new SelectListItem { Text = "2", Value = "2" },
                new SelectListItem { Text = "3", Value = "3" },
                new SelectListItem { Text = "4", Value = "4" },
                new SelectListItem { Text = "5", Value = "5" },
                new SelectListItem { Text = "6", Value = "6" },
                new SelectListItem { Text = "7", Value = "7" },
                new SelectListItem { Text = "8", Value = "8" },
                new SelectListItem { Text = "9", Value = "9" }
            };

            return dropdownList;
        }

        // Create beviljad dropdown
        public List<SelectListItem> GetBeviljadDropDown()
        {
            // Creating list with values
            List<SelectListItem> dropdownList = new List<SelectListItem>()
            {
                 new SelectListItem { Text = "N/A", Value = "N/A" },
                new SelectListItem { Text = "Ja", Value = "Ja" },
                new SelectListItem { Text = "Nej", Value = "Nej" }
            };

            return dropdownList;
        }

        // Used in Edit and Delete to get selected dropdown value
        public List<SelectListItem> GetSelectedValueFromDropDownYear(int SelectedValueÅrskurs)
        {
            //Creating generic list
            List<SelectListItem> dropdownList = new List<SelectListItem>();
            dropdownList = GetYearDropDown();

            // Loop each item until selected value is found
            foreach (var item in dropdownList)
            {
                // If value is selected, set true 
                if(item.Value == SelectedValueÅrskurs.ToString())
                {
                    item.Selected = true; 
                }
            }
            return dropdownList;
        }

        // Used in Edit and Delete to get selected dropdown value
        public List<SelectListItem> GetSelectedValueFromBeviljadDropDown(string SelectedValueBeviljad)
        {
            //Creating generic list
            List<SelectListItem> dropdownList = new List<SelectListItem>();
            dropdownList = GetBeviljadDropDown();

            // Loop each item until selected value is found
            foreach (var item in dropdownList)
            {
                // If value is selected, set true 
                if (item.Value == SelectedValueBeviljad.ToString())
                {
                    item.Selected = true;
                }
            }
            return dropdownList;
        }
    }
}