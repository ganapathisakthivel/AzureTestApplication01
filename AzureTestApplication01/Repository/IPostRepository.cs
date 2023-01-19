using AzureTestApplication01.Models;

namespace AzureTestApplication01.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}
