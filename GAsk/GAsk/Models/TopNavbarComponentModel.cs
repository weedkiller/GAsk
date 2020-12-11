﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.Entity;

namespace GAsk.Models
{
    /// <summary>
    /// 顶部导航组件模型
    /// </summary>
    public class TopNavbarComponentModel
    {
        public bool IsLogin { get; set; }
        public Person Person { get; set; }
        public string SiteName { get; set; }
        public Role Role { get; set; }
    }
}
