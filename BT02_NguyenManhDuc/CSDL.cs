using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02_NguyenManhDuc
{
    class CSDL //sql fake
    {
        public DataTable DataSV { get; set; }
        public DataTable DataLSH { get; set; }
        private static CSDL _Instance;
        public static CSDL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new CSDL();
                return _Instance;
            }
            set
            {

            }
        }
        private CSDL()
        {
            DataSV = new DataTable();
            DataSV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV", typeof(string)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Gender", typeof(bool)),
                new DataColumn("Date", typeof(DateTime)),
                new DataColumn("ID_Class", typeof(int))
            });
            DataLSH = new DataTable();
            DataLSH.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_Class", typeof(int)),
                new DataColumn("Name_Class", typeof(string))
            });
            DataSV.Rows.Add(NewRowSV(new SV()
            {
                MSSV = "102190095",
                Name = "Tran Nhu Tri",
                Gender = true,
                Date = new DateTime(2001, 09, 25),
                ID_Class = 1
            }));
            DataSV.Rows.Add(NewRowSV(new SV()
            {
                MSSV = "102190096",
                Name = "Duc",
                Gender = true,
                Date = new DateTime(2001, 09, 25),
                ID_Class = 2
            }));
            DataSV.Rows.Add(NewRowSV(new SV()
            {
                MSSV = "102190097",
                Name = "Minh",
                Gender = true,
                Date = new DateTime(2001, 09, 25),
                ID_Class = 1
            }));
            DataLSH.Rows.Add(NewRowLSH(new LSH()
            {
                ID = 1,
                Name = "19TCLC-DT2"
            }));
            DataLSH.Rows.Add(NewRowLSH(new LSH()
            {
                ID = 2,
                Name = "19TCLC-DT3"
            }));
        }
        public DataRow NewRowSV(SV sv)
        {
            DataRow r = DataSV.NewRow();
            r["MSSV"] = sv.MSSV;
            r["Name"] = sv.Name;
            r["Gender"] = sv.Gender;
            r["Date"] = sv.Date;
            r["ID_Class"] = sv.ID_Class;
            return r;
        }
        public DataRow NewRowLSH(LSH cl)
        {
            DataRow r = DataLSH.NewRow();
            r["ID_Class"] = cl.ID;
            r["Name_Class"] = cl.Name;
            return r;
        }
        public void AddNewSV(SV sv)
        {
            DataSV.Rows.Add(NewRowSV(sv));
        }
        public void UpdateRowSV(SV sv)
        {
            foreach(DataRow i in CSDL.Instance.DataSV.Rows)
            {
                if(i["MSSV"].ToString() == sv.MSSV)
                {
                    i["Name"] = sv.Name;
                    i["Gender"] = sv.Gender;
                    i["Date"] = sv.Date;
                    i["ID_Class"] = sv.ID_Class;
                    break;
                }
            }
        }
    }
}
