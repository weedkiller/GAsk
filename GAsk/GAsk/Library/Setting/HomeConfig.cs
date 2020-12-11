﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GAsk.Library.Setting
{
    /// <summary>
    /// 首页配置
    /// </summary>
    public class HomeConfig
    {
        /// <summary>
        /// 网站名称
        /// </summary>
        [Display(Name = "网站名称")]
        [Required(ErrorMessage ="不能为空")]
        public string SiteName { get; set; } = "ask";

        /// <summary>
        /// 根域名URL
        /// </summary>
        [Display(Name = "根域名URL")]
        [Required(ErrorMessage = "不能为空")]
        public string SiteUrl { get; set; }

        /// <summary>
        /// 统计代码
        /// </summary>
        [Display(Name = "统计代码")]
        public string CensusCode { get; set; }

        /// <summary>
        /// 首页关键词
        /// </summary>
        [Display(Name = "首页描叙")]
        public string SeoDescription { get; set; }

        /// <summary>
        /// 网站Footer
        /// </summary>
        [Display(Name = " 网站Footer")]
        [Required(ErrorMessage = "不能为空")]
        public string SiteFooter { get; set; } = "ask";        
    }
}

