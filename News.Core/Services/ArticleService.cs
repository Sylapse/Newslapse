using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace News.Core.Services
{
    public interface IArticleService {
        Task<SuperCategory> GetSuperCategory ();
        Task<Category> GetCategory(int id);
        Task<Article> GetArticle(int id);
    }

    public class ArticleService : IArticleService
    {
        private readonly IHttpService _httpService;

        public ArticleService (
            IHttpService httpService)
        {
            _httpService = httpService;
        }

        public Task<SuperCategory> GetSuperCategory()
        {
            return GetContentItem<SuperCategory> (21);
        }

        public Task<Category> GetCategory(int id)
        {
            return GetContentItem<Category> (id);
        }

        public Task<Article> GetArticle(int id)
        {
            return GetContentItem<Article> (id);
        }

        private async Task<T> GetContentItem<T>(int id)
        {
            var response = await _httpService.GetAsync (string.Format("api/Raven.Api/Item/{0}", id));
            var item = await _httpService.ReadContentAsync<T> (response);
            return item;
        }
    }
}

