﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Utils.Paging;
using GAsk.Library.Entity;

namespace GAsk.Models
{
    /// <summary>
    /// 用户文章视图模型
    /// </summary>
    public class UserArticleViewModel
    {
        public PagingResult<PostView> PagingResult { get;}
        public PersonView PersonView { get; }

        public UserArticleViewModel(PagingResult<PostView> pagingResult, PersonView personView)
        {
            PagingResult = pagingResult ?? throw new ArgumentNullException(nameof(pagingResult));
            PersonView = personView ?? throw new ArgumentNullException(nameof(personView));
        }
    }
}
