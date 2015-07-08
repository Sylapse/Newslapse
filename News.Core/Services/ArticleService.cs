using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace News.Core
{
    public interface IArticleService {
        Task<SuperCategory> GetCategories ();
        Task<Category> GetCategory(int id);
    }

    public class ArticleService : IArticleService
    {
        private readonly IHttpService _httpService;

        public ArticleService (
            IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<SuperCategory> GetCategories()
        {
            var response = await _httpService.GetAsync ("Raven.Api/Item/21");
            var superCategory = await _httpService.ReadContentAsync<SuperCategory> (response);
            return superCategory;
        }

        public async Task<Category> GetCategory(int id)
        {
            var response = await _httpService.GetAsync (string.Format("Raven.Api/Item/{0}", id));
            var category = await _httpService.ReadContentAsync<Category> (response);
            return category;
        }
    }
}

