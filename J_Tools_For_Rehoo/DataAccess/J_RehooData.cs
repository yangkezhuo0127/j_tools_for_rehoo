using dbAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace J_Tools_For_Rehoo.DataAccess
{
    public class J_RehooData
    {
        private SqlOperator db;



        public J_RehooData()
        {
            this.db = new SqlOperator(@"Server=115.29.179.174;Initial Catalog=RehooTools;Integrated Security=false;User ID=jz1;Password=jz6666281886");
        }


        /// <summary>
        /// 向数据库添加文件
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="guid"></param>
        /// <param name="fileName"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public bool AddFiles(string TableName, Guid guid, string fileName, string filePath)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("guid", guid);
            dict.Add("fileName", fileName);
            dict.Add("filePath", filePath);
            return db.AddData(TableName, dict);
        }



        public bool EditFont(string content)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("fileContent", content);
            return db.EditData("Font","id","1",dict);
        }


        public string ReadFontContent()
        {
            return (string)db.GetFieldValue("Font", "id", "1", "fileContent");
        }


        public bool SavePicToServer(string fileName,string filePath,Guid guid)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("guid",guid);
            dict.Add("fileName",fileName);
            dict.Add("filePath",filePath);

     
            return db.AddData("Pic", dict);
        }


        public DataTable ReadPics()
        {
            return db.GetTable("SELECT guid,fileName,filePath FROM Pic");
        }


        public bool DropTable(string TableName)
        {
            return db.ExecByProcduce("usp_droptable", new SqlParameter[] { new SqlParameter("@tableName", TableName) }) > 0;
        }
    }
}
