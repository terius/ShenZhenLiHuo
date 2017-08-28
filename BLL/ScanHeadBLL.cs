using DAL;
using System;
using System.Data;

namespace BLL
{
    public class ScanHeadBLL
    {
        private readonly COMMON comm = new COMMON();
        public ScanHeadInfo GetScanHeadInfo()
        {
            DataRow dr = comm.GetOneRow("select top 1 from EHS_SCAN_HEAD");
          
            ScanHeadInfo info = new ScanHeadInfo();
            return info;
        }
    }

    public class ScanHeadInfo
    {
        public Guid ID { get; set; }
        public string SHIP_ID { get; set; }
        public string VOYAGE_NO { get; set; }
        public string BILL_NO { get; set; }
        public string I_E_FLAG { get; set; }
        public double? PACK_NO { get; set; }
        public DateTime? I_E_DATE { get; set; }
        public string DEC_TYPE { get; set; }
        public string DEC_TYPE2 { get; set; }
        public string SCAN_FLAG { get; set; }
        public DateTime? SCAN_TIME { get; set; }
        public double? SCAN_PACK { get; set; }
    }
}
