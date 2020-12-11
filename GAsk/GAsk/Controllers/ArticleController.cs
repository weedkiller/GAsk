﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.BBL;
using GAsk.Library.Entity;
using GAsk.Library.Extensions;
using GAsk.Models;
using Microsoft.AspNetCore.Mvc;
using GAsk.Library.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using FengCode.Libs.Utils.Paging;

namespace GAsk.Controllers
{
    public class ArticleController : Controller
    {
        private readonly PostService postService;
        private readonly PersonService personService;

        public ArticleController(PostService postService, PersonService personService)
        {
            this.postService = postService ?? throw new ArgumentNullException(nameof(postService));
            this.personService = personService ?? throw new ArgumentNullException(nameof(personService));
        }

        public async Task<IActionResult> Index(Guid topic, FilterType filter = FilterType.New, int page = 1)
        {
            if (page < 1)
            {
                return NotFound();
            }
            PagingResult<PostView> postViews = await postService.GetPagingResultAsync(topic, PostResultType.Article, page, filter);
            if (postViews.PageCount > 1 && page > postViews.PageCount)
            {
                return NotFound();
            }
            ArticleIndexModel model = new ArticleIndexModel
            {
                PostViews = postViews
            };
            return this.View(model);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            Post post = await this.postService.GetPostByIdAsync(id);
            if (post == null || post.PostStatus != PostStatus.Publish || post.PostType != PostType.Article)
            {
                return NotFound();
            }
            else
            {
                await this.postService.IncreaseViewNumAsync(post);
                PersonView person = await this.personService.GetPersonViewAsync(post.PersonId);
                ArticleDetailsModel model = new ArticleDetailsModel { Post = post, Person = person };
                return View(model);
            }
        }
    }
}
