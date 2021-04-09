using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class room_DTO
    {
        #region KHAI BAO
        private string  id;
        private string name;
        private int status;
        private string stt_name;
        private string type_name;
        private int type;
        public string Id { get => id; set => id = value; }
        private string temp;
        public int Status { get => status; set => status = value; }
        public int Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public string Stt_name { get => stt_name; set => stt_name = value; }
        public string Type_name { get => type_name; set => type_name = value; }
        public string Temp { get => temp; set => temp = value; }
        #endregion
        #region HAM KHOI TAO
        public room_DTO(string id,string name, int type, int status,string stt_name,string type_name) 
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.Type = type;
            this.Stt_name = stt_name;
            this.Type_name = type_name;
        }
        public room_DTO(DataRow row)
        {
            this.Id = row["ID"].ToString();
            this.Name = row["Tenphong"].ToString();
            this.Status = (int)row["Idtinhtrang"];
            this.Type = (int)row["Idloai"];
            this.Type_name = row["Tenloaiphong"].ToString();
            this.Stt_name = row["Tentinhtrang"].ToString();
        }
        public room_DTO(string temp)
        {
            this.Temp = temp;
        }
        #endregion
    }
}
