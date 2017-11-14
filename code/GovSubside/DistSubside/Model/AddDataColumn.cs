using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;

namespace DistSubside.Model
{
    class AddDataColumn
    {

        /// <summary>
        /// 在datatable中新增欄位
        /// </summary>
        /// <param name="ColumnName">欄位名稱</param>
        /// <param name="DataType">欄位型態</param>
        /// <param name="AllowDBNull">是否允許Null</param>
        /// <param name="Caption">取得或設定資料行的標題</param>
        /// <param name="DefaultValue">在建立新資料列時，取得或設定資料行的預設值</param>
        /// <returns></returns>
        public DataColumn NewColumn(string ColumnName, string DataType, Boolean AllowDBNull, string Caption, string DefaultValue)
        {
            //建立DataColumn並設定相關欄位屬性
            DataColumn column = new DataColumn(ColumnName);
            column.DataType = System.Type.GetType(DataType);
            column.AllowDBNull = AllowDBNull;//true
            column.Caption = Caption; //"SchdlDateVVV"
            column.DefaultValue = DefaultValue;
            return column;
        }

    }
}
