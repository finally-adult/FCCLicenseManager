using System;
using System.Collections.Generic;

namespace FCCLicenseManager.Models
{
    public class License
    {
        public string LicName { get; set; }
        public string Frn { get; set; }
        public string CallSign { get; set; }
        public string CategoryDesc { get; set; }
        public string ServiceDesc { get; set; }
        public string StatusDesc { get; set; }
        public DateTime ExpiredDate { get; set; }
        public string LicDetailURL { get; set; }
    }
    public class Licenses
    {
        public string Page { get; set; }
        public string RowPerPage { get; set; }
        public string TotalRows { get; set; }
        public DateTime LastUpdate { get; set; }
        public List<License> License { get; set; }
    }

    public class Response
    {
        public string Status { get; set; }
        public Licenses Licenses { get; set; }
    }
}
