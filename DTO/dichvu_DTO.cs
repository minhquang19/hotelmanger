using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dichvu_DTO
    {
        #region kHAI BAO
        private string temp;
        private int idthuephong;
        private int iddichvu;
        private int soluong;
        private int int_temp;
        public string Temp { get => temp; set => temp = value; }
        public int Idthuephong { get => idthuephong; set => idthuephong = value; }
        public int Iddichvu { get => iddichvu; set => iddichvu = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Int_temp { get => int_temp; set => int_temp = value; }
        #endregion
        #region HAM KHOI TAO
        public dichvu_DTO(string temp)
        {
            this.Temp = temp;
        }
        public dichvu_DTO(int idthuephong,int iddv,int soluong)
        {
            this.Idthuephong = idthuephong;
            this.Iddichvu = iddv;
            this.Soluong = soluong;
        }
        public dichvu_DTO(int int_temp)
        {
            this.Int_temp = int_temp;
        }
        #endregion
    }
}
