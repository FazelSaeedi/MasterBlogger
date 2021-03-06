using _01_Framework.Infrastructure;
using MB.Application;
using MB.Application.Contracts;
using MB.Application.Contracts.Article;
using MB.Application.Contracts.Comment;
using MB.Domain.ArticleAgg;
using MB.Domain.ArticleAgg.Services;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.CommentAgg;
using MB.Infrastructure.EFCore;
using MB.Infrastructure.EFCore.Repositories;
using MB.infrastructure.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MB.infrastructure.Core
{
    public class Bootstrapper
    {
        public static void Config(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();

            services.AddTransient<IArticleApplication, ArticleApplication>();
            services.AddTransient<IArticleRepository, ArticleRepository>();
            services.AddTransient<IArticleValidatorService, ArticleValidatorService>();

            services.AddTransient<IArticleQuery , ArticleQuery>();


            services.AddTransient<ICommentApplication , CommentApplication>();
            services.AddTransient<ICommentRepository , CommentRepository>();


            services.AddTransient<IUnitOfWork, UnitOfWorkEf>();

            services.AddDbContext<MasterBloggerContext>(options =>
                options.UseSqlServer(connectionString));
        }
    }
}
