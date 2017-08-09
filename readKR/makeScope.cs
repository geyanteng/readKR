using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataModels;
using System.Windows.Forms;
namespace readKR
{
    public  class makeScope
    {
        static public string getScope(KRV_CATEGORY krv_category)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            StringBuilder sb = new StringBuilder();
            string builddate = DateToText(krv_category.DATE_BUILD_L, krv_category.DATE_BUILD_H);
            string effDate = DateToText(krv_category.DATE_EFFECTIVE);
            string expDate = DateToText(krv_category.DATE_EXP);
            if (!string.IsNullOrEmpty(effDate))
                sb.Append(string.Format("生效日期：{0}\r\n", effDate));
            if (!string.IsNullOrEmpty(expDate))
                sb.Append(string.Format("失效日期：{0}\r\n", expDate));
            if (builddate != string.Empty)
                sb.Append(string.Format("安放龙骨日期：{0}\r\n", builddate));
            string shipLength = intToText(krv_category.LF_L, krv_category.LF_H);
            string shipLength1 = intToText(krv_category.LF_L_1, krv_category.LF_H_1);
            if (!string.IsNullOrEmpty(shipLength))
            {
                if (string.IsNullOrEmpty(shipLength1))
                    sb.Append(string.Format("船长：{0}\r\n", shipLength));
                else
                    sb.Append(string.Format("船长：{0}或{1}\r\n", shipLength, shipLength1));
            }            
            string grossTon = intToText(krv_category.GT_L, krv_category.GT_H);
            string grossTon1 = intToText(krv_category.GT_L_1, krv_category.GT_H_1);
            if (!string.IsNullOrEmpty(grossTon))
            {
                if (string.IsNullOrEmpty(grossTon1))
                    sb.Append(string.Format("总吨：{0}\r\n", grossTon));
                else
                    sb.Append(string.Format("总吨：{0}或{1}\r\n", grossTon, grossTon1));
            }                
            string passNum = intToText(krv_category.PASS_TOTAL_L, krv_category.PASS_TOTAL_H);
            string passNum1 = intToText(krv_category.PASS_TOTAL_L_1, krv_category.PASS_TOTAL_H_1);
            if (!string.IsNullOrEmpty(passNum))
            {
                if (string.IsNullOrEmpty(passNum1))
                    sb.Append(string.Format("乘客数：{0}\r\n", passNum));
                else
                    sb.Append(string.Format("乘客数：{0}或{1}\r\n", passNum, passNum1));
            }
               
            if (!string.IsNullOrEmpty(krv_category.NOTE))
                sb.Append(string.Format("Note:{0}\r\n", krv_category.NOTE));
            if (krv_category.IS_BACKTO == true)
                sb.Append("回溯：此条款具有回溯效力，对所有现有船舶有效\r\n");
            string contractdate = DateToText(krv_category.CONTRACT_DATE_L, krv_category.CONTRACT_DATE_H);
            string deliverydate = DateToText(krv_category.DELIVERY_DATE_L, krv_category.DELIVERY_DATE_H);
            if(contractdate != string.Empty)
                sb.Append(string.Format("签订造船合同日期：{0}\r\n", contractdate));
            if (deliverydate != string.Empty)
                sb.Append(string.Format("交船日期：{0}\r\n", deliverydate));
            string shipscope = shipScope(krv_category);
            if(!string.IsNullOrEmpty(shipscope))
                sb.Append(string.Format("适用船舶：{0}",shipscope));
            return sb.ToString();
        }
        static public string DateToText(DateTime? dateL, DateTime? dateH)
        {
            if (dateH == null && dateL == null)
                return string.Empty;
            else if (dateL != null && dateH == null)
                return string.Format("自{0}以后", ((DateTime)dateL).ToShortDateString());
            else if (dateL != null && dateH != null)
                return string.Format("{0}至{1}", ((DateTime)dateL).ToShortDateString(), ((DateTime)dateH).ToShortDateString());
            else
                return string.Format("{0}以前", ((DateTime)dateH).ToShortDateString());
        }
        static public string DateToText(DateTime? date)
        {
            if (date == null)
                return string.Empty;
            else
                return  ((DateTime)date).ToShortDateString().ToString();
        }
        static public string intToText(int? valL, int? valH)
        {
            if ((valL == null || valL == 0) && (valH == null || valH == 0))
                return string.Empty;
            else if ((valL == null || valL == 0) && !(valH == null || valH == 0))
                return string.Format("小于{0}", valH);
            else if (!(valL == null || valL == 0))
                return string.Format("大于{0}", valL);
            else
                return string.Format("{0}~{1}", valL, valH);
        }
        static public string shipScope(KRV_CATEGORY krv_category)
        {
            List<string> shipTypes = new List<string>();
            if (krv_category.SHIP_All == true)
                shipTypes.Add("All Ships");
            if (krv_category.SHIP_ALL_CARGO == true)
                shipTypes.Add("All Cargo Ships");
            if (krv_category.SHIP_OIL_TANKERS == true)
                shipTypes.Add("Oil Tankers");
            if (krv_category.SHIP_OILCHEMICAL_TANKERS == true)
                shipTypes.Add("Oil / Chemical Tankers");
            if (krv_category.SHIP_CHEMICAL_TANKERS == true)
                shipTypes.Add("Chemical Tankers");
            if (krv_category.SHIP_GAS_CARRIERS == true)
                shipTypes.Add("Gas Carriers");
            if (krv_category.SHIP_BULK_CARRIERS == true)
                shipTypes.Add("Bulk Carriers");
            if (krv_category.SHIP_OTHER_CARGO == true)
                shipTypes.Add("Other Cargo Ship(Container, General Cargo, PCC...)");
            if (krv_category.SHIP_ALL_PASSENGER == true)
                shipTypes.Add("All Passenger Ships");
            if (krv_category.SHIP_RORO_PASSENGER == true)
                shipTypes.Add("Ro-Ro Passenger Ships");
            if (krv_category.SHIP_PASSENGER == true)
                shipTypes.Add("Passenger Ships");
            if (krv_category.SHIP_HIGH_SPEED_CRAFT == true)
                shipTypes.Add("High Speed Craft");
            if (krv_category.SHIP_MODU == true)
                shipTypes.Add("MODU");           
            return string.Format("{0}", string.Join("、", shipTypes));
        }
    }
}
