using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02_NguyenManhDuc
{
    class CSDL_OOP
    {
        private static CSDL_OOP _Instance;
        public static CSDL_OOP Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new CSDL_OOP();
                return _Instance;
            }
            set
            {

            }
        }
        private CSDL_OOP() { }
        public List<LSH> GetAllClass()
        {
            List<LSH> data = new List<LSH>();
            foreach(DataRow r in CSDL.Instance.DataLSH.Rows)
            {
                data.Add(new LSH()
                {
                    ID = Convert.ToInt32(r["ID_Class"]),
                    Name = r["Name_Class"].ToString()
                });
            }
            return data;
        }
        public List<SV> GetAllSV()
        {
            List<SV> data = new List<SV>();
            foreach (DataRow r in CSDL.Instance.DataSV.Rows)
            {
                data.Add(new SV()
                {
                    MSSV = r["MSSV"].ToString(),
                    Name = r["Name"].ToString(),
                    Gender = Convert.ToBoolean(r["Gender"]),
                    Date = Convert.ToDateTime(r["Date"]),
                    ID_Class = Convert.ToInt32(r["ID_Class"])
                });
            }
            return data;
        }
        public List<SV> GetListSV(int id_class, string name)
        {
            List<SV> data = new List<SV>();
            foreach (SV i in CSDL_OOP.Instance.GetAllSV())
            {
                if ((i.ID_Class == id_class || id_class == 0) && i.Name.Contains(name))
                    data.Add(i);
            }
            return data;
        }
        public SV GetSVByID(string MSSV)
        {
            foreach (SV i in CSDL_OOP.Instance.GetAllSV())
                if (i.MSSV == MSSV)
                    return i;
            return null;
        }
        public void UpdateSV(SV sv)
        {
            CSDL.Instance.UpdateRowSV(sv);
        }
        public void AddSV(SV sv)
        {
            CSDL.Instance.AddNewSV(sv);
        }
    }
}
