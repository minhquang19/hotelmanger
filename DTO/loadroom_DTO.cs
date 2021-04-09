using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class loadroom_DTO
    {
        #region KHAI BAO
        private string id;
        private string name;
        private int status;
        private int type;
        private string temp;
        private string key;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Status { get => status; set => status = value; }
        public int Type { get => type; set => type = value; }
        public string Temp { get => temp; set => temp = value; }
        public string Key { get => key; set => key = value; }
        #endregion
        #region HAM KHOI TAO
        public loadroom_DTO(string id,string name,int type, int status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.Type = type;
        }
        public loadroom_DTO(string id, string name, int type, int status,string temp)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.Type = type;
            this.Temp = temp;
        }
        public loadroom_DTO(string id)
        {
            this.Id = id;
        }    
        public loadroom_DTO (string key,string mt)
        {
            this.Key = key;
        }
        #endregion
    }
}
