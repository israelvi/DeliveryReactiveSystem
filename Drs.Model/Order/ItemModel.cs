﻿using System;
using System.Collections.Generic;

namespace Drs.Model.Order
{
    public class ItemModel
    {
        private string _name;
        public long ItemId { get; set; }

        public string Name
        {
            get
            {
                if(String.IsNullOrWhiteSpace(_name) || Level == 0) 
                    return _name;
                

                return _name.Insert(0, String.Empty.PadLeft((int)Level * Constants.SharedConstants.LEVEL_PAD_ITEM, ' '));
            }
            set
            {
                _name = value;
            }
        }

        public string RealName
        {
            get
            {
                return String.IsNullOrWhiteSpace(_name) ? String.Empty : _name.Trim();
            }
        }

        public bool IsIdSpecified { get; set; }
        public double Price { get; set; }
        public ItemModel Parent { get; set; }
        public long? ParentId { get; set; }
        public long Level { get; set; }
        public long CheckItemId { get; set; }
        public int Origin { get; set; }
        public int ModCode { get; set; }

    }

    public class PromoModel
    {
        public int PromoEntryId { get; set; }
        public int PromoTypeId { get; set; }
        public List<int> LstEntries { get; set; }
        public string EntriesIdsSelected { get; set; }
    }
}
