﻿using System;
using System.Xml.Linq;

namespace Automa.IO.Unanet.Reports
{
    public class ReportBase
    {
        public static DateTime EnsureBeginOfWeek(DateTime date) => date.AddDays(-(int)date.DayOfWeek + 1);
        public readonly static DateTime BeginFinanceDate = new DateTime(2018, 01, 01);
        public readonly static DateTime BeginDate = new DateTime(2019, 01, 01);

        protected static XAttribute XAttribute(string name, string value) => !string.IsNullOrEmpty(value) ? new XAttribute(name, value) : null;
        protected static XAttribute XAttribute<T>(string name, T? value) where T : struct => value != null ? new XAttribute(name, value) : null;
    }
}