using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace wpfSample.Objects
{
    public class Customer
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 電話番号
        /// </summary>
        public string Phone { get; set; }
    }
}
