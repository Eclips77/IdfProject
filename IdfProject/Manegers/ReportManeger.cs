using IdfProject.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdfProject.Manegers
{
    internal class ReportManeger
    {
        List<StrikeReport> strikeReports = new List<StrikeReport>();

        public void AddReport(StrikeReport report)
        {
            strikeReports.Add(report);
        }

        public List<StrikeReport> GetAllReports()
        {
            return this.strikeReports;
        }
    }
}
