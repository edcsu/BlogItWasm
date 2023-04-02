using BlogItWasm.Data.Models;

namespace BlogItWasm.Services;

public interface IBlogApi
{
    Task<int> GetBlogPostCountAsync();
    Task<List<BlogPost>?> GetBlogPostsAsync(int numberOfPosts, int startIndex);
    Task<List<Category>?> GetCategoriesAsync();
    Task<List<Tag>?> GetTagsAsync();
    Task<BlogPost?> GetBlogPostAsync(Guid id);
    Task<Category?> GetCategoryAsync(Guid id);
    Task<Tag?> GetTagAsync(Guid id);
    Task<BlogPost?> SaveBlogPostAsync(BlogPost item);
    Task<Category?> SaveCategoryAsync(Category item);
    Task<Tag?> SaveTagAsync(Tag item);
    Task DeleteBlogPostAsync(Guid id);
    Task DeleteCategoryAsync(Guid id);
    Task DeleteTagAsync(Guid id);
    Task InvalidateCacheAsync();
}